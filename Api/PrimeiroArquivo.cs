using System;
using System.IO;

namespace FundamentosCSharp;

public static class ExtensaoString
{
    public static string ParseHome(this string path)
    {
        string home = System.OperatingSystem.IsWindows()
                 ? (Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") ?? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))
                 : (Environment.GetEnvironmentVariable("HOME") ?? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

        return path.Replace("~", home);
    }
}
public class PrimeiroArquivo
{
    public static void Executar()
    {
        // O método GetFolderPath com SpecialFolder.UserProfile obtém o diretório pessoal do usuário,
        // que funciona tanto no Linux (/home/username) quanto no Windows (C:\Users\username).
        var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var fileName = "primeiro_arquivo.txt";

        // Path.Combine é a forma mais segura de montar caminhos de arquivo,
        // pois lida com as barras (/) ou contra-barras (\) corretas para cada sistema.
        var path = Path.Combine(homeDirectory, fileName);

        Console.WriteLine($"Verificando a existência do arquivo em: {path}");

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Verificando   \r");
            Thread.Sleep(200);
            Console.WriteLine("Verificando.  \r");
            Thread.Sleep(200);
            Console.WriteLine("Verificando.. \r");
            Thread.Sleep(200);
            Console.WriteLine("Verifcando... \r");
            Thread.Sleep(200);
            Console.Clear();


        }

        if (!File.Exists(path))
        {
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse e o nosso");
                    sw.WriteLine("primeiro arquivo!");
                    sw.WriteLine("Parabéns pela evolução");
                }
                Console.WriteLine("Arquivo criado e conteúdo escrito com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao criar o arquivo: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("O arquivo já existe. Nenhuma ação foi necessária.");
        }
    }
}
