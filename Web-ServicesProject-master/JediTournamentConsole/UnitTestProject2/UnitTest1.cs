using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject2.ServiceReference1;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceReference1.Service1Client client = new Service1Client();
            List<JediWS> jedis = client.GetJediList();

        }
    }
}
