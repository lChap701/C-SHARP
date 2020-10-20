using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCookieSource;

namespace TheCookieSourceTest
{
    /// <summary>
    /// Created 10/12/2020 by Lucas Chapman.
    /// This class was created to perform unit tests. 
    /// </summary>
    [TestClass]
    public class CookieSourceUnitTest
    {
        /// <summary>
        /// Tests the default constructor in the Order class
        /// </summary>
        [TestMethod]
        public void Test1()
        {
            Order ord = new Order();
            Assert.IsNotNull(ord); 
        }

        /// <summary>
        /// Tests the overloaded constructor
        /// </summary>
        [TestMethod]
        public void Test2()
        {
            Order ord = new Order("", "", ' ', 0, DateTime.Parse("01/01/2020"));
            Assert.IsNotNull(ord);
        }

        /// <summary>
        /// Tests the validation in the properties of the Order class
        /// </summary>
        [TestMethod]
        public void Test3()
        {
            /* 
             * Invalid data tests
             */
            Order ord = new Order("", "", ' ', -1, DateTime.Parse("01/01/2020"));

            // Checks if values were not accepted/changed
            Assert.AreNotEqual(0, ord.ordnum);
            Assert.AreNotEqual("", ord.Custname);
            Assert.AreNotEqual("", ord.Pnum);
            Assert.AreNotEqual(' ', ord.Ctype);
            Assert.AreNotEqual(-1, ord.Qty);
            Assert.AreNotEqual(DateTime.Parse("01/01/2020"), ord.orddate);
            Assert.AreNotEqual(DateTime.Parse("01/01/2020"), ord.Delivdate);

            // Sets new values
            ord.Pnum = "123";
            ord.Ctype = 'A';
            ord.Qty = -1;

            // Checks if values were not accepted/changed
            Assert.AreNotEqual("123 ", ord.Pnum);
            Assert.AreNotEqual('A', ord.Ctype);
            Assert.AreNotEqual(-1, ord.Qty);

            /*
             * Valid data tests
             */
            string tomorrow = DateTime.Now.AddDays(1).ToShortDateString();
            
            ord = new Order("John Smith", "(321) 321-4321", 'S', 1, DateTime.Parse(tomorrow));
            Assert.AreEqual(Order.curOrdnum, ord.ordnum); 
            Assert.AreEqual("John Smith", ord.Custname);
            Assert.AreEqual("(321) 321-4321", ord.Pnum);
            Assert.AreEqual('S', ord.Ctype);
            Assert.AreEqual(1, ord.Qty);
            Assert.AreEqual(DateTime.Now.Date, ord.orddate);
            Assert.AreEqual(DateTime.Parse(tomorrow), ord.Delivdate);

            // Sets new values
            ord.Ctype = 'O';
            ord.Delivdate = DateTime.Parse(DateTime.Now.ToShortDateString());

            // Tests these values
            Assert.AreEqual('O', ord.Ctype);
            Assert.AreEqual(DateTime.Parse(DateTime.Now.ToShortDateString()), ord.Delivdate);

            // Sets another new value
            ord.Ctype = 'C';

            // And tests it
            Assert.AreEqual('C', ord.Ctype);
        }

        /// <summary>
        /// Tests the serailization and deserialization of Order objects
        /// </summary>
        [TestMethod]
        public void Test4()
        {
            Order ord = new Order();
            MemoryStream mem = new MemoryStream();
            BinaryFormatter b = new BinaryFormatter();
            try
            {
                // Serialization test
                b.Serialize(mem, ord);  // calls the GetObjectData() method in the Order class
                
                // Deserialization test
                mem.Position = 0;   // restarts the stream
                Order deser = (Order)b.Deserialize(mem);    // calls the deserialization Order() constructor
                Assert.AreEqual(ord.ordnum, deser.ordnum);
                Assert.AreEqual(ord.Custname, deser.Custname);
                Assert.AreEqual(ord.Pnum, deser.Pnum);
                Assert.AreEqual(ord.Ctype, deser.Ctype);
                Assert.AreEqual(ord.Qty, deser.Qty);
                Assert.AreEqual(ord.orddate, deser.orddate);
                Assert.AreEqual(ord.Delivdate, deser.Delivdate);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Tests the CompareTo() method in the Order class
        /// </summary>
        [TestMethod]
        public void Test5()
        {
            List<Order> ordList = new List<Order>(3);
            // First Order object
            Order ord1 = new Order();
            ordList.Add(ord1);

            // Second Order object
            Order ord2 = new Order
            {
                Delivdate = DateTime.Parse(DateTime.Now.ToShortDateString())
            };
            ordList.Add(ord2);

            // Third Order object
            Order ord3 = new Order();
            ordList.Add(ord3);

            int result1 = ordList[0].CompareTo(ordList[1]);
            int result2 = ordList[1].CompareTo(ordList[2]);
            int result3 = ordList[2].CompareTo(ordList[0]);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(-1, result2);
            Assert.AreEqual(0, result3);
        }
    }
}
