
using Intro;
using MyLibary;

Console.WriteLine("Hello, World!");

//opg 3 og 4
Person person = new Person("Martin");
Console.WriteLine(person);
person.Name = "Benny";
Console.WriteLine(person);

//opg 5
var fido = new Animal("hund");
Console.WriteLine("fido er en hund? " + fido.IsDog());


//while (true)
//{
//    console.writeline("hvilket dyr ønsker du?");
//    string navn = console.readline();
//    var animal = new animal(navn);
//    console.writeline($"du har valgt et dyr af arten: {animal.species}");
//}

//opg 6
var list = new MyList();
//list.AddNumber(1);
//list.AddNumber(10);
//list.AddNumber(100);
list.PrintNumbers();