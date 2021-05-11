using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    public class StatisticsDisplay : Observer
    {
        public StatisticsDisplay(WeatherData weatherData) 
        {
            WeatherData = weatherData;
            Temperatures = new List<int>();
        }

        public WeatherData WeatherData { get; set; }
        public List<int> Temperatures { get; set; }
        public void update()
        {
            Temperatures.Add(WeatherData.Temperatuur);
            int totaal = 0;
            int maximum = -273;
            int minimum = 1000;
            foreach (int i in Temperatures) 
            {
                totaal += i;
                if (i > maximum) 
                {
                    maximum = i;
                }
                if (i < minimum) 
                {
                    minimum = i;
                }
            }
            int gemiddelde = totaal / Temperatures.Count();
            Console.WriteLine($"Gem/Max/Min temp = {gemiddelde}/{maximum}/{minimum}");
        }
    }
}
