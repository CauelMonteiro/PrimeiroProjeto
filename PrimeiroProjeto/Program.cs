using System;

Console.WriteLine("Bem-vindo ao Banco XYZ!");
Console.Write("Por favor, digite seu nome: ");
string nome = Console.ReadLine();

Pessoa pessoa = new Pessoa(nome);

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine($"Como posso ajudar {pessoa.Nome}?");
    Console.WriteLine("1 - Depósito");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Você selecionou a opção de Depósito.");
            Console.WriteLine("1 - " + "Depósito");
            Console.ReadLine();
            break;
        case "2":
            Console.WriteLine("Você selecionou a opção de Saque.");
            Console.WriteLine("2 - " + "Saque"); 
            Console.ReadLine();
            break;
        case "3":
            Console.WriteLine($"Saindo do sistema. Obrigado, {pessoa.Nome}!");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
            Console.ReadLine();
            break;
    }
}

class Pessoa
{
    public string Nome { get; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}
