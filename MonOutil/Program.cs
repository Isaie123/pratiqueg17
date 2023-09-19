// See https://aka.ms/new-console-template for more information
using MonOutil;
using System.ComponentModel.Design;

Console.WriteLine("\t\t\t\t\t\t Bonjour, quel est votre nom");

string? usernames;
usernames = Console.ReadLine();

Console.WriteLine($"Bienvenu {usernames} à MonOutil.");
Console.WriteLine("\t\t\t\t\t\tVous aimerez acceder a l'opption \n\t\t\t\t\t\t\t Monnais ou bien, Météo");

while (true)
{
    string line = Console.ReadLine();
    if (line.ToLower() == "Monnais" || line.ToLower() == "monnais")
    {
      new Monnais();
    }
   else if (line.ToLower() == "meteo" || line.ToLower() == "météo")
    {
        new Meteo();
    }
}