﻿void ExibirBoasVindas()
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
            Console.WriteLine("Você digitou a opção "+ opcaoEscolhidaNumerica);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhidaNumerica);
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

ExibirBoasVindas();
ExibirOpcoesDoMenu();