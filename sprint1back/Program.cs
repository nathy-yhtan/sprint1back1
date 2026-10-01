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
                            Lanche hamburguer = new Lanche(101, "Hambúrguer de Siri", 18.50);

                            Console.WriteLine("\n--- INGREDIENTES EXTRAS ---");

                            if (LerConfirmacao("Deseja adicionar Molho Secreto (+R$ 2,00)? (s/n): "))
                                hamburguer.IngredientesExtras.Add("Molho");

                            if (LerConfirmacao("Deseja adicionar Pimenta das Profundezas (+R$ 2,00)? (s/n): "))
                                hamburguer.IngredientesExtras.Add("Pimenta");

                            if (LerConfirmacao("Deseja adicionar Cogumelos do Oceano (+R$ 2,00)? (s/n): "))
                                hamburguer.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(hamburguer);
                            break;

                        case "2":
                            Lanche batata = new Lanche(102, "Batatas Fritas", 10.00);

                            Console.WriteLine("\n--- INGREDIENTES EXTRAS ---");

                            if (LerConfirmacao("Deseja adicionar Molho Secreto (+R$ 2,00)? (s/n): "))
                                batata.IngredientesExtras.Add("Molho");

                            if (LerConfirmacao("Deseja adicionar Pimenta das Profundezas (+R$ 2,00)? (s/n): "))
                                batata.IngredientesExtras.Add("Pimenta");

                            if (LerConfirmacao("Deseja adicionar Cogumelos do Oceano (+R$ 2,00)? (s/n): "))
                                batata.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(batata);
                            break;

                        case "3":
                            Console.WriteLine("\n--- TAMANHOS DE REFRIGERANTE DA BOLHA ---");
                            Console.WriteLine("a) 300ml (R$ 7,00)");
                            Console.WriteLine("b) 500ml (R$ 9,00)");
                            Console.WriteLine("c) 1L (R$ 11,00)");

                            string opcTamanho = LerOpcaoValida("Escolha o tamanho (a/b/c): ", new string[] { "a", "b", "c" });
                            string tamanhoEscolhido = "300ml";

                            if (opcTamanho == "b") tamanhoEscolhido = "500ml";
                            else if (opcTamanho == "c") tamanhoEscolhido = "1L";

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

            Console.WriteLine("\nPressione ENTER para sair..."); //pra n sair do console antes da mensagenzinha
            Console.ReadLine();

        }


        //método para validar respostas s/n
        static bool LerConfirmacao(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine()?.Trim().ToLower() ?? ""; //? e "" Evita erros caso a leitura retorne um valor null

                if (entrada == "s") return true;
                if (entrada == "n") return false;

                Console.WriteLine("Opção inválida! Por favor, digite apenas 's' para sim ou 'n' para não. \n");
            }
        }


        //método para validar respostas a/b/c
        static string LerOpcaoValida(string mensagem, string[] opcoesValidas) //[] indica array
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (Array.Exists(opcoesValidas, op => op == entrada))
                {
                    return entrada;
                }

                Console.WriteLine($"Opção inválida! Escolha uma das opções: {string.Join(", ", opcoesValidas)} \n");
            }
        }


    }
}