using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class GameTest
    {
        MyRRgame.MyClass run = new MyRRgame.MyClass();
        [TestMethod]
        public void TestMethod1()
        {

            int Result = run.SpinGun();

            Assert.IsTrue(Result < 7);


        }
        public void TestMethod2()
        {

            int Result2 = run.FireGun();

            Assert.IsTrue(Result2 > 0);


        }
    }
}
