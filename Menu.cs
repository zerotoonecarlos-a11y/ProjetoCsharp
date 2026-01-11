namespace encapsulamento;

public class Menu
{

    public static void Iniciando()
    {
        Console.WriteLine("Seja bem-vindo! Poderia me informar seu nome?");
        string? nomeUsuario = Console.ReadLine();


        if (string.IsNullOrEmpty(nomeUsuario))
        {
            Console.WriteLine("Entrada inválida.");
        }
        else
        {
            Console.WriteLine($"Como vai, {nomeUsuario}? É sempre um prazer encontrar você por aqui.");
        }



        Console.WriteLine();

        Console.WriteLine("Deseja acessar o menu? (s/n)");
        string? escolha = Console.ReadLine();

        if (escolha?.Trim().Equals("s", StringComparison.OrdinalIgnoreCase) == true)
        {
            Menu.IniciarMenu();
        }

    }
    public static void IniciarMenu()
    {

        Console.WriteLine("=========== Menu ===========");
        Console.WriteLine("1 - Executar o programa");
        Console.WriteLine("0 - Fechar o programa");

        string? entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int opcao))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Você escolheu a opção 1.");
                break;

            case 0:
                return;

            default:
                Console.WriteLine("Opção inválida.");
                break;

        }
    }
}
