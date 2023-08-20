Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("LinkinPark", new List<int> { 10, 08, 06, 09 });
bandasRegistradas.Add("AC/DC", new List<int>());

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
            MediaBandas();
            break;
        case 0:
            Console.WriteLine("----ATÉ A PROXIMA----");
            Thread.Sleep(2000);
            Console.Clear();
            break;
        default:
            Console.WriteLine("Opção inválida");
            
            break;
    }
}

void MediaBandas()
{
    Console.Clear();
    ExibirTitulosOpcoes("MEDIA DAS BANDAS");
    Console.Write("\n Qual banda deseja ver a média? ");
    string nomedaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomedaBanda))
    {
       List<int> notasBandas = bandasRegistradas[nomedaBanda];
        Console.WriteLine($"A Media da banda {nomedaBanda} é " + notasBandas.Average());
        Thread.Sleep(1900);
        Console.WriteLine("\nAperte para voltar ao menu anterior");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A Banda {nomedaBanda} não foi encontrada!");
        Console.WriteLine("\nAperte para voltar ao menu anterior");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
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
    foreach (string banda in bandasRegistradas.Keys)
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
    Console.Write("\nQual banda deseja avaliar? ");
    string nomedaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomedaBanda))
    {
        Console.WriteLine($"Qual a nota da banda {nomedaBanda}?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomedaBanda].Add(nota);
        Console.WriteLine($"A Nota {nota} foi registrada com sucesso\n para {nomedaBanda}");
        Thread.Sleep(900);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }else
    {
        Console.WriteLine($"A Banda {nomedaBanda} não foi encontrada!");
        Console.WriteLine("Aperte para voltar ao menu anterior");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
void ExibirTitulosOpcoes(string titulo)
{
    int qtLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}