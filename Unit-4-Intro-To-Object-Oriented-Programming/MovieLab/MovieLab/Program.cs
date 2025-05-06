namespace MovieLab;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Movie List Application!\n");
    
        // Create list of Movies class
        //private List<Movie> listOfMovies = [Movie("John Wick", "Action")];
        // Add at least ten Movies to the list
        // Print amount of movies in the list to the Console
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
    }
}