using System;
using System.Diagnostics;
using System.IO;

public static class ExportadorPythonRunner
{
    public static string ExecutarExportador(string importador)
    {
        try
        {
            // Sobe 3 níveis a partir do diretório atual (bin\Debug\net6.0-windows) para chegar à pasta "Trabalho"
            string? basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName;
            if (string.IsNullOrEmpty(basePath))
            {
                // Se não for possível subir os níveis, usa o diretório atual (não recomendado, mas como fallback)
                basePath = AppDomain.CurrentDomain.BaseDirectory;
            }

            // Define o caminho relativo ao executável a partir da pasta "Trabalho"
            string relativePath = Path.Combine("Codigos","Python Program", "dist", "exportador.exe");
            string exeFullPath = Path.Combine(basePath, relativePath);

            if (!File.Exists(exeFullPath))
            {
                return $"Arquivo executável não encontrado: {exeFullPath}";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = exeFullPath,
                Arguments = $"\"{importador}\"",  // Passa o importador como argumento
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using Process? process = Process.Start(startInfo);
            if (process == null)
            {
                return "Erro: Não foi possível iniciar o processo.";
            }

            string output = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(errors))
            {
                return $"Erro na execução do script: {errors}";
            }
            return output;
        }
        catch (Exception ex)
        {
            return $"Exceção ao executar o script: {ex.Message}";
        }
    }
}
