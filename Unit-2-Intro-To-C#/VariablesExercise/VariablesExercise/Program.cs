namespace VariablesExercise;

class Program
{
    static void Main(string[] args)
    {
        // 1.1
        // Prompt the user to enter a string.
        // After the user enters a string, output the same string back to the console
        
        Console.WriteLine("Enter some text: ");
        string text = Console.ReadLine();
        Console.WriteLine(text);
        
        // 1.2
        // Prompt the user to enter a number.
        // After the user enters a number, add 1 to the number and output it back to the code
        
        Console.WriteLine("Enter some number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number + 1);
        
        // 1.3
        // Prompt the user to enter a number.
        // After the user enters a number, add .5 to the number and output it back to the console
        
        Console.WriteLine("Enter a number: ");
        float number1 = float.Parse(Console.ReadLine());
        Console.WriteLine(number1 + 0.5);
        
        // 1.4
        // Prompt the user to enter two numbers. After the user enters the numbers, add them together
        // and output the sum back to the console.

        float sum = 0;
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter a number: ");
            float number2 = float.Parse(Console.ReadLine());
            
            sum += number2;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        // 1.5
        // Prompt the user to enter two numbers. After the user enters the numbers, multiply them and
        // output the product back to the console.
        
        float product = 1;
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Enter a number: ");
            float number3 = float.Parse(Console.ReadLine());
            
            product *= number3;
        }
        Console.WriteLine($"The product is: {product}");
        
        // 1.6
        // Use the int type here. Prompt the user to enter two numbers. After the user enters the
        // numbers, divide them and output the result back to the console. Notice what happens when
        // you enter two numbers that don’t divide evenly. What number do you get? Try running the
        // program by entering decimal numbers. What happens?

        int answer = 0;
        
        Console.WriteLine("Enter a number: "); 
        int number4 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter a number: "); 
        int number5 = int.Parse(Console.ReadLine());
        
        answer = number4 / number5;
        Console.WriteLine($"The answer is: {answer}");
        
        // 1.7
        // Prompt the user to enter a boolean. Write out the boolean value, and then write out the
        // opposite of the boolean variable.
        
        // Question: What possible things can the user enter to input a valid boolean? Try
        // different things and see if you can come up with the answer.
        
        // Next, notice also the difference between what you type into code for a boolean value
        // of either true or false, and what displays on the screen when you WriteLine a boolean
        // value.
        
        Console.WriteLine("Enter a boolean: ");
        string userInput = Console.ReadLine();
        if (userInput == "true" || userInput == "True")
        {
            Console.WriteLine("You entered true");
            Console.WriteLine("The opposite of what you entered is: False");
        } else if (userInput == "false" || userInput == "False")
        {
            Console.WriteLine("You entered false");
            Console.WriteLine("The opposite of what you entered is: True");
        }
        else
        {
            Console.WriteLine("You did not enter true or false");
        }
    }
}