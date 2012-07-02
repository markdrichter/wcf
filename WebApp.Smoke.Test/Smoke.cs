using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApp.Smoke.Test
{
    [TestClass]
    public class Smoke
    {
        [TestMethod]
        public void TestMethod1()
        {
            var web = new WebClient();
            var stream = web.OpenRead("http://production");
            var result = new StreamReader(stream).ReadToEnd();
            Assert.IsTrue(result.Contains("ASP.NET MVC Website") && result.Contains("Home"));
        }
    }
}
