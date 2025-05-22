namespace fitness_center;

public abstract class Members
{
    // Consider a UUID()
    private int memberID;
    private string name;
    
    public Members(int MemberID, string Name)
    {
        memberID = MemberID;
        name = Name;
    }
    
    public abstract void CheckIn(Club club);

    public override string ToString()
    {
        return $"Name: {name}, ID: {memberID}";
    }
    // Equatable Members based on memberID and name
    public override bool Equals(object otherObject)
    {
        if (otherObject.GetType() != this.GetType())  // If types differ...
        {
            return false;                             //     they can't be equal
        }

        if (otherObject == this)                      // if the same object...
        {
            return true;                              //    they must be equal
        }
        
        Members otherMember = (Members)otherObject;

        if (otherMember.memberID == this.memberID && otherMember.name == this.name)
        {
            return true;
        }
        return false;
    }
}