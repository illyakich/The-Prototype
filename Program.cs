int guess;
while (true)
{
    Console.Write("think of a number a type it here homes ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess < 0 || guess > 100)
    {
        Console.WriteLine("try again, the number has to be between 0 and 100.");
        continue;
    }
    else
    {
        Console.Clear();
        break;
    }
}

while (true)
{
    Console.WriteLine("Hunter, guess the number from 0 to 100");
    int Hguess = Convert.ToInt32(Console.ReadLine());

    if (Hguess < guess)
    {
        Console.WriteLine("your guess is too low");
        continue;
    }
    else if (Hguess > guess)
    {
        Console.WriteLine("your guess is too high");
        continue;
    }
    else if (Hguess == guess)
    {
        Console.WriteLine("Congrats!");
        break;
    }
}