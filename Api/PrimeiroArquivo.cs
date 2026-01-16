using System.IO;

namespace encapsulamento;

public class PrimeiroArquivo
{
    public static void Executar()
    {
        var path = @"~/primeiro_arquivo.txt";

        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Esse e o nosso");
                sw.WriteLine("primeiro arquivo");
                sw.WriteLine("Parabéns pela evolução");
            }
        }
    }
}
