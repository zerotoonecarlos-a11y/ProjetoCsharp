namespace FundamentosCSharp;

public class Dynamics
{
    public static void Executar()
    {
        dynamic  meuObjeto = "teste";
        meuObjeto = 3;

        meuObjeto++;

        Console.WriteLine();

        dynamic aluno = new System.Dynamic.ExpandoObject();
        aluno.Nome = "kaio";
        aluno.Idade = 24;
        aluno.Nota = 6.5;

        Console.WriteLine($"{aluno.Idade} {aluno.Nome} {aluno.Nota}");

    }
}
