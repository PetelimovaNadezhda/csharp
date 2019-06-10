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
    public class ParsingTests
    {
        [TestMethod()]
        public void LineToProductParsingTest()
        {
            Products test = Parsing.LineToProductParsing("1 music CD at 14.99");
            Assert.AreEqual(test.price, 14.99);
            Assert.AreEqual(test.imported, false);
            Assert.AreEqual(test.medical, false);
            Assert.AreEqual(test.food, false);
            Assert.AreEqual(test.book, false);
            Assert.AreEqual(test.name, "1 music CD");
            Assert.AreEqual(test.count, 1);
        }
    }
}