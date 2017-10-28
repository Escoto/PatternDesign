using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temp, humidity, pressure;
        public WeatherData() {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
            => observers.Add(o);

        public void RemoveObserver(IObserver o)
            => observers.Remove(o);

        public void NotifyObservers()
            => observers.ForEach(o => o.Update(temp, humidity, pressure));

        public void MeasurementsChanged() 
            => NotifyObservers();

        public void SetMeasurements(float temp, float humidity, float pressure) {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
