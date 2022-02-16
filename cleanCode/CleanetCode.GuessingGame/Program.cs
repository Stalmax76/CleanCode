
/// <summary>
/// Game "Gues the number"
/// </summary>
/// 


// Приветствие и знакомство
Console.WriteLine("\t Hello,It is the Game \"Gues the number\". What is your name?");
string? userName = Console.ReadLine();
Console.WriteLine($"\t I'm glad to meet yuo {userName}, are you want to play?");

// приглашение на игру 
Console.WriteLine("\t if you want to play choose \" + \", if NOT then press \" - \" ");



char startGame; 
    bool result = char.TryParse(Console.ReadLine(), out startGame);
if (result && startGame == '+')
{
    Console.WriteLine(" We guessed a number from 0 to 1000, try to guess! ");
    //Console.WriteLine(number);
}
else
{
    Console.WriteLine(" It's too bad you don't want to play. Maybe next time! Bye! ");
   
}

/// <summary>
//Загадываем число для игры
/// </summary>
Random r = new Random();
int number = r.Next(0, 1001);
bool game = true;

int userNumber;
int attempt = 0;

Console.WriteLine(number); // вывод числа для теста

while(game)
{
    
    Console.WriteLine("Enter your number \t");
    bool res = int.TryParse(Console.ReadLine(), out userNumber);

    if (res && userNumber <= 1000 && userNumber > 0)
    {
        if (userNumber == number)
        {
            attempt++;
            game = false;
            Console.WriteLine($"Congratulations {userName} You guessed it with {attempt} try!!!");
        }
        else if (userNumber > number) 
        {
            attempt++;
            Console.WriteLine("Your number is greater. Try again!");
        }
        else
        {
            attempt++;
            Console.WriteLine("Your number is less. Try again!");
        }
    }
    else
    {
       
        attempt++;
        game = true;
        Console.WriteLine($"\t Dear {userName}, You entered incorrect data, and made {attempt} an attempt. Be careful!!!!");
    }

} 