﻿/*This is a simple high/low game in C#. 
1. Generate two numbers
2. Display the first number
3. Get the user's guess of whether the second number is higher or lower than the first.
4. Display the second number
5. Ask the user if they would like to play again
*/

Random number = new Random();

int firstNumber = number.Next(1, 15);
int secondNumber = number.Next(1, 15);

//this while loop resets the value of firstNumber if it gets assigned to the same number as secondNumber
while (firstNumber == secondNumber) 
{
    firstNumber = number.Next(1, 15);
}

Console.WriteLine($"The first number is {firstNumber}. Is the second number higher (A) or lower (B) than {firstNumber}?");

do
{
    if (Console.ReadKey().Key == ConsoleKey.A) //if user has pressed the A key
    {
        if (secondNumber > firstNumber)
        {
            Console.WriteLine($"You got it, the second number was higher!");
            Console.WriteLine("Press Esc to exit");
        }
        else
        {
            Console.WriteLine($"Too bad, the second number was lower :C");
            Console.WriteLine("Press Esc to exit");
        }
    }

    if (Console.ReadKey().Key == ConsoleKey.B) //if user has pressed the B key
    {
        if (secondNumber < firstNumber)
        {
            Console.WriteLine($"You got it, the second number was lower!");
            Console.WriteLine("Press Esc to exit");
        }
        else
        {
            Console.WriteLine($"Too bad, the second number was higher :C");
            Console.WriteLine("Press Esc to exit");
        }
    }

} while (Console.ReadKey().Key != ConsoleKey.Escape); //this do...while runs so long as the user has not pressed escape
