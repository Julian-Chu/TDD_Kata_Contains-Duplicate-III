using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TDD_Kata_Contains_Duplicate_III
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ContainsNearbyAlmostDuplicate_Given_kIsZero_Return_false()
        {
            //Assign
            int[] nums = { 1, 2 };
            int t = 0;
            int k = 0;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);

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

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_0_1_1_kIs3_tIs0_Return_true()
        {
            //Assign
            int[] nums = { 0, 1, 1 };
            int t = 0;
            int k = 3;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_1_0_1_kIs1_tIs0_Return_false()
        {
            //Assign
            int[] nums = { 1, 0, 1 };
            int t = 0;
            int k = 1;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_1_0_1_kIs1_tIs1_Return_true()
        {
            //Assign
            int[] nums = { 1, 0, 1 };
            int t = 1;
            int k = 1;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_0_2_4_2_kIs2_tIs0_Return_true()
        {
            //Assign
            int[] nums = { 0, 2, 4, 2 };
            int t = 0;
            int k = 2;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_minus1_2147483647_kIs1_tIs2147483647_Return_false()
        {
            //Assign
            int[] nums = { -1, 2147483647 };
            int k = 1;
            int t = 2147483647;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContainsNearByAlmostDuplicate_Given_nums_2_1_kIs1_tIs1_Return_true()
        {
            //Assign
            int[] nums = { 2, 1 };
            int k = 1;
            int t = 1;
            //Act
            bool actual = Solutions.ContainsNearbyAlmostDuplicate(nums, k, t);
            //Assert
            Assert.IsTrue(actual);
        }
    }

    internal class Solutions
    {
        internal static bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (k > 0 && t >= 0)
            {
                Dictionary<long, long> dic = new Dictionary<long, long>();

                for (int i = 0; i < nums.Length; i++)
                {
                    long valueToAdd = Convert.ToInt64(nums[i]) - int.MinValue;
                    long keyToAdd = valueToAdd / ((long)t + 1);

                    if (i > k)
                    {
                        var valueToRemove = Convert.ToInt64(nums[i - k - 1]) - int.MinValue;
                        long keyToRemove = valueToRemove / ((long)t + 1);
                        dic.Remove(keyToRemove);
                    }

                    if (dic.ContainsKey(keyToAdd) ||
                          dic.ContainsKey(keyToAdd - 1) && Math.Abs(dic[keyToAdd - 1] - valueToAdd) <= t ||
                          dic.ContainsKey(keyToAdd + 1) && Math.Abs(dic[keyToAdd + 1] - valueToAdd) <= t
                         )
                    {
                        return true;
                    }
                    dic.Add(keyToAdd, valueToAdd);
                }
                return false;
            }
            else return false;
        }
    }
}