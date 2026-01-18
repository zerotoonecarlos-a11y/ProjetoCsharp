using System.ComponentModel.DataAnnotations;

namespace FundamentosCSharp;

public class ExemploDirectoryInfo
{
    public static void Executar()
    {
           var dirProjeto = @"~/source/repos/cursoCSharp/cursoCSharp".ParseHome();
           var dirInfo = new DirectoryInfo(dirProjeto);

           if(!dirInfo.Exists) dirInfo.Create();

           Console.WriteLine("== Arquivo ========");

           var arquivos = dirInfo.GetFiles();
           foreach(var arquivo in arquivos) Console.WriteLine(arquivo);

           Console.WriteLine("\n\n== Diretorios ========");
           var pastas = dirInfo.GetDirectories();
           foreach(var pasta in pastas) Console.WriteLine(pasta);

           Console.WriteLine(dirInfo.FullName);
           Console.WriteLine(dirInfo.Parent);
           Console.WriteLine(dirInfo.CreationTime);
           Console.WriteLine(dirInfo.Root);

    }
}
