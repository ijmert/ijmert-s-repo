using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observerOefeningConsole
{
    public class WeatherData:Subject
    {
        public WeatherData() 
        {
            Observers = new List<Observer>();
        }
        

        private int temperatuur;

        public int Temperatuur
        {
            get { return temperatuur; }
            set { temperatuur = value; }
        }
        private int luchtvochtigheid;

        public int Luchtvochtigheid
        {
            get { return luchtvochtigheid; }
            set { luchtvochtigheid = value; }
        }

        private double luchtDruk;

        public double LuchtDruk
        {
            get { return luchtDruk; }
            set { luchtDruk = value; }
        }



        public void SetMeasurements(int graden, int incluchtvochtigheid, double inputLuchtDruk) 
        {
            LuchtDruk = inputLuchtDruk;
            Temperatuur = graden;
            Luchtvochtigheid = incluchtvochtigheid;
            Notify();
        }
    }
}
