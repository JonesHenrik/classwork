namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers
        int[] numbers = new int[5]; 
        
        

        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a number: ");
            numbers[i] = int.Parse(Console.ReadLine());
            
            sum += numbers[i];
           
        }
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);

        Console.WriteLine("--- Ending program ---");
    }
}