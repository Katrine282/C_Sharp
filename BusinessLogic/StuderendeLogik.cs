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
}