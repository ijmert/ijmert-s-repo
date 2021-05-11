using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    public class ForecastDisplay : Observer
    {
        private double previousLuchtDruk = 0;

        public WeatherData WeatherData { get; set; }

        public ForecastDisplay(WeatherData weatherData) 
        {
            WeatherData = weatherData;
        }
        public void update()
        {
            string response = "";
            double luchtDrukNu = WeatherData.LuchtDruk;
            if (luchtDrukNu > previousLuchtDruk)
            {
                response = "gaat warmer worden";
            }
            else if (luchtDrukNu < previousLuchtDruk)
            {
                response = "gaat kouder worden";
            }
            else
            {
                response = "meer van hetzelfde mijn dude";
            }
            Console.WriteLine(response);
            previousLuchtDruk = luchtDrukNu;
            
        }
    }
}
