using NUnit.Framework;
using Old_Phone_Challange;

namespace OldKeyPadUnitTest
{
    [TestFixture]
    public class Tests
    {
        private IOldPhoneKeyPad _oldPhoneKey;
        [SetUp]
        public void Setup()
        {
            _oldPhoneKey = new OldPhoneKeyPad();
        }

        [TestCase("#")]
        [TestCase("")]
        [TestCase("*7*#")]
        [TestCase("7*#")]
        [TestCase("*#")]
        [TestCase("****#")]
        [TestCase("7*8 8 9***#")]
        [TestCase("*7*8 8 9****")]
        [TestCase(" #")]
        public void ReturnEmptyString(string inputKey)
        {
            string output = _oldPhoneKey.GetOldPhoneKeys(inputKey);
            Assert.AreEqual(output,"");
        }
        [TestCase("8 88777444666* 664#")]
        [TestCase("8 887774446667**664#")]
        public void ReturnTuring(string inputKey)
        {
            string output = _oldPhoneKey.GetOldPhoneKeys(inputKey);
            Assert.AreEqual(output, "TURING");
        }

        [TestCase("4444666666 6666663#")]
        [TestCase("4666 666*6663#")]
        public void KeyPressMoreThanThreeTime(string inputKey)
        {
            string output = _oldPhoneKey.GetOldPhoneKeys(inputKey);
            Assert.AreEqual(output, "GOOD");
        }

        [TestCase("4433 33 33 33***555*555 555 666#")]
        [TestCase("4433555 55 66*****4433555 555 666#")]
        public void MultipleBackSpaceInSequence(string inputKey)
        {
            string output = _oldPhoneKey.GetOldPhoneKeys(inputKey);
            Assert.AreEqual(output, "HELLO");
        }
    }
}