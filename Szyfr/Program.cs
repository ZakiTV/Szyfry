// See https://aka.ms/new-console-template for more information
using Szyfr;
//Wyslanie zapytania o haslo do zaszyfrowania
Console.WriteLine("Podaj haslo do zaszyfrowania");
//wyczytanie stringa z wprowadzonego hasla
string text = Console.ReadLine();
// wyslanie do klasy stringa aby zaszyfrowac wybrana funkcja w tym przypadku wybrany szyfr GADERYPOLUKI
string output = Cypher.GADERYPOLUKICypher(text);
//Wyslanie zaszyfrowanego hasla po odebraniu go z klasy
Console.WriteLine("Zaszyfrowane haslo " + output);
