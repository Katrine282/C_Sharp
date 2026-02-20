namespace Øvelse3._2_3._7;

public class CprNr
{
    public string BirthDate { get; set; }
    public string SequenceNumber { get; set; }
    public CprNr(String bDate, String sNumber)
    {
        BirthDate = bDate;
        SequenceNumber = sNumber;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(BirthDate, SequenceNumber);
    }

    public override bool Equals(object obj)
    {
        CprNr cpr2 = (CprNr)obj;
        return BirthDate.Equals(cpr2.BirthDate) && SequenceNumber.Equals(cpr2.SequenceNumber);
    }

    public override string ToString()
    {
        return BirthDate + "-" + SequenceNumber;
    }
}