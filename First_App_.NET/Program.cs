//List<string> bandas = new List<string> { "U2", "Calipso", "Evanescence"};

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("U2", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Linkin Park", new List<int>()); 

void ExibirLogoBoasVindas()
{ 
    Console.WriteLine(@"
███████╗██╗██████╗░░██████╗████████╗  ░█████╗░██████╗░██████╗░  ░█████╗░░░░██╗░██╗░
██╔════╝██║██╔══██╗██╔════╝╚══██╔══╝  ██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██████████╗
█████╗░░██║██████╔╝╚█████╗░░░░██║░░░  ███████║██████╔╝██████╔╝  ██║░░╚═╝╚═██╔═██╔═╝
██╔══╝░░██║██╔══██╗░╚═══██╗░░░██║░░░  ██╔══██║██╔═══╝░██╔═══╝░  ██║░░██╗██████████╗
██║░░░░░██║██║░░██║██████╔╝░░░██║░░░  ██║░░██║██║░░░░░██║░░░░░  ╚█████╔╝╚██╔═██╔══╝
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░  ╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░  ░╚════╝░░╚═╝░╚═╝░░░
");    
}

void ExibirOpcoesDoMenu()
{
    ExibirLogoBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("tchau tchau =)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja regitrar\n");

    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!\n");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
    
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine("Banda: " + banda + "\n");
    }

    Console.WriteLine("Digite alguma tecla para voltar para o menu principal\n");
    Console.ReadKey();
    Console.Clear();

}

void ExibirTituloDaOpcao(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");

    //qual banda 
    Console.Write("Informe a banda \n");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?");
        
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota: {nota} foi registrada com sucesso para a banda {nomeDaBanda}\n!");
        
        Thread.Sleep(2);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
    }


    //verificar se a banda existe no dict
    //depois pedir a nota

    Console.WriteLine("Digite uma tecla para volta para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}


ExibirOpcoesDoMenu();