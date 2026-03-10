// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using Opgaver;

HttpClient klient = new HttpClient();
string url = "http://localhost:5055/api/person/getall";
var response = await klient.GetAsync(url);
string json = await response.Content.ReadAsStringAsync();

Console.WriteLine(json);

// Console.WriteLine("Skriv navn");
// string navn = Console.ReadLine();
//
// Console.WriteLine("Skriv alder");
// int alder = Convert.ToInt32(Console.ReadLine());
//
// if (!string.IsNullOrEmpty(navn) && alder > 0)
// {
//     Person p = new Person(navn, alder);
//     var postResponse = await klient.PostAsJsonAsync(url + "/add", p);
//
//     string result = await postResponse.Content.ReadAsStringAsync();
//     Console.WriteLine("Person tilføjet:");
//     Console.WriteLine(result);
//     
// } else 
// {
//     Console.WriteLine("du har ikke skrevet det rigtig");
// }


