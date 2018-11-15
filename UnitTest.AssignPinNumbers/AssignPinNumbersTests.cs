using System.Linq;
using AssignPinNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.AssignPinNumbers
{
    [TestClass]
    public class AssignPinNumbersTests
    {
        [TestMethod]
        public void NumbersAreNotIn4DigitsAreNotPinNumberTest()
        {
            Assert.IsFalse(PinNumberHelper.IsPinNumber(542), "542 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(10532), "10532 should not be a pin number");
        }

        [TestMethod]
        public void IncrementingNumbersAreNotPinNumberTest()
        {
            Assert.IsFalse(PinNumberHelper.IsPinNumber(1234), "1234 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(1248), "1248 should not be a pin number");
        }

        [TestMethod]
        public void Repeated4DigitsAreNotPinNumberTest()
        {
            Assert.IsFalse(PinNumberHelper.IsPinNumber(8888), "8888 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(1111), "1111 should not be a pin number");
        }

        [TestMethod]
        public void Repeated3DigitsAreNotPinNumberTest()
        {
            Assert.IsFalse(PinNumberHelper.IsPinNumber(8881), "8881 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(1121), "1121 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(4344), "4344 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(7333), "7333 should not be a pin number");
        }

        [TestMethod]
        public void Repeated2DigitsAreNotPinNumberTest()
        {
            Assert.IsFalse(PinNumberHelper.IsPinNumber(8863), "8863 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(8284), "8284 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(4824), "4824 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(5330), "5330 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(6121), "6121 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(4100), "4100 should not be a pin number");

            Assert.IsFalse(PinNumberHelper.IsPinNumber(3322), "3322 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(2323), "2323 should not be a pin number");
            Assert.IsFalse(PinNumberHelper.IsPinNumber(4554), "4554 should not be a pin number");
        }

        [TestMethod]
        public void PinNumbersWillPassPinNumberTest()
        {
            Assert.IsTrue(PinNumberHelper.IsPinNumber(9876), "8863 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(7634), "7634 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(8364), "8364 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(8463), "8463 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(5204), "5204 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(5013), "5013 should be a pin number");

            Assert.IsTrue(PinNumberHelper.IsPinNumber(3864), "3864 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(3846), "3846 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4836), "4836 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4863), "4863 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(6843), "6843 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(6834), "6834 should be a pin number");

            Assert.IsTrue(PinNumberHelper.IsPinNumber(3264), "3264 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(2364), "2364 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4263), "4263 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4362), "4362 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(2463), "2463 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(3462), "3462 should be a pin number");
            
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4326), "4326 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(4236), "4236 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(1536), "1536 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(1203), "1203 should be a pin number");
            Assert.IsTrue(PinNumberHelper.IsPinNumber(1023), "1023 should be a pin number");
        }

        [TestMethod]
        public void GetNumberListReturnsCorrectCountOfNumbers()
        {
            Assert.AreEqual(1000, PinNumberHelper.GetPinNumberList(1000).Count, "GetPinNumberList not returning 1000 numbers");
        }

        [TestMethod]
        public void GetNumberListReturnsUniqueNumbers()
        {
            Assert.AreEqual(1000, PinNumberHelper.GetPinNumberList(1000).Distinct().Count(), "GetPinNumberList not returning unique numbers");
        }
    }
}
