using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Runtime.Versioning;

public class PythonExecutor
{
    [SupportedOSPlatform("windows")]
    public static void VerificarEInstalarPacotes()
    {
        string pythonPath = EncontrarPython(); // Tenta localizar o Python no sistema

        if (string.IsNullOrEmpty(pythonPath))
        {
            Console.WriteLine("Python não encontrado. Instale o Python e tente novamente.");
            return;
        }

        InstalarPacotesPython(pythonPath);
    }

    [SupportedOSPlatform("windows")]
    private static string EncontrarPython()
    {
        // Tenta localizar o Python no registro do Windows
        using (RegistryKey? key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Python\PythonCore"))
        {
            if (key != null)
            {
                foreach (string subkey in key.GetSubKeyNames())
                {
                    using (RegistryKey? installKey = key.OpenSubKey(subkey + @"\InstallPath"))
                    {
                        if (installKey != null)
                        {
                            object? value = installKey.GetValue("ExecutablePath");
                            if (value != null)
                            {
                                return value.ToString();
                            }
                        }
                    }
                }
            }
        }

        // Se não encontrou no Registro, tenta buscar no PATH
        return BuscarPythonNoPath();
    }

    private static string BuscarPythonNoPath()
    {
        string? pathEnv = Environment.GetEnvironmentVariable("PATH");
        if (string.IsNullOrEmpty(pathEnv))
            return string.Empty;

        foreach (string path in pathEnv.Split(';'))
        {
            string potentialPython = Path.Combine(path, "python.exe");
            if (File.Exists(potentialPython))
            {
                return potentialPython;
            }
        }

        return string.Empty;
    }

    private static void InstalarPacotesPython(string pythonPath)
    {
        Console.WriteLine("Verificando pacotes Python...");

        string argumentos = "-m pip install --upgrade pip pymongo pandas openpyxl";

        try
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string errors = process.StandardError.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine("Saída do pip:");
                Console.WriteLine(output);

                if (!string.IsNullOrEmpty(errors))
                {
                    Console.WriteLine("Erros:");
                    Console.WriteLine(errors);
                }
                else
                {
                    Console.WriteLine("Pacotes instalados com sucesso!");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao instalar pacotes Python: {ex.Message}");
        }
    }
}
