using System;
using MyGenerics;
using DecouplingBehaviors;
using ObserverExample;
using DecoratorExample;
using FactoryExample;
using SingletonExample;
namespace PatternsExamples
{
    public class Root
    {
        enum Patterns { Strategy, Observer, Decorator, Factory, Singleton };

        public static void Main() {

            Patterns toPractice = Patterns.Singleton;

            switch (toPractice) {
                case Patterns.Strategy:  run( new MiniDuckSimulator() );  break;
                case Patterns.Observer:  run( new WeatherMonitoring() );  break;
                case Patterns.Decorator: run( new StarbuzzCoffee() );     break;
                case Patterns.Factory:   run( new OrderPizza() );         break;
                case Patterns.Singleton: run( new Choc_O_Holic());        break;

            }

            Console.ReadLine();
        }

        public static void run(IInitialStep pattern) => pattern.Start();
    }
}
