namespace encapsulamento;

public class LendoArquivo
{
    public static void Executar()
    {
        var path = @"~lendo_arquivo.txt".ParseHome();

        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine("Produto;Preço;Qtde");
            sw.WriteLine("Caneta bic preta; 3,50; 89");
            sw.WriteLine("Borracha branca; 2,89; 27");
        }

        try
        {
            using StreamReader sr = new StreamReader(path);

            var texto = sr.ReadToEnd();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Alguma coisa deu errado: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finalizando sistema...");
        }
    }
}
