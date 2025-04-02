namespace AddNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Start Program ----");
        
        // Ask the user for 3 numbers one at a time
        // to produce a sum
        
        // 1. Do this 3 times - A loop allows us to 
        //      Ask user to enter a number
        //      Get the number from user
        //      Add the number to a sum
        // Syntax of a for loop:
        //      for(int variable = initial-value; variable < #-times-to-Loop; variable++) {
        //      }
        //
        // The for-loop is controlled by the variable defined within it:
        
        // 1. int variable=initial-value - initializes the varible (usually to 0)
        // 2. the condition following the variable def is tested:
        //      a. if true - perform process in the loop
        //         increment the variable according the last part of the loop
        //         go back to #2
        //      b. if false - exit loop after closing brace
        
        
        // 2. Display the sum of numbers
        
        // Data we need:
        //
        // 1. a place to hold the number entered by the users
        // 2. a place to hold the sum of the numbers
        
        // Define a place to hold the number entered by the user
        int firstEntry = 0;
        
        // Define a place to hold the sum of the numbers
        var sum = 0;

        for (int i = 0; i < 3; i++)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number number: ");
        
            // Get the number they enter
            string theUserResponse = Console.ReadLine(); // get data from keyboard
            firstEntry = int.Parse(theUserResponse);
        
            // Add the number to the sum
            sum += firstEntry;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        
        Console.WriteLine("---- End Program ----");
    }
}