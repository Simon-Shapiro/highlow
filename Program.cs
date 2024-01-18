/*This is a simple high/low game in C#. 
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

//get user input -- .toLowerCase/ .toUpperCase on A/B to make input case insensitive

do
{
    if (/*user input was A/a*/)
    {
        if (secondNumber > firstNumber)
        {
            Console.WriteLine($"You got it, the second number was higher!");
        }
        else
        {
            Console.WriteLine($"Too bad, the second number was lower :C");
        }
    }

    if (/*user input was B/b*/)
    {
        if (secondNumber < firstNumber)
        {
            Console.WriteLine($"You got it, the second number was lower!");
        }
        else
        {
            Console.WriteLine($"Too bad, the second number was higher :C");

        }
    }

} while (/*user has not hit esc to end the game*/);
