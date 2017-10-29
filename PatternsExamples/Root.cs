using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;
using DecouplingBehaviors;
using ObserverExample;
using DecoratorExample;

namespace PatternsExamples
{
    public class Root
    {
        enum Patterns { Strategy, Observer, Decorator };

        public static void Main() {

            Patterns toPractice = Patterns.Decorator;

            switch (toPractice) {
                case Patterns.Strategy:  run(new MiniDuckSimulator());  break;
                case Patterns.Observer:  run(new WeatherMonitoring());  break;
                case Patterns.Decorator: run(new StarbuzzCoffee());     break;
            }

            Console.ReadLine();
        }

        public static void run(IInitialStep pattern) => pattern.Start();
    }
}
