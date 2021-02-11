using ChallengeOne;
using NUnit.Framework;

namespace ChallengeTwo
{
    public class GeorgOhmValueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFourStripGeorgOhmValue()
        {
            string[] bandColors = { "Black", "Red", "Orange", "Gold" };
            GeorgOhm georgOhm = GeorgOhmFactory.CreateStripGeorgOhm(bandColors);
            if (georgOhm != null)
            {
                Assert.AreEqual(georgOhm.CalculateOhmValue(bandColors), "2000 ±5%");
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestFiveStripGeorgOhmValue()
        {
            string[] bandColors = { "Green", "Blue", "Black", "Black", "Brown" };
            GeorgOhm georgOhm = GeorgOhmFactory.CreateStripGeorgOhm(bandColors);
            if (georgOhm != null)
            {
                Assert.AreEqual(georgOhm.CalculateOhmValue(bandColors), "560 ±1%");
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestSixStripGeorgOhmValue()
        {
            string[] bandColors = { "Green", "Green", "Blue", "Red", "Silver", "Brown" };
            GeorgOhm georgOhm = GeorgOhmFactory.CreateStripGeorgOhm(bandColors);
            if (georgOhm != null)
            {
                Assert.AreEqual(georgOhm.CalculateOhmValue(bandColors), "55600 ±10% 100");
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}