namespace MovieLab;

public class Movie
{
    string title;
    string category;


    public string Title
    {
        get { return title; }
    }

    public string Category
    {
        get { return category; }
    }
    
    public Movie(string title, string category)
    {
        title = title;
        category = category;
    }
}