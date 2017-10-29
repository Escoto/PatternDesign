using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;
using System.Threading;
namespace ObserverExample
{
    public class WeatherMonitoring : IInitialStep
    {
        //Observer
        CurrentConditionsDisplay currentDisplay;
        
        //Subject
        WeatherData weatherData;

        public void Start() {
            
            weatherData = new WeatherData();
            
            currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            //Every time weather data changes, our display is updated
            weatherData.SetMeasurements(80, 65, 30.4f);
            Thread.Sleep(2000);
            weatherData.SetMeasurements(75, 62, 29.0f);
            Thread.Sleep(2000);
            weatherData.SetMeasurements(65, 60, 27.2f);
            Thread.Sleep(2000);
            weatherData.SetMeasurements(50, 62, 26.2f);
        }
    }
}
