Console.WriteLine(@"
-------------------------------------------------
|             CARDÁPIO DE BEBIDAS               |
-------------------------------------------------
|     Pressione o numero da bebida desejada     |
-------------------------------------------------
|                                               |
|  1 - Água                                     |
|  2 - Refrigerante                             |
|  3 - Drink alcólico                           |
|  4 - Suco natural                             |
|                                               |
|  5 - Não desejo bebida                        |
|                                               |
-------------------------------------------------
");

ConsoleKeyInfo inputOpcao = Console.ReadKey();

switch (inputOpcao.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine($"Você selecionou a opção Água.");
        break;
    case ConsoleKey.D2:
        Console.WriteLine($"Você selecionou a opção Refrigerante.");
        break;
    case ConsoleKey.D3:
        Console.WriteLine($"Você selecionou a opção Drink alcólico");
        break;
    case ConsoleKey.D4:
        Console.WriteLine($"Você selecionou a opção Suco natural");
        break;
    case ConsoleKey.D5:
        Console.WriteLine($"Tudo bem, tenha um bom dia.");
        Environment.Exit(0);
        break;
}

Console.WriteLine(@"
-------------------------------------------------
|             CARDÁPIO DE BEBIDAS               |
-------------------------------------------------
|            Deseja adicionar gelo?             |
-------------------------------------------------
|                                               |
|  S - Sim                                      |
|  N - Não                                      |
|                                               |
-------------------------------------------------
");

ConsoleKeyInfo desejaGelo = Console.ReadKey();

switch (inputOpcao.Key)
{
    case ConsoleKey.S:
        Console.WriteLine($"Tudo bem, adicionaremos gelo.");
        break;
    case ConsoleKey.N:
        Console.WriteLine($"Tudo bem, não adicionaremos gelo.");
        break;
    default:
        Console.WriteLine($"Você não inseriu uma resposta válida, não adicionaremos gelo.");
        break;
}




