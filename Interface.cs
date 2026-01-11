namespace encapsulamento;

interface IOperacaoBinaria
{
    int Operacao(int a, int b);
}

public class Soma : IOperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a + b;
    }
}
public class Interface
{
    public static void Executar()
    {
        Console.Write("Digite um valor: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Valor Invalido!");
            return;
        }


        Console.Write("Digite outro valor: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Valor Invalido!");
            return;
        }

        var exemploSoma = new Soma(); 

        int resultado = exemploSoma.Operacao(a, b); 

        Console.WriteLine($"O resultado da soma de {a} + {b} é {resultado}");

    }
}
