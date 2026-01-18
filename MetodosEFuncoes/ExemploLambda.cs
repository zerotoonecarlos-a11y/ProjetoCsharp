namespace FundamentosCSharp;

public class ExemploLambda
{
    public static void Executar()
    {
        Action algoNoConsole = () =>
        {
            Console.WriteLine("Função lambda em c#!");
        };

        algoNoConsole();

        Func<int> jogarDados = () =>
        {
            Random random = new();
            return random.Next(1, 7);
        };

        Console.WriteLine(jogarDados());

        Func<int, string> conversorHex = numero => numero.ToString("X");

        Console.WriteLine(conversorHex(1234));

        Func<int, int, int, string> formartarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);


        Console.WriteLine(formartarData(1, 1, 2019));
    }

}
