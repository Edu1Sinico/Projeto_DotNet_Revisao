using poo_dotnet_exercicio;

internal class Program
{
    public static void Main(string[] args)
    {
        // Lista de objetos
        List<Cliente> clientes = new List<Cliente>();
        List<Produto> produtos = new List<Produto>();
        List<Pedido> pedidos = new List<Pedido>();
        List<Produto> produtosDoPedido = new List<Produto>();

        // Outras variáveis de validação
        int? opcao = null;
        string[] dadosCadastro = new string[3]; // Preencher o cadastro de clientes e produtos
        bool clienteEncontrado = false, produtoEncontrado = false;
        string dadosSimples = ""; // Para preenchimento de dados simples (nome, CPF, email, preco e etc)
        string preencherItens; // Utilizado somente para o loop do preenchimento dos itens no pedido
        Cliente clienteSelecionado = null; // Encontrar o cliente para o pedido
        List<int> quantidades = new List<int>();


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
                // Sair do sistema
                case 0:
                    Console.WriteLine("\nEncerrando...\n");
                    break;

                // Cadastro de clientes
                case 1:
                    Console.WriteLine("\n--- Cadastro de Cliente ---\n");
                    Console.Write("Informe o Nome: ");
                    dadosCadastro[0] = Console.ReadLine();
                    Console.Write("Informe o CPF: ");
                    dadosCadastro[1] = Console.ReadLine();
                    Console.Write("Informe o E-mail: ");
                    dadosCadastro[2] = Console.ReadLine();
                    Console.WriteLine();

                    clientes.Add(new Cliente(dadosCadastro[0], dadosCadastro[1], dadosCadastro[2]));
                    Cliente.Apresentar(clientes.LastOrDefault());
                    break;

                // Cadastro de produtos
                case 2:
                    Console.WriteLine("\n--- Cadastro de Produto ---\n");
                    Console.Write("Informe o nome do produto: ");
                    dadosCadastro[0] = Console.ReadLine();
                    Console.Write("Informe o Preço: ");
                    dadosCadastro[1] = Console.ReadLine();
                    Console.Write("Informe a Quantidade em Estoque: ");
                    dadosCadastro[2] = Console.ReadLine();
                    Console.WriteLine();

                    produtos.Add(new Produto(dadosCadastro[0], Double.Parse(dadosCadastro[1]), Int32.Parse(dadosCadastro[2])));
                    Produto.Apresentar(produtos.LastOrDefault());
                    break;

                // Cadastro de pedidos
                case 3:
                    Console.WriteLine("\n--- Cadastro de Pedido ---\n");

                    do
                    {
                        Console.Write("Informe o nome do cliente: ");
                        dadosSimples = Console.ReadLine();

                        // Validar se o cliente existe nos cadastros
                        if (clientes.Count() != 0)
                        {
                            foreach (var c in clientes)
                            {
                                if (c.Nome.ToLower().Equals(dadosSimples.ToLower()))
                                {
                                    clienteEncontrado = true;
                                    clienteSelecionado = c;
                                    Console.WriteLine("\nCliente inserido com sucesso!\n");
                                    break;
                                }
                            }

                            if (!clienteEncontrado)
                            {
                                Console.WriteLine("\nCliente não encontrado! Digite novamente.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNão há clientes cadastrados.\n");
                            clienteEncontrado = true;
                        }
                    } while (!clienteEncontrado);

                    // Validar se existe produtos cadastrados
                    do
                    {
                        do
                        {
                            Console.Write("Informe os nome dos produtos: ");
                            dadosSimples = Console.ReadLine();

                            if (produtos.Count() != 0)
                            {
                                foreach (var p in produtos)
                                {
                                    if (p.Nome.ToLower().Equals(dadosSimples.ToLower()))
                                    {
                                        Console.WriteLine($"\nQuantidade em estoque do produto '{p.Nome}': {p.Estoque}.\n");
                                        Console.Write("Informe a quantidade que deseja retirar: ");
                                        dadosSimples = Console.ReadLine();
                                        int qtde = Int32.Parse(dadosSimples);

                                        if (!(qtde > p.Estoque))
                                        {
                                            p.DiminuirEstoque(qtde);
                                            produtosDoPedido.Add(p);
                                            quantidades.Add(qtde);
                                            produtoEncontrado = true;
                                            Console.WriteLine("\nProduto inserido com sucesso!\n");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEstoque insuficiente para quantidade desejada!\n");
                                        }

                                    }
                                }

                                if (!produtoEncontrado)
                                {
                                    Console.WriteLine("\nProduto não encontrado! Digite novamente.\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nNão há produtos cadastrados.\n");
                                produtoEncontrado = true;
                            }

                            // Continuar o loop de preenchimento dos itens
                            Console.Write("Deseja inserir outro produto? (s/n) ");
                            preencherItens = Console.ReadLine().ToLower();
                            Console.WriteLine();

                        } while (preencherItens == "s");

                    } while (!produtoEncontrado);

                    pedidos.Add(new Pedido(clienteSelecionado, new List<Produto>(produtosDoPedido), new List<int>(quantidades)));

                    Pedido.Apresentar(pedidos.LastOrDefault());

                    produtosDoPedido.Clear();
                    quantidades.Clear();
                    clienteEncontrado = false;
                    produtoEncontrado = false;
                    break;

                // Listar clientes
                case 4:
                    Console.WriteLine("\n--- Listar Clientes ---\n");
                    foreach (var c in clientes)
                    {
                        Cliente.Apresentar(c);
                    }
                    break;

                // Listar produtos
                case 5:
                    Console.WriteLine("\n--- Listar Produtos ---\n");
                    foreach (var p in produtos)
                    {
                        Produto.Apresentar(p);
                    }
                    break;

                // Listar pedidos
                case 6:
                    Console.WriteLine("\n--- Listar Pedidos ---");
                    foreach (var p in pedidos)
                    {
                        Pedido.Apresentar(p);
                    }
                    break;

                default:
                    Console.WriteLine("\nEscolha uma opção válida!");
                    break;
            }

        } while (opcao != 0);
    }
}
