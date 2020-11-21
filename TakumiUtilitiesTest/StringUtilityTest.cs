using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakumiUtilities;

namespace TakumiUtilitiesTest
{
    [TestClass]
    public class StringUtilityTest
    {
        [TestMethod]
        public void NullStringTest()
        {
            var stringUtility = new StringUtility("aiueo");
            bool isTruePtn = stringUtility.StartWith("aiu");

            Assert.AreEqual(true,isTruePtn);
        }

        
        [TestMethod]
        public void SplitExPtn1()
        {
            var validateTarget = @"Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†
Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å°
Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†
Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å†Å°";
            var temp = new StringUtility(validateTarget);
            var ret = temp.SplitEx(5, "\r\n");

            var reJoin = string.Join("", ret);
            var len1 = validateTarget.Replace("\r\n", "").Length;
            var len2 = reJoin.Length;
            Assert.AreEqual(true,  len1 == len2);
        }
    }
}
