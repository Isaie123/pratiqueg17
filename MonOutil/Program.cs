// See https://aka.ms/new-console-template for more information
using MonOutil;

Console.WriteLine("Bonjour, quel est votre nom");

string? usernames;
usernames = Console.ReadLine();

Console.WriteLine($"Bienvenu {usernames} à MonOutil.");

new Meteo();
