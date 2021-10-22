using System;
using System.Collections.Generic;
using DataGridViewWithBooksAndAuthors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcTotalMethod()
        {
            Author a = new Author("12345", "Joe Smith", new List<Book>());
            a.AuthBooks.Add(new Book("Hippies", 500, 30));
            a.AuthBooks.Add(new Book("Gypsies", 600, 25));

            Assert.AreEqual(56, a.CalcTotal());
        }
    }
}
