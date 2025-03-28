namespace FirstProgram;

// this program will ask for three numbers 
//      add them together and display the total

// Programming solution - Human thinking
// Identify the detailed steps

// ask for numbers one at a time
// Write-down each number as its given
// add numbers together to create a sum/total
// tell the requester the total/sum 
//
// Now that we have the steps in our solution
// Identify any data/processes you need for the steps
//
// 1. A place to write down each number - a variable in a program
// 2. A place to hold the sum/total - a variable in a program
// 3. A way to ask for the numbers - a method in a program (object.method())
// 4. A way to receive the numbers - a method in a program (object.method())
// 5. A way to report the sum/total - a method in a program (object.method())
//
// Place the steps in the order and provide more detail if necessary
// we need to solve the problem
// 1. Ask for the numbers one at a time
//     a. Tell who ever is giving us the number to give me the first number
//     b. Receive the first number from sender
//     c. Write down first number

//     d. Tell who ever is giving us the number to give me the second number
//     e. Receive the second number from sender
//     f. Write down second number 

//     g. Tell who ever is giving us the number to give me the third number
//     h. Receive the third number from sender
//     i. Write down third number 
//
// 2. Add the numbers together create a sum
//      a. Add first number to a sum
//      b. Add second number to a sum
//      c. Add third number to a sum
//
// 3. Tell the requester the sum/total (display)

class Program
{
    static void Main(string[] args)
    {
        /***********************************************************************
         * Define any data the program needs at the top of the program
         *
         * Data may be defined anywhere before its used, it easier to
         * find at the top of the program
         *
         * To define a variable: data-type name = initial-value
         *
         * Commonly used data types in C#:
         *
         *      int - numeric data that is a whole number between +/- 2 billion
         *      long - a whole number that is greater than +/- 2 billion
         *      double - a numeric value with decimal places
         *      char - a single alpha-numeric character (contained in ' ' not " ")
         *      string - a series of alpha-numeric characters (words or sentence)
         *      bool - true or false value for conditions
         *
         * Variable names in C# are all in camelCase
         ***********************************************************************/
        
        // Define the variables to hold the numbers we need to add
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        // Define a variable to hold the sum of the numbers
        int sum = 0;
        
        Console.WriteLine("--- Starting Program ---");
        
        // Ask for numbers one at a time using the C# Console object
        // Console.ReadLine() returns a string - cannot store in an int
        Console.WriteLine("Please enter a number below:");
        string aLine;                                       // string to hold the line of input from the keyboard
        aLine = Console.ReadLine();                         // Get a line from the keyboard
        // We need an int value to store our numbers
        // Console.ReadLine() only returns a string
        // need to convert string into an int
        // int.Parse(string) will convert a string to an int
        number1 = int.Parse(aLine);
        
        
        Console.WriteLine("--- Ending Program ---");
    }
}