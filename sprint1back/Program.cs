using System;

namespace sprint1back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //exibir caracteres especiais

            Pedido pedidoAtual = new Pedido();

            Console.WriteLine("'EI, TÁ SENTINDO ESTE CHEIRO DELICIOSO? VEM DA COZINHA DO MEU RESTAURANTE! VENHA PROVAR UM PRATO, EU MESMO TE ATENDO. ME DIGA, QUAL SEU NOME?'");
            string nomeCliente = Console.ReadLine()!;
            pedidoAtual.NomeCliente = nomeCliente;

            Console.WriteLine($"\n'A PROPÓSITO, MEU NOME É SEU SIRIGUEIJO, {nomeCliente}!'");

            Console.WriteLine(@"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                     ⠀⢠⣤⡞⣻⡄⠀⠀⣠⣼⢿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣷⣿⠏⠀⠀⢸⣿⣼⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡔⠛⠛⡇⠀⠀⣠⠟⠛⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡏⠀⠀⠀⡿⠀⡴⠁⠀⠀⠈⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡾⠀⠀⠀⢠⡇⢰⠃⠀⠀⠀⢸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⡇⠀⠀⠀⢺⢃⡟⠀⠀⠀⢀⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⣿⢸⠃⠀⠀⠀⣸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡇⠀⡀⢠⡇⣾⠀⣀⠀⢀⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡇⣸⣿⣿⠃⡏⣼⣿⡇⣸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⣧⢻⣿⢻⠀⡇⢻⣿⢇⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⡄⠀⢸⠀⣿⠀⠀⣸⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢳⠀⢸⠀⢹⠀⢀⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢤⡀⠀⠈⢧⠘⣇⣸⡄⢸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⠿⣶⡬⣖⠉⠀⠣⠼⠢⢤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣞⠙⠛⠁⠀⠀⣰⢤⡈⠷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠃⠈⠉⠙⠛⠋⠉⠀⠀⠀⠀⢻⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢠⣤⣤⣄⣀⣠⡤⣄⣴⢾⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡸⣷⠀⣠⠤⡀⠀⣀⣀⣤⡀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣿⢠⡶⠶⣤⡽⠃⣨⠿⠈⣟⠦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⠔⠋⠀⠼⠋⠀⢸⣋⣩⣽⠀⡼⠁⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢀⣀⠀⢻⢻⡇⠀⠙⠶⡴⠃⠀⠀⢻⠔⢻⡇⠀⢀⠾⣟⠛⢛⡿⠋⠁⠀⠀⠀⠀⠀⢀⣀⣀⣻⣷⠃⡼⠁⠀⠀⢀⡀⠀⠀⠀
⠀⣠⠴⠛⠉⣉⠿⠾⠇⠿⠓⢦⡼⠁⠀⠀⠀⠀⠀⠘⣧⠔⠁⠀⠙⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡵⠃⠐⠓⠦⣠⠞⠉⠉⠑⢆⠀
⡾⠁⢀⣶⡾⠁⠀⠀⠀⠀⣾⢯⡀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⠋⠀⠀⠀⠀⠀⢹⡤⡆⠀⠀⠈⣷
⡇⠀⠀⠘⠁⠀⠀⠀⠀⢀⣿⣦⣍⡓⠲⢤⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣠⠤⢾⡇⠀⠀⠀⠀⠀⠀⢸⠇⠉⠀⠀⠀⢸
⢷⡀⠀⠀⠀⠀⠀⠀⠀⡾⣿⣷⣿⣿⣶⣦⣄⣈⣭⠿⣷⣶⣶⣶⣖⠒⠒⠒⠛⠛⣉⣩⣤⣴⠀⠸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼
⠀⠳⡀⠀⠀⠀⠀⠀⢸⡇⠈⠙⠻⢿⣿⣿⣿⣿⢰⣿⣶⣶⣾⣶⡺⣷⣶⣶⣿⣿⣿⣿⣿⣿⡇⠀⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠛
⠀⠀⠈⠲⠤⣤⣤⣤⡤⢧⠀⠀⠀⠀⠈⠉⠛⢻⡘⡿⠿⢿⠿⠿⠂⣿⣿⠿⠿⠿⠛⠛⠛⠉⠁⠀⠀⠈⠢⣄⠀⠀⠀⠀⠀⢀⡠⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⡀⠀⠀⠀⠀⠀⠀⠙⢻⡖⠒⢺⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠋⠉⠉⠛⠛⠋⠉⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠓⢤⣀⠀⠀⠀⠀⠀⢷⠀⠀⢿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⡖⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣬⣀⡀⠐⠦⣤⣌⣧⣀⣈⣿⣆⣀⣠⡤⡤⠴⠖⠀⠀⠁⢀⡷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣏⠀⢉⡟⠓⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠳⠶⢶⠖⠚⣯⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣤⠎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣖⢀⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");

            Console.WriteLine("'O SIRI CASCUDO TE DÁ BOAS-VINDAS!'\n");

            Console.WriteLine("Pressione ENTER para acessar o Menu...");
            Console.ReadLine();

            bool executando = true;

            while (executando)
            {
                Console.Clear(); //pra nao encher muito a tela e deixar menu em cima
                try
                {
                    Console.WriteLine("================ MENU DO SIRI CASCUDO ================");
                    Console.WriteLine("1. Pedir Hambúrguer de Siri (R$ 18.50)");
                    Console.WriteLine("2. Pedir Batatas Fritas do Mar (R$ 10.00)");
                    Console.WriteLine("3. Pedir Refrigerante da Bolha (Preços variam)");
                    Console.WriteLine("4. Visualizar Carrinho");
                    Console.WriteLine("5. Finalizar Compra");
                    Console.WriteLine("6. Sair do Restaurante");
                    Console.WriteLine("======================================================");
                    Console.Write("Escolha uma opção (1 a 6): ");

                    string opcao = Console.ReadLine();

                    Console.WriteLine("------------------------------------------------------"); //pras respostas ficarem abaixo


                    switch (opcao)
                    {
                        case "1":
                            Lanche burguer = new Lanche(101, "Hambúrguer de Siri", 18.50);

                            Console.WriteLine("\n--- INGREDIENTES EXTRAS ---");
                            Console.Write("Deseja adicionar Molho Secreto (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Molho Secreto");

                            Console.Write("Deseja adicionar Pimenta das Profundezas (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Pimenta");

                            Console.Write("Deseja adicionar Cogumelos do Oceano (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(burguer);
                            break;

                        case "2":
                            Lanche batata = new Lanche(102, "Batatas Fritas", 10.00);

                            Console.WriteLine("\n--- INGREDIENTES EXTRAS ---");
                            Console.Write("Deseja adicionar Molho Secreto (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Molho Secreto");

                            Console.Write("Deseja adicionar Pimenta das Profundezas (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Pimenta");

                            Console.Write("Deseja adicionar Cogumelos do Oceano (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(batata);
                            break;

                        case "3":
                            Console.WriteLine("\n--- TAMANHOS DE REFRIGERANTE DA BOLHA ---");
                            Console.WriteLine("a) 300ml (R$ 7,00)");
                            Console.WriteLine("b) 500ml (R$ 9,00)");
                            Console.WriteLine("c) 1L (R$ 11,00)");
                            Console.Write("Escolha o tamanho (a/b/c): ");

                            string optTamanho = Console.ReadLine().ToLower();
                            string tamanhoEscolhido = "300ml";

                            if (optTamanho == "b") tamanhoEscolhido = "500ml";
                            else if (optTamanho == "c") tamanhoEscolhido = "1L";

                            Bebida refri = new Bebida(201, "Refrigerante da Bolha", 7.00, tamanhoEscolhido);
                            pedidoAtual.AdicionarItem(refri);
                            break;

                        case "4":
                            pedidoAtual.ExibirResumo();
                            break;

                        case "5":
                            bool comprou = pedidoAtual.FinalizarPedido();
                            if (comprou)
                            {
                                executando = false; //encerra o programa
                            }
                            break;

                        case "6":
                            executando = false;
                            Console.WriteLine($"\nVOLTE SEMPRE AO SIRI CASCUDO, {nomeCliente}!");
                            break;

                        default:
                            Console.WriteLine("\nOpção inválida! Digite um número de 1 a 6.");
                            break;
                    }
                                                  }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ERRO SISPEDIDO] Ocorreu uma falha na entrada de dados: {ex.Message}");
                    Console.WriteLine("Por favor, tente novamente.\n");
                }

                if (executando) //um pause pra conseguir ler antes de recarregar
                {
                    Console.WriteLine("\nPressione ENTER para voltar ao Menu...");
                    Console.ReadLine();
                }
            }
        }
    }
}