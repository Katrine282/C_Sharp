using DataAccess.Context;
using DataAccess.Mappers;
using Studerende = DTO.Studerende;
using Hold = DTO.Hold;

namespace DataAccess.Repositories;

public class StuderendeRepository
{
    public static Studerende GetStuderende(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            //Maybe throw exception if not found
            return StuderendeMapper.Map(context.Studerendes.Where(s => s.ID == id).First());
        }
    }

    public static List<Studerende> GetAllStuderende()
    {
        using (var context = new StuderendeContext())
        {
            return context.Studerendes
                .Select(s => StuderendeMapper.Map(s))
                .ToList();
        }
    }

    public static void AddStuderende(Studerende studerende)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            DataAccess.Model.Studerende s = StuderendeMapper.Map(studerende);
            context.Studerendes.Add(s);
            context.SaveChanges();
        }
    }

    public static void DeleteStuderende(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            DataAccess.Model.Studerende removed = context.Studerendes.Where(s => s.ID == id).First();
            
            context.Studerendes.Remove(removed);
            context.SaveChanges(); // VIGTIGT: Dette sender "DELETE FROM..." til SQL
            
        }
    }
    // public static void UpdateStuderende(Studerende studerende){}
    public static void AddHold(Hold hold)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            DataAccess.Model.Hold h = StuderendeMapper.Map(hold);
            context.Holdene.Add(h);
            context.SaveChanges();
        }
    }
    
    public static List<Hold> GetAllHold()
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            return context.Holdene
                .Select(h => StuderendeMapper.Map(h))
                .ToList();
        }
    }

    public static List<Studerende> GetStudereneTilHold(int holdId)
    {
        using (var context = new StuderendeContext())
        {
            return context.Studerendes
                .Where(s => s.HoldId == holdId) 
                .ToList()                       
                .Select(s => StuderendeMapper.Map(s)) 
                .ToList();
        }
    }

    public static void AddStuderendeTilHold(int holdId, int studId)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            // Console.WriteLine($"DEBUG: Prøver at gemme StuderendeID {studId} på HoldID {holdId}");            
            var studerende = context.Studerendes.Find(studId);
            if (studerende != null)
            {
                studerende.HoldId = holdId; 
                context.SaveChanges();
            }
        }
    }
    
    public static Hold GetHold(int id)
    {
        using (StuderendeContext context = new StuderendeContext())
        {
            return StuderendeMapper.Map(context.Holdene.Where(h => h.HoldId == id).First());
        }
    }
    
    //--------------------------------------------------------------------------------------
    
    public static void OpdaterStudKarakter(TransactionManager manager, Studerende studerende, int karakter)
    {
        StuderendeContext context = manager.GetCurrentContext();
    
        DataAccess.Model.Studerende dataStud = context.Studerendes.Find(studerende.ID);
        dataStud.Karakter = karakter;
    }
    public static void OpdaterHoldTilskud(TransactionManager manager, int HoldId, int tilskud)
    {
        StuderendeContext context = manager.GetCurrentContext();
        
        DataAccess.Model.Hold dataHold = context.Holdene.Find(HoldId);
        dataHold.TaxameterTilskud += tilskud;
    }
}