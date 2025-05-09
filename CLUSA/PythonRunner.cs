using System.Diagnostics;
namespace CLUSA
{
    public static class PythonRunner
    {
        public static string ExecutarExportador(string importador)
        {
            try
            {
                string exeFullPath = @"C:\UsaDespachos\Exportador\dist\exportador.exe";

                if (!File.Exists(exeFullPath))
                {
                    return $"Arquivo executável não encontrado: {exeFullPath}";
                }

                ProcessStartInfo startInfo = new()
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
        public static string ExecutarFaturamento(string importador, string referencia)
        {
            try
            {
                string exeFullPath = @"C:\UsaDespachos\Faturamento\dist\faturamento.exe";
                if (!File.Exists(exeFullPath))
                    return $"Arquivo executável não encontrado: {exeFullPath}";

                var startInfo = new ProcessStartInfo
                {
                    FileName = exeFullPath,
                    Arguments = $"\"{referencia}\" \"{importador}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using var process = Process.Start(startInfo);
                if (process == null)
                    return "Erro: Não foi possível iniciar o processo.";

                string stdout = process.StandardOutput.ReadToEnd();
                string stderr = process.StandardError.ReadToEnd();
                process.WaitForExit();

                // 1) Se exit code != 0, trate como erro
                if (process.ExitCode != 0)
                    return $"Erro na execução do script (exit code {process.ExitCode}): {stderr.Trim()}";

                // 2) Se exit code == 0, ignore stderr e filtre o PDF em stdout
                var pdfLines = stdout
                    .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(l => l.Trim())
                    .Where(l => l.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (pdfLines.Count > 0)
                    return pdfLines.Last();

                // 3) Se não encontrou linha .pdf, devolva stdout completo para diagnóstico
                return $"Caminho de PDF não encontrado na saída:\n{stdout.Trim()}";
            }
            catch (Exception ex)
            {
                return $"Exceção ao executar o script: {ex.Message}";
            }
        }
        public static string ExecutarRecibo(string importador, string referencia)
        {
            try
            {
                string exeFullPath = @"C:\UsaDespachos\Recibo\dist\recibo.exe";
                if (!File.Exists(exeFullPath))
                    return $"Arquivo executável não encontrado: {exeFullPath}";

                var startInfo = new ProcessStartInfo
                {
                    FileName = exeFullPath,
                    Arguments = $"\"{referencia}\" \"{importador}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using var process = Process.Start(startInfo);
                if (process == null)
                    return "Erro: Não foi possível iniciar o processo.";

                string stdout = process.StandardOutput.ReadToEnd();
                string stderr = process.StandardError.ReadToEnd();

                if (!process.WaitForExit(70000)) // 70 segundos
                {
                    process.Kill();
                    return "Erro: o processo excedeu o tempo limite e foi encerrado.";
                }

                if (process.ExitCode != 0)
                    return $"Erro na execução do script (exit code {process.ExitCode}): {stderr.Trim()}";

                if (!string.IsNullOrWhiteSpace(stderr))
                    Console.WriteLine($"[stderr]: {stderr.Trim()}");

                var pdfLines = stdout
                    .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(l => l.Trim())
                    .Where(l => l.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return pdfLines.Count > 0
                    ? pdfLines.Last()
                    : $"Caminho de PDF não encontrado na saída:\n{stdout.Trim()}";
            }
            catch (Exception ex)
            {
                return $"Exceção ao executar o script: {ex.Message}";
            }
        }
    }
}
