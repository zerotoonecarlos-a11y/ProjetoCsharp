using System.Security.Cryptography.X509Certificates;

namespace encapsulamento;


public class NegativeException : Exception
{
    public NegativeException() { }

    public NegativeException(string message) : base(message) { }

    public NegativeException(string message, Exception inner) : base(message, inner) { }

}

public class ImparException(string message) : Exception(message)
{
}

public class ExecoesPersonalizadas
{
    public static int PositivoPar()
    {
        var random = new Random();

        int valor = random.Next(-30, 30);

        if (valor < 0)
        {
            throw new NegativeException("Número negativo... :(");
        }

        if (valor % 2 == 1)
        {
            throw new ImparException("Número impar... :(");
        }

        return valor;
    }
    public static void Executar()
    {
        try
        {
            Console.WriteLine(PositivoPar());
        }
        catch(NegativeException ex)
        {
            Console.WriteLine(ex.Message);
        }catch(ImparException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}