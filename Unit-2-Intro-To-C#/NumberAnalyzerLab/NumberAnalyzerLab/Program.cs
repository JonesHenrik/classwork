namespace NumberAnalyzerLab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var isPlaying = true;
        while (isPlaying)
        {
            Console.WriteLine($"Welcome {name}! Please enter a number from 1 to 100: ");
            
            bool isInRange = false;
            
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1 || number >= 100)
            {
                while (!isInRange)
                {
                    Console.WriteLine("You must enter a number from 1 to 100: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 1 || number <= 100)
                    {
                        isInRange = true;
                        respondingToUserInput(number);
                    }
                }
            }
            else 
            {
                isInRange = true;
                respondingToUserInput(number);
            }
            
            Console.WriteLine("Would you like to play again? y/n: ");
            string userInput = Console.ReadLine();
            if (userInput == "n" || userInput == "no" || userInput == "N")
            {
                isPlaying = false;
                Console.WriteLine($"Thank you for playing {name}!");
            }
        }
    }

    static void respondingToUserInput(int number)
    {
        // % is the Modolus operator and basically displays the remainder
        // We can show a number is odd if the remainder when % by 2 is 1
        // 2. a
        if (number % 2 == 1 && number < 60)
        {
            Console.WriteLine("Odd and less than 60"); 
            // 2. b 
        } else if (number % 2 == 0 && number <= 24 && number >= 1)
        {
            Console.WriteLine("Even and less than 25");
            // 2. c
        } else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            Console.WriteLine("Even and between 26 and 60 inclusive");
            // 2. d
        } else if (number % 2 == 0 && number >= 60)
        {
            Console.WriteLine("Even and greater than 60");
            // 2. e
        } else if (number % 2 == 1 && number >= 60)
        {
            Console.WriteLine("Odd and greater than 60");
        }
    }
}