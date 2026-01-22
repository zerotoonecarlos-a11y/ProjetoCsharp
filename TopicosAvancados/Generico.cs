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

    public static void Executar()
    {

    }
}
