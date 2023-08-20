
//List<string> listaDasBandas = new List<string> { "AC/DC", "The Beatles", "SOAD" };

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();

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
    Console.WriteLine(" [4]  Média das bandas");
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
            AvaliarBanda();
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
    ExibirTitulosOpcoes("REGISTRO DE BANDA");
    Console.Write("\n");

    Console.Write("\nDigite o nome:  ");
    string nomedaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomedaBanda,new List<int>());
   // listaDasBandas.Add(nomedaBanda);

    Console.WriteLine($"\n {nomedaBanda} Registrado com Sucesso");
    Thread.Sleep(900);
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void MostrarBanda() 
{
    Console.Clear();
    ExibirTitulosOpcoes("BANDAS REGISTRADAS");
    Console.Write("\n");
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda {banda}");
    }

    Console.WriteLine("\nAperte Qualquer tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulosOpcoes("AVALIAR BANDAS");
    Console.Write("\n");
}


void ExibirTitulosOpcoes(string titulo)
{
    int qtLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}
