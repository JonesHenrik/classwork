namespace fitness_center;

public class Main
{
    public Members Members { get; set; }
    // AddMultiClubMember
    public void AddMultiClubMember(List<Members> members)
    {
        
    }
    
    // Ask a user if they want to select a Club
    // take last of members list and assign them to a club
    // assume club has been validated in main
    public Members AddSingleClubMember(List<Members> members, List<Club> clubs)
    {
        Random rng = new Random();
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        bool isValidClub = false;
        do
        {
            Console.WriteLine("What club do you want to do?");
            string clubName = Console.ReadLine();
            // validate club
            foreach (var club in clubs)
            {
                if (club.)
            }           
        } while (isValidClub);

        Members member = new SingleClubMembers(name, rng.Next(Int32.MaxValue), club, false);
        return member;
    }

    // Display clubs
    public void DisplayClubs(List<Club> clubs)
    {
        Console.WriteLine("We have the following clubs:");
        foreach (var club in clubs)
        {
            Console.WriteLine($"- {club}");
        }
    }
    
    
    // Add members should be able to either pick from all 4 fitness centers or have the option to be a multi-club member
}