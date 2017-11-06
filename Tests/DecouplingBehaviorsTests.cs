using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecouplingBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGenerics;

namespace DecouplingBehaviors.Tests
{
    [TestClass()]
    public class DecouplingBehaviorsTests
    {
        [TestMethod()]
        public void MiniDuckSimulator_can_be_instantiated() {
            Assert.AreNotEqual(new MiniDuckSimulator(), null);
            Assert.IsInstanceOfType(new MiniDuckSimulator(), typeof(IInitialStep));
        }

        //bool x = typeof(IInitialStep).IsAssignableFrom(typeof(MiniDuckSimulator));
        //Assert.AreEqual(x, true);
    }
}