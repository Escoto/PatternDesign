using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandExample;
using MyGenerics;

namespace Tests
{
    [TestClass]
    public class CommandExampleTests
    {
        [TestMethod()]
        public void RemoteControl_can_be_instantiated() {
            Assert.AreNotEqual(new RemoteControl(), null);
            Assert.IsInstanceOfType(new RemoteControl(), typeof(IInitialStep));
        }
    }
}
