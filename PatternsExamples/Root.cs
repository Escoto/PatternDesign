using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecouplingBehaviors;
using ObserverExample;
using MyGenerics;

namespace PatternsExamples
{
    public class Root
    {
        enum Patterns { Strategy, Observer };
        public static void Main() {

            Patterns toPractice = Patterns.Strategy;

            switch (toPractice) {
                case Patterns.Strategy: run(new MiniDuckSimulator()); break;
                case Patterns.Observer: run(new WeatherMonitoring()); break;
            }

            Console.ReadLine();
        }

        public static void run(IInitialStep obj) => obj.Start();
    }
}
