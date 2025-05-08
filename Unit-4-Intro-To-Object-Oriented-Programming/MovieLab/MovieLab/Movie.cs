namespace MovieLab;

public class Movie
{
    private string title { get; }
    private string category { get; set; }
    
    
    public Movie(string title, string category)
    {
        this.title = title;
        this.category = category;
    }

    public string GetTitle()
    {
        return title;
    }
    public string GetCategory()
    {
        return category;
    }

    public override bool Equals(object otherObject)
    {
        if (otherObject.GetType() != this.GetType()) // If types differ...
        {
            return false; //     they can't be equal
        }

        if (otherObject == this) // if the same object...
        {
            return true; //    they must be equal
        }
        
        Movie otherMovie = (Movie) otherObject;
        
        if (otherMovie.category == this.category)
        {
            return true;
        }
        return false;
    }
}