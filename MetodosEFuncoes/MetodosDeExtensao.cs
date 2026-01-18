using System;
using System.Globalization;

namespace FundamentosCSharp;

public static class ExtensaoInteiro
{
    public static int Soma(this int num, int outroNumero)
    {
        return num + outroNumero;
    }

    public static int Subtracao(this int num, int outroNumero)
    {
        return num - outroNumero;
    }
}

public static class MetodosDeExtensao
{

    public static void Executar()
    {
        int numero = 5;

        Console.WriteLine(numero.Soma(3));
        Console.WriteLine(numero.Subtracao(5));

        Console.WriteLine(2.Soma(10));
        Console.WriteLine(4.Subtracao(6));
    }
}
