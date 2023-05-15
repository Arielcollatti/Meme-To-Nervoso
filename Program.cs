Console.WriteLine("--- Meme to nervoso ---\n");

string digite, MemeToNervoso;

Console.Write("Usuário, o que você pensa sobre mim? ");
digite = Console.ReadLine()!;

MemeToNervoso =
    $"{digite.Remove(10)}... NÃO, PERA. \n Tô nervoso";

Console.WriteLine($"{MemeToNervoso}");