
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

ExibirOpcoesDoMenu();

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n [1]  Registrar banda");
    Console.WriteLine(" [2]  Mostrar todas as bandas");
    Console.WriteLine(" [3]  Avaliar banda");
    Console.WriteLine(" [4]  Exibir a média de uma banda");
    Console.WriteLine(" [0]  Sair");

    Console.Write("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBanda();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("***REGISTRO DE BANDAS***");
    Console.WriteLine("************************");

    Console.Write("\nDigite o nome:  ");
    string nomedaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomedaBanda);

    Console.WriteLine($"\n {nomedaBanda} Registrado com Sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void MostrarBanda() 
{
    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("***BANDAS REGISTRADAS***");
    Console.WriteLine("************************\n");
    for (int i = 0;  i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("\nAperte Qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}


