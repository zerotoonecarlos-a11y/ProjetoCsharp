namespace FundamentosCSharp;

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

public class Subtrair : IOperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a - b;
    }
}

public class Dividir : IOperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a / b;
    }
}

public class Multiplicacao : IOperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a * b;
    }
}

public class MenuCalculadora
{
    public static void Iniciar()
    {
        while (true)
        {
            Console.WriteLine("======= Menu - Calculadora =======");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Entrada inválida!\n");
                continue;
            }

            if (opcao == 0) break;

            var operacao = GetOperacao(opcao);
            if (operacao == null)
            {
                Console.WriteLine("Opção não reconhecida.\n");
                continue;
            }

            int a = LerInteiro("Digite um valor: ");
            int b = LerInteiro("Digite outro valor: ");

            if (operacao is Dividir && b == 0)
            {
                Console.WriteLine("Erro: divisão por zero.\n");
                continue;
            }

            int resultado = operacao.Operacao(a, b);
            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }

    static int LerInteiro(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int v)) return v;
            Console.WriteLine("Entrada inválida. Tente novamente.");
        }
    }

    static IOperacaoBinaria? GetOperacao(int opcao) => opcao switch
    {
        1 => new Soma(),
        2 => new Subtrair(),
        3 => new Dividir(),
        4 => new Multiplicacao(),
        _ => null
    };
}
public class Interface
{
    public static void Executar()
    {
        MenuCalculadora.Iniciar();
    }
}
