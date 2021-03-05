using NUnit.Framework;
using System;

namespace NunitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Type.GetType("MongoDB.Driver.MongoServer, MongoDB.Driver.Legacy");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}