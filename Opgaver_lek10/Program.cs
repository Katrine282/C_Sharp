// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using Opgaver_lek10.DAL;
using Opgaver_lek10.Model;

ElevContext context = new ElevContext();
Console.WriteLine(context.Database.EnsureCreated());

// context.Database.EnsureDeleted();
// context.Database.EnsureCreated();

bool running = true;

while (running)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Vis alle elever");
    Console.WriteLine("2 - Vis alle klasser");
    Console.WriteLine("3 - Vis elever i en klasse");
    Console.WriteLine("4 - Opret klasse");
    Console.WriteLine("5 - Opret elev og tilføj klasse");
    Console.WriteLine("6 - Afslut");
    Console.Write("Vælg: ");

    string valg = Console.ReadLine();

    switch (valg)
    {
        case "1":
            var elever = context.Elever.Include(e => e.klasse).ToList();

            Console.WriteLine("\nAlle elever:");
            foreach (var elev in elever)
            {
                Console.WriteLine(elev);
            }
            break;

        case "2":
            var klasser = context.Klasser.ToList();

            Console.WriteLine("\nAlle klasser:");
            foreach (var klasse in klasser)
            {
                Console.WriteLine($"{klasse.KlasseId} - {klasse.KlasseName}");
            }
            break;

        case "3":
            Console.Write("Indtast klasse ID: ");
            int klasseId = int.Parse(Console.ReadLine());

            var eleverIKlasse = context.Elever
                .Where(e => e.klasseId == klasseId)
                .ToList();

            Console.WriteLine("\nElever i klassen:");

            foreach (var elev in eleverIKlasse)
            {
                Console.WriteLine(elev.Navn);
            }
            break;

        case "4":
            Console.Write("Indtast klasse navn: ");
            string klasseNavn = Console.ReadLine();

            if (klasseNavn != null)
            {
                context.Klasser.Add(new Klasse(klasseNavn));
                context.SaveChanges();
            }
            
            break;
        
        case "5":
            Console.Write("Indtast navn på elev: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast CPR-nr: ");
            string cpr = Console.ReadLine();
            Console.Write("Indtast adresse: ");
            string adresse = Console.ReadLine();
            
            var klasserne = context.Klasser.ToList();
            foreach (var klasse in klasserne)
            {
                Console.WriteLine($"{klasse.KlasseId} - {klasse.KlasseName}");
            }
            Console.Write("vælg klasseId: ");
            int klasseID = int.Parse(Console.ReadLine());
            Klasse klasseFraSql = context.Klasser.First(k => k.KlasseId == klasseID);
            
            Elev Elev = new Elev(navn, cpr, adresse);
            Elev.setKlasse(klasseFraSql);
            context.Elever.Add(Elev);
            context.SaveChanges();
            
            break;
        
        case "6":
            running = false;
            break;

        default:
            Console.WriteLine("Ugyldigt valg");
            break;
    }
}
