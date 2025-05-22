namespace fitness_center;

class Program
{
    static List<Club> clubs = new List<Club>()
    {
        new Club("LA Fitness", "2846 Woodward"),
        new Club("Powerhouse", "736 Mack Blvd"),
        new Club("Detroit Boxing Gym", "293 GrandCircus Blvd"),
        new Club("Elevate Fitness", "3929 E Jefferson Blvd")
    };

    private static List<Members> members = new List<Members>()
    {
        new MultiClubMembers("Brock", 321513541, 0, false),
        new MultiClubMembers("Kyle", 25763, 0, false),
        new SingleClubMembers("Brad", 55532, clubs[0], false),
        new SingleClubMembers("Jason", 55532, clubs[1], false)
    };
    
    static void Main(string[] args)
    {
        Console.WriteLine("--- Welcome to Fitness Center App! ---");
        
        Console.WriteLine($"We currently have a total of {members.Count} members!");
        Console.WriteLine("Would you like to: Add a member, remove a member, or display member info?");
        Console.WriteLine("To add type: 'a'. To remove type: 'r'. To display type: 'd'.");
        string UserChoice = Console.ReadLine();
        UserChoice = UserChoice.ToLower().Replace(" ", "");
        
        bool ValidChoice = false;
        do
        {
            if (UserChoice == "a")
            {
                // add a user
            } 
            else if (UserChoice == "r")
            {
                // remove a user
            }
            else if (UserChoice == "d")
            {
                // display member info
                // if .Equals or member name == a name in members return desc
            }
        } while (ValidChoice);

    }
}