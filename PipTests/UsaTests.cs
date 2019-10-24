using Boundaries;
using Boundaries.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PipTests
{
    [TestClass]
    public class UsaTests
    {
        [TestMethod]
        public void InMichiganTests()
        {
            //42.0809574,-86.4861351
            var michigan = new Coordinate(42.0809574D, -86.4861351D);
            var result1 = Usa.Michigan.IsInside(michigan);
            var result2 = Usa.GetState(michigan);

            Assert.AreEqual(true, result1);
            Assert.AreEqual("Michigan", result2);
        }
    }
}
