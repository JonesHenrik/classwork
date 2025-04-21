namespace ShoppingListLab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Chirpus Market!\n");
        
        Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>();
        
        menuItems["apple"] = (decimal)0.99;
        menuItems["banana"] = (decimal)0.59;
        menuItems["cauliflower"] = (decimal)1.59;
        menuItems["dragonfruit"] = (decimal)2.19;
        menuItems["elderberry"] = (decimal)1.79;
        menuItems["figs"] = (decimal)2.09;
        menuItems["grapefruit"] = (decimal)1.99;
        menuItems["honeydew"] = (decimal)3.49;
        
        //DisplayMenu(menuItems);
        AddItems(menuItems);
        // 12 spaces from figs to $
        // nice to have: Accurate spacing based on characters used in
        
        
        
        // List<String> shoppingCart = new List<String>();
    }

    // should this just return a list each time,
    // where does the dictionary live to access it can it passed in as a parameter
    static void AddItems(Dictionary<string, decimal> menuItems)
    {
        bool isShopping  = true;
        List<String> shoppingCart = new List<string>();
        bool isCorrect = true;
        do
        {
            DisplayMenu(menuItems);
            string userInput = Console.ReadLine();
            
            // if doesn't exist send an error
            // if correct add relevant item to list
            // Must be able to access dictionary and list in scope
            
            // should only check once for an element not everything
            // Use the .ContainsKey method for Dictionary
            try
            {
                if (menuItems.ContainsKey(userInput))
                {
                    shoppingCart.Add(userInput);
                }
                Console.WriteLine("Adding " + userInput + " to cart at $" + menuItems[userInput]);
                isCorrect = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, we don't have those. Please try again.");
                // repeat do loop
                isCorrect = false;
            }
            
            if (isCorrect)
            {
                Console.WriteLine("Would you like to order anything else (y/n)?");
                string continueInput = Console.ReadLine();
                continueInput.ToLower().Substring(0, 1);

                if (continueInput == "n")
                {
                    isShopping = false;
                    Console.WriteLine("Thanks for your order!");
                    Console.WriteLine("Here's what you got:");
                    foreach (var items in shoppingCart)
                    {
                        Console.WriteLine(items + "     " + menuItems[items]);
                    }
                    
                    decimal average = 0;
                    
                    foreach (var item in shoppingCart)
                    {
                        average += menuItems[item];
                    }
                    decimal shoppingCartAverage = average / shoppingCart.Count;
                    Console.WriteLine("Average price per item in order was $" + shoppingCartAverage);
                }
                else
                {
                    //DisplayMenu(menuItems);
                }
            }
            // after input 
        } while (isShopping);
    }

    static void DisplayMenu(Dictionary<string, decimal> menuItems)
    {
        Console.WriteLine("Item             Price"); // Tab Three times
        Console.WriteLine("==============================");
        
        foreach (var item in menuItems)
        {
            Console.WriteLine($"{item.Key}:     ${item.Value}");
        }
        
        Console.WriteLine("What item would you like to order? ");
    }

    static decimal returnAverage(Dictionary<string, decimal> menuItems)
    {
        decimal average = 0;
        foreach (var item in menuItems)
        {
            average += item.Value;
            average /= menuItems.Count;
        }
        // not getting correct math for average back
        //return average;
        // getting wrong average may need to use the list and reference each item
        // returns 1.84 each time?
        decimal differentAverage = menuItems.Values.Average();
        return differentAverage;
    }
}