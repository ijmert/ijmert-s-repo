using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.Attach(currentConditionsDisplay);
            weatherData.Attach(statisticsDisplay);
            weatherData.Attach(forecastDisplay);

            weatherData.SetMeasurements(26, 65, 30.4);
            Console.WriteLine();
            weatherData.SetMeasurements(28, 70, 29.2);
            Console.WriteLine();

            weatherData.Detach(currentConditionsDisplay);

            weatherData.SetMeasurements(24, 90, 29.2);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
