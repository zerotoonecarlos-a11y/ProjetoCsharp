namespace FundamentosCSharp;

public class LambdasDelegate
{
    delegate double Operacao(double x, double y);
    public static void Executar()
    {
        Operacao sum = (x, y) => x + y;
        Operacao sub = (x,y) => x - y;
        Operacao div = (x, y) => x / y;
        Operacao mult = (x, y) => x * y;

        Console.WriteLine($"Exemplo LambdasDelegate sum: {sum(1, 2)}");
        Console.WriteLine($"Exemplo LambdasDelegate sub: {sub(1, 2)}");
        Console.WriteLine($"Exemplo LambdasDelegate div: {div(1, 2)}");
        Console.WriteLine($"Exemplo LambdasDelegate mult: {mult(1, 2)}");
    }
}
