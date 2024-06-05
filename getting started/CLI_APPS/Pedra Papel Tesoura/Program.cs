//CLI rock paper scissors game

static void Main
{
    Console.WriteLine("Jogo de Pedra, Papel, Tesoura");
    Console.WriteLine("Digite 1 para Pedra, 2 para Papel, ou 3 para Tesoura");
    int playerChoice = int.Parse(Console.ReadLine());

    string[] choices = { "Pedra", "Papel", "Tesoura" };

    int computerChoice = new Random().Next(1, 3);

    Console.WriteLine($"Voce escolheu {choices[playerChoice - 1]}");
    Console.WriteLine($"O computador escolheu {choices[computerChoice - 1]}");

    if (playerChoice == computerChoice)
    {
        Console.WriteLine("Empate");
    }
    else if (playerChoice == 1 && computerChoice == 3 || playerChoice == 2 && computerChoice == 1 || playerChoice == 3 && computerChoice == 2)
    {
        Console.WriteLine("Jogador vence");
    }
    else
    {
        Console.WriteLine("Computador vence");
    }
    
}