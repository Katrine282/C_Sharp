namespace DataAccess.Model;

internal class Hold
{
    public int HoldId { get; set; }
    public string Navn { get; set; }
    private List<Studerende> studerende = new ();
    public List<Studerende>  Studerende
    {
        get
        {
            return studerende;
        }
    }

    public Hold()
    {
    }

    public Hold(int holdId, string navn)
    {
        HoldId = holdId;
        Navn = navn;
    }

    // public void AddStuderende(Studerende stud)
    // {
    //     studerende.Add(stud);
    //     stud.HoldId = this.HoldId;
    // }
    //
    // public void RemoveStuderende(Studerende stud)
    // {
    //     studerende.Remove(stud);
    //     stud.HoldId = null;
    // }
    
}