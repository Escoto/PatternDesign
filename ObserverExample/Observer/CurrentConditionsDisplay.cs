using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temp, humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData) {
            this.weatherData = weatherData;
            
            //Subscribe this observer to a subject
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure) {
            this.temp = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
            => Console.WriteLine($"Current conditions: {temp}F degrees and {humidity}% humidity");
    }
}
