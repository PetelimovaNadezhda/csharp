using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products1.Tests
{
    [TestClass()]
    public class TaxTests
    {
        [TestMethod()]
        public void CostTest()
        {
            Assert.AreEqual(new Tax().Cost(Parsing.LineToProductParsing("1 music CD at 14.99")), 1.5);
        }
    }
}