using System.ComponentModel;
using fundamentos_dotnet_exercicio;

class Program
{
    static void Main(string[] args)
    {
        List<Contato> contatos = new List<Contato>();
        int opcao;

        do
        {
            Console.WriteLine("\n===== CONTATOS =====\n");
            Console.WriteLine("1 - Adicionar contato");
            Console.WriteLine("2 - Listar contatos");
            Console.WriteLine("3 - Buscar por nome");
            Console.WriteLine("4 - Excluir contato");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nEncerrando...\n");
                    break;

                case 1:
                    AdicionarContato(contatos);
                    break;

                case 2:
                    ListarContatos(contatos);
                    break;

                case 3:
                    BuscarContato(contatos);
                    break;

                case 4:
                    ApagarContato(contatos);
                    break;

                default:
                    Console.WriteLine("\nEscolhar uma opção válida!");
                    break;
            }

        } while (opcao != 0);
    }

    static void AdicionarContato(List<Contato> contatos)
    {
        Console.WriteLine("\n --- Cadastro de Contato ---");

        Console.Write("\nNome: ");
        string nome = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        contatos.Add(new Contato(nome, telefone, email));

        Console.WriteLine("\nContato adicionado com sucesso!");
    }

    static void ListarContatos(List<Contato> contatos)
    {
        Console.WriteLine("\n--- Lista de Contatos ---\n");

        foreach (var c in contatos)
        {
            Console.WriteLine($"Nome: {c.Nome} | Tel: {c.Telefone} | Email: {c.Email}");
        }
    }

    static void BuscarContato(List<Contato> contatos)
    {
        Console.WriteLine("\n --- Busca de Contato ---");

        Console.Write("\nDigite o nome: ");
        string nomeBusca = Console.ReadLine();

        var encontrado = contatos
            .FirstOrDefault(c => c.Nome.ToLower() == nomeBusca.ToLower());

        if (encontrado != null)
        {
            Console.WriteLine("\nContato encontrado: \n");
            Console.WriteLine($"Nome: {encontrado.Nome}");
            Console.WriteLine($"Telefone: {encontrado.Telefone}");
            Console.WriteLine($"Email: {encontrado.Email}");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    static void ApagarContato(List<Contato> contatos)
    {
        Console.WriteLine("\n --- Apagar um Contato ---");

        Console.Write("\nDigite o nome: ");
        string nomeBusca = Console.ReadLine();

        var encontrado = contatos
            .FirstOrDefault(c => c.Nome.ToLower() == nomeBusca.ToLower());

        if (encontrado != null)
        {
            contatos.Remove(encontrado);
            Console.WriteLine("\nContato removido com sucesso.");
        }
        else
        {
            Console.WriteLine("\nContato não encontrado.");
        }
    }


}