﻿using System;
using NUnit.Framework;

namespace UTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestCompareOne()
        {
            int x = 5;
            int y = 5;
            Assert.AreEqual(x, y);
        }

        [Test]
        public void TestCompareTwo()
        {
            int x = 5;
            int y = 5;
            Assert.AreEqual(x, y);
        }
    }
}
