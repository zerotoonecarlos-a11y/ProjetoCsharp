namespace FundamentosCSharp;

public class ExemploFileInfo
{

    public static void ExcluirSeExistir(params string[] caminhos)
    {
        foreach (var caminho in caminhos)
        {
            var arquivo = new FileInfo(caminho);

            if (arquivo.Exists)
            {
                arquivo.Delete();
            }
        }
    }

    public static void Executar()
    {
        var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
        var caminhoDetino = @"ãrq_destino.txt".ParseHome();
        var caminhoCopia = @"arq_copia.txt".ParseHome();

        ExcluirSeExistir(caminhoOrigem, caminhoDetino, caminhoCopia);

        using (StreamWriter sw = File.CreateText(caminhoOrigem))
        {
            sw.WriteLine("Testando código");

            var origem = new FileInfo(caminhoOrigem);

            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDetino);
        }
    }
}
