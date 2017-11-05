using System;
using MyGenerics;
using DecouplingBehaviors;
using ObserverExample;
using DecoratorExample;
using FactoryExample;
using SingletonExample;
using CommandExample;

namespace PatternsExamples
{
    public class Root
    {
        enum Patterns { Strategy, Observer, Decorator, Factory, Singleton, Command };

        public static void Main() {

            Patterns toPractice = Patterns.Command;

            switch (toPractice) {
                case Patterns.Strategy:  run( new MiniDuckSimulator() );  break;
                case Patterns.Observer:  run( new WeatherMonitoring() );  break;
                case Patterns.Decorator: run( new StarbuzzCoffee() );     break;
                case Patterns.Factory:   run( new OrderPizza() );         break;
                case Patterns.Singleton: run( new Choc_O_Holic() );       break;
                case Patterns.Command:   run( new RemoteControl() );      break;

            }

            Console.ReadLine();
        }

        public static void run(IInitialStep pattern) => pattern.Start();
    }
}
