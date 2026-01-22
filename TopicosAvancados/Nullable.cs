namespace FundamentosCSharp;

public class Nullable
{
    public static void Executar()
    {
        Nullable<int> num1 = null;
        int? num2 = null;

        if (num1.HasValue)
        {
            Console.WriteLine("O valor da variacel num1 é: {0}", num1);
        }
        else
        {
            Console.WriteLine("A variavel não possui valor");
        }

        int valor = num1 ?? 1000;
        Console.WriteLine(valor);

        bool? booleana = null;
        bool boolResultado = booleana.GetValueOrDefault();
        Console.WriteLine(boolResultado);

        try
        {
            int x = num1.Value;
            int y = num2.Value;
            Console.WriteLine(x + y);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Programa Finalizando...");
        }
    }
}
