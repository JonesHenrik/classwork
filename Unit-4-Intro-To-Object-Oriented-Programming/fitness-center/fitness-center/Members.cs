namespace fitness_center;

public abstract class Members
{
    private int memberID;
    private string name;
    
    public Members(int MemberID, string Name)
    {
        memberID = MemberID;
        name = Name;
    }
    
    public abstract void CheckIn(Club club);
}