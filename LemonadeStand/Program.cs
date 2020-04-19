using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day = new Day();
            day.DaysForecast(1);
            day.DaysActualWeather();
        }
    }
}
