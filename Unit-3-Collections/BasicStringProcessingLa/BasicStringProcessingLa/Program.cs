namespace BasicStringProcessingLa;

class Program
{
    static void Main(string[] args)
    {
        firstExample();
        secondExample();
    }
    static void firstExample()
    {
        bool isEnteringSentences = false;
        do
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            char[] arrayOfInput = new char[] { ' ' };

            string[] output = input.Split(arrayOfInput);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }

            Console.WriteLine("Would you like to continue? (y/n)? ");
            string continueResponse = Console.ReadLine();
            string firstChar = continueResponse.Substring(0, 1).ToLower();
            
            if (continueResponse == "y")
            {
                isEnteringSentences = true;
            }
            else
            {
                isEnteringSentences = false;
                Console.WriteLine("Goodbye!");
            }

        } while (isEnteringSentences);
    }

    static void secondExample()
    {
        bool isEnteringStrings = false;
        List<String> listOfInputs = new List<String>();
        
        do
        {
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();
            
            listOfInputs.Add(input);
            string sentence = "";
            
            for (int i = 0; i < listOfInputs.Count; i++) 
            {
                sentence += listOfInputs[i] + " ";
                Console.WriteLine("You have entered: " + sentence);
            }
            
            Console.WriteLine("Would you like to continue? (y/n)? ");
            string continueResponse = Console.ReadLine();
            continueResponse = continueResponse.Substring(0, 1).ToLower();

            if (continueResponse == "y")
            {
                isEnteringStrings = true;
            } else if (continueResponse == "n")
            {
                isEnteringStrings = false;
                Console.WriteLine("Goodbye!");
            }
        } while (isEnteringStrings);
    }
}