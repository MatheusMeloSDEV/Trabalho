using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLUSA
{
    public class AtualizadorGithub
    {
        private readonly string repoUrl;
        private readonly string assetExt;

        // Eventos para notificação
        public event Action<string, string>? AtualizacaoDisponivel; // novaVersao, versaoAtual
        public event Action<string>? DownloadConcluido;
        public event Action<string>? Erro;
        public event Action? Atualizado;

        public AtualizadorGithub(string repoUrl, string assetExt = ".exe")
        {
            this.repoUrl = repoUrl.TrimEnd('/');
            this.assetExt = assetExt;
        }

        public async Task VerificarAtualizacaoAsync(string? versaoAtual = null)
        {
            string url = $"{repoUrl}/releases/latest";
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("SeuApp/1.0");

            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                Erro?.Invoke($"Erro ao buscar atualização: {response.StatusCode} - {response.ReasonPhrase}");
                return;
            }
            var content = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(content);
            string? versaoMaisRecente = doc.RootElement.GetProperty("tag_name").GetString();
            versaoAtual ??= System.Reflection.Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "0.0.0.0";

            string NormalizarVersao(string? v)
            {
                if (string.IsNullOrWhiteSpace(v)) return "";
                var partes = v.TrimStart('v', 'V').Split('-')[0].Split('.');
                // Pega apenas os três primeiros componentes
                return string.Join(".", partes.Take(3));
            }

            if (!string.IsNullOrEmpty(versaoMaisRecente) && NormalizarVersao(versaoMaisRecente) != NormalizarVersao(versaoAtual))
            {
                AtualizacaoDisponivel?.Invoke(versaoMaisRecente, versaoAtual);
            }
        }

        public async Task BaixarEInstalarAsync()
        {
            string url = $"{repoUrl}/releases/latest";
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("SeuApp/1.0");

            var response = await client.GetStringAsync(url);
            using var doc = JsonDocument.Parse(response);
            var assets = doc.RootElement.GetProperty("assets");
            string? downloadUrl = null;
            foreach (var asset in assets.EnumerateArray())
            {
                var nome = asset.GetProperty("name").GetString();
                if (!string.IsNullOrEmpty(nome) && nome.EndsWith(assetExt, StringComparison.OrdinalIgnoreCase))
                {
                    downloadUrl = asset.GetProperty("browser_download_url").GetString();
                    break;
                }
            }

            if (string.IsNullOrEmpty(downloadUrl))
            {
                Erro?.Invoke("Não foi encontrado um instalador para download.");
                return;
            }

            string tempPath = Path.Combine(Path.GetTempPath(), Path.GetFileName(downloadUrl));
            using (var download = await client.GetAsync(downloadUrl))
            using (var fs = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await download.Content.CopyToAsync(fs);
            }

            DownloadConcluido?.Invoke(tempPath);

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = tempPath,
                    Arguments = "/VERYSILENT",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Erro?.Invoke($"Erro ao iniciar o instalador: {ex.Message}");
            }
        }
    }
}