using DataAccess.Repositories;
using DTO;

namespace BusinessLogic;

public class StuderendeLogik
{
    public static Studerende GetStuderende(int id)
    {
        return StuderendeRepository.GetStuderende(id);
    }

    public static List<Studerende> GetAllStuderende()
    {
        return StuderendeRepository.GetAllStuderende();
    }

    public static void AddStuderende(Studerende studerende)
    {
        StuderendeRepository.AddStuderende(studerende);
    }

    public static void DeleteStuderende(int id)
    {
        StuderendeRepository.DeleteStuderende(id);
    }
    
    // public static void UpdateStuderende(Studerende studerende){}

    public static void AddHold(Hold hold)
    {
        StuderendeRepository.AddHold(hold);
    }

    public static List<Studerende> GetStudereneTilHold(int holdId)
    {
        return StuderendeRepository.GetStudereneTilHold(holdId);
    }

    public static List<Hold> GetAllHold()
    {
        return StuderendeRepository.GetAllHold();
    }

    public static void AddStuderendeTilHold(int holdId, int studId)
    {
        StuderendeRepository.AddStuderendeTilHold(holdId, studId);
    }
    
    public static Hold GetHoldById(int id)
    {
        return StuderendeRepository.GetHold(id);
    }
}