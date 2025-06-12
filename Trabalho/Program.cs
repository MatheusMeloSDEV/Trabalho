using MongoDB.Bson.Serialization;
using CLUSA;
using System;
using System.Windows.Forms;

namespace Trabalho
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Registre o mapeamento apenas uma vez
            if (!BsonClassMap.IsClassMapRegistered(typeof(LiInfo)))
            {
                BsonClassMap.RegisterClassMap<LiInfo>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIgnoreExtraElements(true);
                });
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verifica��o autom�tica de atualiza��o
            var atualizador = new AtualizadorGithub(
                "https://api.github.com/repos/MatheusMeloSDEV/UsaDespachos",
                ".exe" // ou ".msi" conforme seu instalador
            );

            bool atualizarAgora = false;

            atualizador.AtualizacaoDisponivel += (nova, atual) =>
            {
                var result = MessageBox.Show(
                    $"Vers�o atual: {atual}\nNova vers�o dispon�vel: {nova}\nDeseja atualizar agora?",
                    "Atualiza��o dispon�vel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    atualizarAgora = true;
                    atualizador.BaixarEInstalarAsync().GetAwaiter().GetResult();
                }
            };
            atualizador.DownloadConcluido += path =>
            {
                MessageBox.Show($"Download conclu�do: {path}");
                Application.Exit();
            };
            atualizador.Erro += msg => MessageBox.Show($"Erro: {msg}");         

            // Aguarda a verifica��o antes de abrir o sistema
            atualizador.VerificarAtualizacaoAsync().GetAwaiter().GetResult();   

            // S� abre o login se n�o for atualizar agora
            if (!atualizarAgora)
            {
                Application.Run(new FrmLogin());
            }
        }
    }
}
