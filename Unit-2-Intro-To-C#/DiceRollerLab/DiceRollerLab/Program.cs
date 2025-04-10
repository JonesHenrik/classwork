namespace DiceRollerLab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the amount of sides on your dice you would like");
        Console.WriteLine("Your dice will have a max value of: " + maxDieSelection());
    }

    static int maxDieSelection()
    {
        int sides = 0;
        bool correctInput = false;
        while (!correctInput)
        {
            sides = int.Parse(Console.ReadLine());
            if (sides >= 0 && sides <= 6)
            {
                correctInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a number between 0 and 6");
            }
        }
        return sides;
        
    }

    static int rollDice(int sides)
    {
        
    }
}