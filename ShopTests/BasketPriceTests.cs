using Shop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products1;
using System.Collections.Generic;

namespace Shop.Tests
{
    [TestClass()]
    public class BasketPriceTests
    {
        [TestMethod()]
        public void PrintProductPriceTest()
        {
            Assert.IsTrue(new BasketPrice("Output 1").PrintProductPrice(Parsing.LineToProductParsing("1 music CD at 14.99")).Contains("16.49"));
            Assert.IsTrue(new BasketPrice("Output 1").PrintProductPrice(Parsing.LineToProductParsing("1 music CD at 14.99")).Contains("1 music CD"));
        }

        [TestMethod()]
        public void PrintReceiptTest()
        {
            BasketPrice test = new BasketPrice("Output 1");
            List<IProduct> testProd = new List<IProduct>();
            testProd.Add(Parsing.LineToProductParsing("1 imported box of chocolates at 10.00"));
            testProd.Add(Parsing.LineToProductParsing("1 imported bottle of perfume at 47.50"));
            test.PrintReceipt(testProd);
            Assert.AreEqual(test.tax, 7.65);
            Assert.AreEqual(test.sum, 65.15);

        }
    }
}