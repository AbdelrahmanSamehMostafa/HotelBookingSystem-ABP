using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace BookingSystem.Models
{
    public class Current : ValueObject
    {
        public double TempC { get; }

        public double Humidity { get; }

        public double WindKph { get; }

        public Current(double tempC, double humidity, double windKph)
        {
            TempC = tempC;
            Humidity = humidity;
            WindKph = windKph;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return TempC;
            yield return Humidity;
            yield return WindKph;
        }
    }
}
