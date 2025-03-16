using System.Diagnostics;
namespace CLUSA
{
    public static class ExportadorPythonRunner
    {
        public static string ExecutarExportador(string importador)
        {
            try
            {
                string exeFullPath = @"C:\UsaAPP\Exportador\dist\exportador.exe";

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
    }

}
