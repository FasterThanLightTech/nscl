using System;
using System.Text;
using System.Collections;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Org.Xwt.Nscl
{
    [TestClass]
    public class ELCacheUnitTest
    {
        public ELCacheUnitTest()
        {
        }

        [TestMethod]
        public void TestGetBoolean()
        {
            Assert.IsTrue(ELCache.Instance.GetBooleanValue(null,"1==1"));
        }

        [TestMethod]
        public void TestGetCollection()
        {
            ArrayList list = (ArrayList)ELCache.Instance.GetCollection(null, "{'a','b','c','d'}");
            Assert.AreEqual("a", list[0]);
            Assert.AreEqual("b", list[1]);
            Assert.AreEqual("c", list[2]);
            Assert.AreEqual("d", list[3]);
        }


    }
}
