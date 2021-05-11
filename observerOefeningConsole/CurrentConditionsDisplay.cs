using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    public class CurrentConditionsDisplay : Observer
    {
        public CurrentConditionsDisplay(WeatherData weatherData) 
        {
            WeatherData = weatherData;
        }

        public int Temperatuur { get; set; }

        public int LuchtVochtigheid { get; set; }

        private WeatherData WeatherData { get; set; }
        public void update()
        {
            Temperatuur = WeatherData.Temperatuur;
            LuchtVochtigheid = WeatherData.Luchtvochtigheid;
            Console.WriteLine("Actuele weersgesteldheid: " + Temperatuur + "graden celsius en " + LuchtVochtigheid + "% luchtvochtigheid.");
        }
    }
}
