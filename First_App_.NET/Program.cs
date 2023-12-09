List<string> bandas = new List<string> { "U2", "Calipso", "Evanescence"};
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
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
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
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja regitrar\n");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    bandas.ForEach(banda => Console.WriteLine("Banda: " + banda + "\n"));
    Console.WriteLine("Digite alguma tecla para voltar para o menu principal\n");
    Console.ReadKey();
    Console.Clear();

}

void AvaliarBanda()
{
    Console.WriteLine("Quais das bandas abaixo você deseja avaliar?\n");
    ExibirBandasRegistradas();

    string bandaEscolhida = Console.ReadLine()!;

}

ExibirOpcoesDoMenu();