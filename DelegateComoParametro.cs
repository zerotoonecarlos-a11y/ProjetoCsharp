namespace encapsulamento;

public class DelegateComoParametro
{
    public delegate int Operacao(int x, int y);

    public static int Soma(int x, int y)
    {
        return x + y;
    }
    public static void Executar()
    {
        
    }
}
