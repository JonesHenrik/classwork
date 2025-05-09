namespace CircleLab;

class Program
{
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Circle Tester");
        Console.WriteLine("Enter radius");
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new(radius);
        // need to validate user input
        
        bool wantsToGrow = false;
        do
        {
            Console.WriteLine($"Diameter: {circle.CalclateDiameter()}");
            Console.WriteLine($"Circumference: {circle.CalculateCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            
            Console.WriteLine("Should the circle grow? (y/n):");
            string input = Console.ReadLine();
            if (input == "y")
            {
                wantsToGrow = true;
                circle.Grow();
            }
            else
            {
                wantsToGrow = false;
                Console.WriteLine($"Goodbye. The circle's final radius is {circle.GetRadius()}.");
            }
        } while (wantsToGrow);
    }
}