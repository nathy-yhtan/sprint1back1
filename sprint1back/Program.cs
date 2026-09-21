using System;

namespace sprint1back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Permite exibir caracteres especiais e acentos no console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Instância do carrinho de compras (Pedido)
            Pedido pedidoAtual = new Pedido();

            // Boas-vindas personalizadas do Seu Sirigueijo
            Console.WriteLine("EI, VOCÊ AÍ! TÁ SENTINDO ESTE CHEIRO DELICIOSO? VEM DA COZINHA DO MEU RESTAURANTE! VENHA PROVAR UM PRATO, EU MESMO TE ATENDO. ME DIGA, QUAL SEU NOME?");
            string nomeCliente = Console.ReadLine();
            pedidoAtual.NomeCliente = nomeCliente;

            Console.WriteLine($"\nA PROPÓSITO, MEU NOME É SEU SIRIGUEIJO, {nomeCliente.ToUpper()}!");

            // Desenho ASCII do Seu Sirigueijo (Preservado da sua captura)
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

            Console.WriteLine("O SIRI CASCUDO TE DÁ BOAS-VINDAS!\n");

            bool executando = true;

            // Laço principal do Menu Interativo
            while (executando)
            {
                try
                {
                    Console.WriteLine("================ MENU PRINCIPAL DO SIRI CASCUDO ================");
                    Console.WriteLine("1. Pedir Hambúrguer de Siri (Lanche)");
                    Console.WriteLine("2. Pedir Batatas Fritas do Mar (Lanche)");
                    Console.WriteLine("3. Pedir Refrigerante da Bolha (Bebida)");
                    Console.WriteLine("4. Ver Carrinho e Finalizar Pedido");
                    Console.WriteLine("5. Sair do Restaurante");
                    Console.Write("Escolha uma opção (1 a 5): ");

                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            // Criando o famoso Hambúrguer de Siri
                            Lanche burguer = new Lanche(101, "Hambúrguer de Siri", 18.50);

                            Console.WriteLine("\n--- INGREDIENTES EXTRAS ---");
                            Console.Write("Deseja adicionar Molho Secreto (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Molho Secreto");

                            Console.Write("Deseja adicionar Pimenta das Profundezas (+R$ 1,50)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Pimenta");

                            Console.Write("Deseja adicionar Cogumelos do Oceano (+R$ 3,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") burguer.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(burguer);
                            break;

                        case "2":
                            Lanche batata = new Lanche(102, "Batatas Fritas do Mar", 10.00);

                            Console.Write("Deseja adicionar Molho Secreto extra (+R$ 2,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Molho Secreto");

                            Console.Write("Deseja adicionar Pimenta das Profundezas (+R$ 1,50)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Pimenta");

                            Console.Write("Deseja adicionar Cogumelos do Oceano (+R$ 3,00)? (s/n): ");
                            if (Console.ReadLine().ToLower() == "s") batata.IngredientesExtras.Add("Cogumelos");

                            pedidoAtual.AdicionarItem(batata);
                            break;

                        case "3":
                            Console.WriteLine("\n--- TAMANHOS DE REFRIGERANTE DA BOLHA ---");
                            Console.WriteLine("a) 300ml (Preço Base: R$ 7,00)");
                            Console.WriteLine("b) 500ml (+ R$ 2,00)");
                            Console.WriteLine("c) 1L (+ R$ 4,00)");
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
                            executando = false;
                            Console.WriteLine($"\nVOLTE SEMPRE AO SIRI CASCUDO, {nomeCliente.ToUpper()}! SEU DINHEIRO É SEMPRE BEM-VINDO AQUI!");
                            break;

                        default:
                            Console.WriteLine("\nOpção inválida! Digite um número de 1 a 5.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Tratamento de Exceções obrigatório para o Desafio
                    Console.WriteLine($"\n[ERRO SISPEDIDO] Ocorreu uma falha na entrada de dados: {ex.Message}");
                    Console.WriteLine("Por favor, tente novamente.\n");
                }

                Console.WriteLine(); // Linha em branco para organização do terminal
            }
        }
    }
}


//Bob Esponja trabalha no Siri Cascudo (Krusty Krab), e o cardápio principal (chamado de Galley Grub): Hambúrguer de Siri, batatas fritas, refrigerantes, pedaços de coral e anéis de alga marinha