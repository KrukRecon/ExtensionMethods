using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods.Tests
{
    public class Tests
    {
        IEnumerable<string> _string;

        [SetUp]
        public void Setup()
        {
            _string = new List<string> { "a", "b", "c" };
        }

        [Test]
        public void Count()
        {
            Assert.AreEqual(3, _string.Count());

            var list = new StringList();
            Assert.AreEqual(0, list.Count());
        }
    }
}