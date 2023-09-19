using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
{
    internal class Meteo
    {
        public Meteo()
        {
            double tempEnCelsius;
            double tempEnFarhrenheit;
            string? celsius;

            Console.WriteLine("Bienvenu a mon programme de Météo");
            Console.WriteLine("Entez la temperature en Celsius : ");
            celsius = Console.ReadLine();
            tempEnCelsius = Convert.ToDouble(celsius);
            tempEnFarhrenheit = (tempEnCelsius * 9 / 5) + 32;
            Console.WriteLine($"La température en Fahrenheit: {tempEnFarhrenheit}");
        }

            
            
            
            
           

    }
}
