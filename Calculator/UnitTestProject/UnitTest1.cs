using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using CalcClassBr;
using System.Linq;
using System.Data.SqlClient;
using AnalaizerClassLibrary;
using System.Linq.Expressions;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {



        public TestContext TestContext { get; set; }

        [DataSource("System.Data.SqlClient", "Server = .\\SQLEXPRESS;Integrated Security = True;Database = MultTest", "multtest", DataAccessMethod.Sequential)]


        [TestMethod]
        public void MultTest()
        {

            int a = (int)TestContext.DataRow["a"];
            int b = (int)TestContext.DataRow["b"];

            int result = (int)TestContext.DataRow["result"];

            Assert.AreEqual(CalcClass.Mult(a, b), result);

        }



        [DataSource("System.Data.SqlClient", "Server = .\\SQLEXPRESS;Integrated Security = True;Database = MultTest", "baddata2", DataAccessMethod.Sequential)]



        [TestMethod]
       [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MultTest2()
        {

            long a = (long)TestContext.DataRow["a"];
            long b = (long)TestContext.DataRow["b"];
            
            int result = CalcClass.Mult(a, b);

            //Assert.AreEqual(CalcClass.Mult(a, b), result);

        }

    }
}



