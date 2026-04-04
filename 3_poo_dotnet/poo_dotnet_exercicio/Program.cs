using poo_dotnet_exercicio;

internal class Program
{
    public static void Main(string[] args)
    {
        int? opcao = null;
        string[] dados = new string[3];
        List<Cliente> clientesLista = new List<Cliente>();

        do
        {
            Console.WriteLine("\n===== SISTEMA E-COMMERCE =====\n");

            Console.Write("Escolha uma opção:\n"
                            + "1 - Cadastrar Cliente"
                            + "\n2 - Cadastrar Produto"
                            + "\n3 - Cadatrar Pedido"
                            + "\n4 - Listar Clientes"
                            + "\n5 - Listar Produtos"
                            + "\n6 - Listar Pedidos"
                            + "\n0 - Sair"
                            + "\n\nOpção: ");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("\nEncerrando...\n");
                    break;

                case 1:
                    Console.WriteLine("\n--- Cadastro de Cliente ---\n");
                    Console.Write("Informe o nome: ");
                    dados[0] = Console.ReadLine();
                    Console.Write("Informe o CPF: ");
                    dados[1] = Console.ReadLine();
                    Console.Write("Informe o E-mail: ");
                    dados[2] = Console.ReadLine();

                    clientesLista.Add(new Cliente(dados[0], dados[1], dados[2]));
                    Cliente.Apresentar(clientesLista.LastOrDefault());
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;

                case 6:

                    break;

                default:
                    Console.WriteLine("\nEscolha uma opção válida!");
                    break;
            }
        } while (opcao != 0);
    }
}