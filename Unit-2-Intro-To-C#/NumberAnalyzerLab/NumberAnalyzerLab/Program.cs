namespace NumberAnalyzerLab;

class Program
{
    static void Main(string[] args)
    {
        var isPlaying = true;
        while (isPlaying)
        {
            Console.WriteLine("Please enter a number from 1 to 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                // % is the Modolus operator and basically displays the remainder
            }
            else
            { 
                Console.WriteLine("You must enter a number from 1 to 100: ");
            }
        }
    }
}