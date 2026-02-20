// See https://aka.ms/new-console-template for more information

using Øvelse3._2_3._7;

var medarbejderCollection = new MedarbejderListe<CprNr>();
var morten = new Mekaniker(new CprNr("211271", "7777"),"Morten", new Adresse("Testvej", 23) , "1320", 2017, 195);
var karina = new Mekaniker(new CprNr("141174", "8888"),"Karina", new Adresse("Testvej", 89), "1410", 2019, 190);
medarbejderCollection.AddElement(karina.Cpr, karina);
medarbejderCollection.AddElement(morten.Cpr, morten);

Console.WriteLine(morten.ToString());
Console.WriteLine(karina.ToString());


