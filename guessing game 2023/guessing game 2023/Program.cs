// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Sok and Sergei's Guessing Game!");




Console.WriteLine("Can you guess the correct number 1-10? ");

int attempt = 1;
while (attempt < 4)
{
    int guessNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Attempt #" + attempt);
    attempt++;

    if (guessNumber.Equals(5))
    {
        Console.WriteLine("Thats Correct!!");
    }
    else if (guessNumber >= 10)
    {
        Console.WriteLine("Number should be 1-10");
    }
    else
    {
        Console.WriteLine("Wrong. Try Again");
    }
}

