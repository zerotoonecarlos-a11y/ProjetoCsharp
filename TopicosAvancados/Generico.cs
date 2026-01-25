namespace FundamentosCSharp;

public class Generico
{
    public class Caixa<T>
    {
        T valorPrivado;

        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }

        public T MetodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }
    }

    public class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) { }
    }

    public static void Executar()
    {
        var caixaExem = new Caixa<int>(1000);
        Console.WriteLine(caixaExem.MetodoGenerico(33));
        Console.WriteLine(caixaExem.Coisa.GetType());

        var caixaExem2 = new Caixa<string>("Construtor");
        Console.WriteLine(caixaExem2.MetodoGenerico("Teste"));
        Console.WriteLine(caixaExem2.Coisa.GetType());
    }
}
