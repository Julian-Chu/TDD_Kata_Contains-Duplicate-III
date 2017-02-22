using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Kata_Contains_Duplicate_III
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContainsNearbyAlmostDuplicate_Given_kIsZero_Return_false()
        {
            //Assign
            int[] nums = {1,2 };
            int t = 0;
            int k = 0;
            //Act
            bool actual=Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_0_1_2_kIs3_tIs0_Return_false()
        {
            //Assign
            int[] nums = { 0, 1, 2 };
            int t = 0;
            int k = 3;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsFalse(actual);
        }
    }

    internal class Solutions
    {
        internal static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (k == 0) return false;
            throw new NotImplementedException();
        }
    }
}
