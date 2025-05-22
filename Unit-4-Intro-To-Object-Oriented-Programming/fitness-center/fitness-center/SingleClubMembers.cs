namespace fitness_center;

public class SingleClubMembers : Members
{
    private Club club;
    private bool isCheckedIn;

    public SingleClubMembers(string Name, int MemberID, Club Club, bool IsCheckedIn) : base(MemberID, Name)
    {
        club = Club;
        isCheckedIn = IsCheckedIn;
    }

    public override void CheckIn(Club Club)
    {
        // throws an exception if it is not their club
        try
        {
            Club = club;
            isCheckedIn = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("You are not a member of this club");
        }
    }
}