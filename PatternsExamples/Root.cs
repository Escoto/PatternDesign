using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;
using DecouplingBehaviors;
using ObserverExample;
using DecoratorExample;
using FactoryExample;

namespace PatternsExamples
{
    public class Root
    {
        enum Patterns { Strategy, Observer, Decorator, Factory };

        public static void Main() {

            Patterns toPractice = Patterns.Decorator;

            switch (toPractice) {
                case Patterns.Strategy:  run( new MiniDuckSimulator() );  break;
                case Patterns.Observer:  run( new WeatherMonitoring() );  break;
                case Patterns.Decorator: run( new StarbuzzCoffee() );     break;
                case Patterns.Factory:   run( new PizzaStore() );         break;
            }

            Console.ReadLine();
        }

        public static void run(IInitialStep pattern) => pattern.Start();
    }
}
