using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;


namespace MonOutil
{
    internal class Meteo
    {
        public Meteo()
        {
            double tempEnCelsius;
            double tempEnFahrenheit;
            string celsius, fahrenheit;

            Console.WriteLine("Bienvenue à mon programme de Météo");
            Console.WriteLine("Entrez C pour Celsius, F pour Fahrenheit");

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "c")
                {
                    Console.WriteLine("Bienvenue en mode Celsius.");
                    Console.WriteLine("Quelle est la température que vous voulez mettre en Fahrenheit?");

                    celsius = Console.ReadLine();
                    tempEnCelsius = Convert.ToDouble(celsius);
                    tempEnFahrenheit = (tempEnCelsius * 9 / 5) + 32;
                    Console.WriteLine($"La température en Fahrenheit est: {tempEnFahrenheit}");
                    Console.ReadLine();
                     // Added break to exit the loop after successful conversion
                }
                else if (line.ToLower() == "f")
                {
                    Console.WriteLine("Bienvenue en mode Fahrenheit.");
                    Console.WriteLine("Quelle température que vous voulez mettre en Celsius?");

                    fahrenheit = Console.ReadLine();
                    tempEnFahrenheit = Convert.ToDouble(fahrenheit);
                    tempEnCelsius = (tempEnFahrenheit - 32) * 5 / 9;  // Corrected the formula
                    Console.WriteLine($"La température en Celsius: {tempEnCelsius}");
                    Console.ReadLine();
                    // Added break to exit the loop after successful conversion
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer C pour Celsius ou F pour Fahrenheit.");
                }
            }
        }
    }
}

