//Øvelse 5.8
// int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

//Returner alle two-digit integers sorteret i ascending order
// IEnumerable<int> resultat = numbers
//     .Where(i => i.ToString().Length == 2)
//     .OrderBy(i => i);
// foreach (var i in resultat)
// {
//     Console.WriteLine(i);
// }

//Returner alle two-digit integers sorteret i descending order
// IEnumerable<int> resultat = numbers
//     .Where(i => i.ToString().Length == 2)
//     .OrderByDescending(i => i);
// foreach (var i in resultat)
// {
//     Console.WriteLine(i);
// }

//delopgave 1), men retunere strings
// IEnumerable<string> res = numbers
//     .Where(i => i.ToString().Length == 2)
//     .OrderBy(i => i)
//     .Select(i => "" + i);
// foreach (var i in res)
// {
//     Console.WriteLine(i);
// }

//delopgave 2), men retunere strings som “20 even”
// IEnumerable<string> res = numbers
//     .Where(i => i.ToString().Length == 2)
//     .OrderByDescending(i => i)
//     .Select(i => i % 2 == 0 ?  i + " even" : i + " uneven");
// foreach (var i in res)
// {
//     Console.WriteLine(i);
// }

//----------------------------------------------------------------------------------
//Øvelse 5.10

Random rnd = new Random();

List<int> numbers = new List<int>();
for (int i = 0; i < 100; i++)
{
    numbers.Add(rnd.Next(1, 101)); // 1–100
}

numbers.ForEach(i => Console.Write(i + ", "));
Console.WriteLine();

//Find antallet af ulige tal I listen.
// int result = numbers.Count(i => i % 2 == 0);
// Console.WriteLine(result);

//Find antallet af unikke tal I listen
// int result = numbers.Distinct().Count();
// Console.WriteLine(result);

//Find de tre første ulige tal
// var result = numbers.Where(i => i % 2 == 1).Take(3);
// Console.WriteLine();
// foreach (var item in result)
// {
//     Console.Write(item + ", ");
// }

//Find alle unikke ulige tal
// var result = numbers.Where(i => i % 2 == 1).Distinct();
// Console.WriteLine();
// foreach (var item in result)
// {
//     Console.Write(item + ", ");
// }
