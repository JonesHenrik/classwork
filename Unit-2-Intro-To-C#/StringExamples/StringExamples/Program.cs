namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        // Strings are a special data type
        // Strings are encolsed in " "
        // A literal is something that says what it is

        string string1 = "a";
        string string2 = "a";
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than the second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is not greater than string2");
        }
    } // End of Main()
} // End of class Program