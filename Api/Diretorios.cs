namespace encapsulamento;

public class Diretorios
{
    public static void Executar()
    {
        var novoDir = @"~/PastaChasrp".ParseHome();
        var novoDirDestino = @"~/PastaCharpDestino".ParseHome();
        var dirProjeto = @"~/source/repos/cursoCSharp/cursoCSharp".ParseHome();

        if(Directory.Exists(novoDir)) Directory.Delete(novoDir, true);

        if(Directory.Exists(novoDirDestino)) Directory.Delete(novoDirDestino, true);

        Directory.CreateDirectory(novoDir);
        Console.WriteLine(Directory.GetCreationTime(novoDir));


        Console.WriteLine("===Pastas===========");
        var pastas = Directory.GetDirectories(dirProjeto);

        foreach(var pasta in pastas) Console.WriteLine(pasta);
        

        var arquivos = Directory.GetFiles(dirProjeto);

        foreach(var arquivo in arquivos) Console.Write(arquivo);
    }
}
