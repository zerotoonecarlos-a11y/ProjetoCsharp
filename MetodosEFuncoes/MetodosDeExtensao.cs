using System;
using System.Globalization;

namespace encapsulamento.MetodosEFuncoes;

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
    }
}
