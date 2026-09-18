namespace sprint1back;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;         //entender caracteres especiais

        Console.WriteLine("'OI, VOCÊ AI! SIM, VOCÊ MESMO! TÁ SENTINDO ESTE CHEIRO DELICIOSO? VEM DA COZINHA DO MEU RESTAURANTE! NÃO TENHA TIMIDEZ, VENHA PROVAR UM PRATO, EU MESMO TE ATENDO. ME DIGA, QUAL SEU NOME?'");
        string nomeCliente = Console.ReadLine()!; //"!" não vazio

        Console.WriteLine("'A PROPÓSITO, MEU NOME É SEU SIRIGUEIJO.'");
        //não deixar espaços em branco
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

        Console.WriteLine("'O SIRI CASCUDO TE DÁ BOAS-VINDAS'");

        Console.WriteLine("'DIGA O NÚMERO REFERENTE AO QUE VOCÊ DESEJA COMER.'");
        Console.WriteLine("1. Hambúrguer de Siri");
        Console.WriteLine("2. Batatas Fritas");
        Console.WriteLine("3. Refrigerante Bolha");
        Console.WriteLine("4. Pedaços de Coral");
        Console.WriteLine("5. Anéis de Alga Marinha");
        string pedido = Console.ReadLine()!;
    }
}

//Bob Esponja trabalha no Siri Cascudo (Krusty Krab), e o cardápio principal (chamado de Galley Grub): Hambúrguer de Siri, batatas fritas, refrigerantes, pedaços de coral e anéis de alga marinha