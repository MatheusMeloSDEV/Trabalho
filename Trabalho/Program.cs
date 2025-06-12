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

            // Verificação automática de atualização
            var atualizador = new AtualizadorGithub(
                "https://api.github.com/repos/MatheusMeloSDEV/UsaDespachos",
                ".exe" // ou ".msi" conforme seu instalador
            );

            bool atualizarAgora = false;

            atualizador.AtualizacaoDisponivel += (nova, atual) =>
            {
                var result = MessageBox.Show(
                    $"Versão atual: {atual}\nNova versão disponível: {nova}\nDeseja atualizar agora?",
                    "Atualização disponível",
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
                MessageBox.Show($"Download concluído: {path}");
                Application.Exit();
            };
            atualizador.Erro += msg => MessageBox.Show($"Erro: {msg}");         

            // Aguarda a verificação antes de abrir o sistema
            atualizador.VerificarAtualizacaoAsync().GetAwaiter().GetResult();   

            // Só abre o login se não for atualizar agora
            if (!atualizarAgora)
            {
                Application.Run(new FrmLogin());
            }
        }
    }
}
