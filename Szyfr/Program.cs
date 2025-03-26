// See https://aka.ms/new-console-template for more information
using Szyfr;

Console.WriteLine("Podaj litere do zaszyfrowania");
string text = Console.ReadLine();
string output = Cypher.GADERYPOLUKICypher(text);

Console.WriteLine("Zaszyfrowana litera " + output);