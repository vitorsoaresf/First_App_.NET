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
    Console.WriteLine("Digite 4 para exibir a m[edia de uma banda");
    Console.WriteLine("Digite -1 para sair");
}

ExibirBoasVindas();
ExibirOpcoesDoMenu();