using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sonar_csharp.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassToTest classToTest = new ClassToTest();
            int result = classToTest.addNumbers(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
