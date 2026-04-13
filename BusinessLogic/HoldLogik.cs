using DataAccess.Repositories;
using DTO;

namespace BusinessLogic;

public class HoldLogik
{
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

    public static void GivKarakterTilHold(int holdId)
    {
        DataAccess.TransactionManager manager = new DataAccess.TransactionManager();
        manager.ExecuteTransaction(() =>
        {
            var studerende = StuderendeRepository.GetStudereneTilHold(holdId);
            var tilskud = 0;
            int[] karakterer = { -3, 0, 2, 4, 7, 10, 12 };
            Random random = new Random();
            foreach (var stud in studerende)
            {
                int index = random.Next(karakterer.Length);
                var karakter = karakterer[index];
                StuderendeRepository.OpdaterStudKarakter(manager, stud, karakter);
                if (index > 3)
                {
                    tilskud += 1000;
                }
            }
            StuderendeRepository.OpdaterHoldTilskud(manager, holdId, tilskud);
        });
    }
}