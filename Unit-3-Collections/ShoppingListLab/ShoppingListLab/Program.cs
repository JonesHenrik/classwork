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
        
        DisplayMenu(menuItems);
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
        do
        {
            Console.WriteLine("What item would you like to order? ");
            string userInput = Console.ReadLine();
            
            // if doesn't exist send an error
            // if correct add relevant item to list
            // Must be able to access dictionary and list in scope
            
            // should only check once for an element not everything
            foreach (var item in menuItems)
            {
                if (userInput.ToLower() == item.Key)
                {
                    shoppingCart.Add(item.Key);
                    Console.WriteLine($"adding {item.Key} to cart at ${item.Value}");
                }
                else
                {
                    Console.WriteLine("Sorry, we don't have those.  Please try again.");
                }
            }
            
            Console.WriteLine("Would you like to order anything else (y/n)?");
            string continueInput = Console.ReadLine();
            continueInput.ToLower().Substring(0, 1);

            if (continueInput == "n")
            {
                isShopping = false;
                // Return shopping list and cost?
                Console.WriteLine("Thanks for your order!");
                Console.WriteLine("Here's what you got:");
                foreach (var items in shoppingCart)
                {
                    Console.WriteLine(items + "     " + menuItems[items]);
                }
            }
            else
            {
                DisplayMenu(menuItems);
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
    }
}