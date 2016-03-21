using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculatrice.Tests
{
    [TestFixture]
    public class CalculatriceTests
    {
        [Test]
        public void AdditionTest()
        {
            Calculatrice c = new Calculatrice();
            Assert.AreEqual(2, c.Addition(1, 1));

        }
    }
}
