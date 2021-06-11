using System;
using System.Collections.Generic;

namespace Lesson1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public List<WeatherForecast> database { get; set; }

        public WeatherForecast(DateTime date, int TempC, string sum)
        {
            Date = date;
            TemperatureC = TempC;
            Summary = sum;

        }

        public void Add(DateTime date, int Tc, string sum)
        {
            database.Add(new WeatherForecast(date, Tc, sum));
        }

        public void Update(DateTime date, int Tc)
        {
            database.Find(x => x.Date == date).TemperatureC = Tc;

        }

        public void Delete(DateTime date1, DateTime date2)
        {
            database.RemoveAll(x => x.Date >= date1 && x.Date <= date2);
        }

        public override string ToString()
        {
            return $"\n{Date} {TemperatureC} {TemperatureF} {Summary}";
        }
    }


}
