namespace fitness_center;

public class MultiClubMembers : Members
{
    private int membershipPoints;
    private bool isCheckedIn;
    
    public MultiClubMembers(string Name, int MemberID, int MembershipPoints, bool IsCheckedIn) : base(MembershipPoints, Name)
    {
        membershipPoints = MembershipPoints;
        isCheckedIn = IsCheckedIn;
    }

    public override void CheckIn(Club Club)
    {
        // throw new NotImplementedException();
        membershipPoints += 1;
        isCheckedIn = true;
    }
}