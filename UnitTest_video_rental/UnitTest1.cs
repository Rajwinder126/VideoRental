
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting_vedioRental;

namespace UnitTesting_vedioRental
{
    [TestClass]
    public class vedioRental_UnitTest
    {
        ClassDatabase Obj_Data = new ClassDatabase();

        //code is to check valid Test Case of connection String
        [TestMethod]
        public void Test_ConnectionSring()
        {
            string Connection = Obj_Data.ConnString;
            Assert.AreEqual(@"LAPTOP-37GT9VB1\SQLEXPRESS01;Initial Catalog=VideoRental;Integrated Security=True", Connection);
        }


        //code is to check valid Test Case of connection String
        [TestMethod]
        public void Test_deleteMovie()
        {
            string Message = Obj_Data.costumerDelete();
            Assert.AreEqual("costumer Details are filled properly", Message);
        }

        private class ClassDatabase
        {
            internal string ConnString;

            internal string costumerDelete()
            {
                throw new NotImplementedException();
            }
        }
    }
}


