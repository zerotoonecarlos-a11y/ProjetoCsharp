namespace FundamentosCSharp;

public class UsandoDelegate
{
    delegate double Soma(double a, double b);
    delegate void ImprimirSoma(double a, double b);

    static double MinhaSoma(double a, double b)
    {
        return a + b;
    }

    static void MeuImprimirSoma(double a, double b)
    {
        Console.WriteLine(a + b);
    }
    public static void Executar()

    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Iniciando exemplo delegates   \r");
            Thread.Sleep(200);
            Console.Write("Iniciando exemplo delegates.  \r");
            Thread.Sleep(200);
            Console.Write("Iniciando exemplo delegates.. \r");
            Thread.Sleep(200);
            Console.Write("Iniciando exemplo delegates...\r");
            Thread.Sleep(200);
            Console.Clear();
        }

        Soma op1 = MinhaSoma;

        Console.WriteLine("Resultado da soma:" + op1(2, 6));

        ImprimirSoma op2 = MeuImprimirSoma;

        op2(2.3, 6);

        Func<double, double, double> op3 = MinhaSoma;
        Console.WriteLine(op3(3.6, 8.9));

        Action<double, double> op4 = MeuImprimirSoma;

        op4(5, 8.10);
    }
}
