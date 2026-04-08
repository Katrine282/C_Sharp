using DataAccess.Model;

namespace DataAccess.Mappers;

internal class StuderendeMapper
{
    public static DTO.Studerende Map(Studerende studerende)
    {
        DTO.Studerende s = new DTO.Studerende(studerende.ID,studerende.Navn, studerende.Studiestart,
            studerende.Alder, studerende.Studietype);
        if (studerende.HoldId != null)
        {
            s.HoldId = studerende.HoldId;
        }

        return s;
    }

    public static Studerende Map(DTO.Studerende studerende)
    {
        Studerende s = new Studerende(studerende.ID,studerende.Navn, studerende.Studiestart,
            studerende.Alder, studerende.Studietype);
        if (studerende.HoldId != null)
        {
            s.HoldId = studerende.HoldId;
        }
        return s;
    }
    
    public static DTO.Hold Map(Hold hold)
    {
        return new DTO.Hold(hold.HoldId,hold.Navn);
    }

    public static Hold Map(DTO.Hold hold)
    {
        return new Hold(hold.HoldId,hold.Navn);
    }
}