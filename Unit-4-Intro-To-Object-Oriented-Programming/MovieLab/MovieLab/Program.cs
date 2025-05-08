namespace MovieLab;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Movie List Application!\n");
    
        // Create list of Movies class
        // Add at least ten Movies to the list
        List<Movie> movies = new List<Movie>
        {
            new Movie("John Wick", "Action"),
            new Movie("Gladiator", "Action"),
            new Movie("The Dark Knight", "Action"),
            new Movie("Superbad", "Comedy"),
            new Movie("The Grand Budapest Hotel", "Comedy"),
            new Movie("Hereditary", "Horror"),
            new Movie("The Conjuring", "Horror"),
            new Movie("Get Out", "Horror"),
            new Movie("Inception", "Science Fiction"),
            new Movie("Intersteller", "Science Fiction"),
        };
        // Print amount of movies in the list to the Console
        Console.WriteLine($"There are {movies.Count} movies in the list.");
        bool isViewing = false;
        /****** Display menu of categories by entering a number ******/
        Console.WriteLine("What category are you interested in?"); 
        
        do
        {
            string category = Console.ReadLine();
            category = category.Replace(" ", "").ToLower();
            
            // cant figure out spacing issues
            if (category == "action" || category == "comedy" || category == "sciencefiction" || category == "horror")
            {
                foreach (var movie in movies)
                {
                    if (movie.GetCategory().Replace(" ", "").ToLower() == category)
                    {
                        Console.WriteLine(movie.GetTitle());
                    }
                }
            }
            else
            {
                isViewing = true;
                Console.WriteLine("Please enter a valid category.");
            }
            
            Console.WriteLine("Would you like to view more movies? (y/n)");
            string wantsToContinue = Console.ReadLine();
            if (wantsToContinue == "y")
            {
                isViewing = true;
                Console.WriteLine("What category are you interested in?"); 
            }
            else
            {
                isViewing = false;
                Console.WriteLine("Thank you for using the Movie List!");
            }

        } while (isViewing);
        
    }
}