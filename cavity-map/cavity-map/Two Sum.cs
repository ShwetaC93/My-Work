using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given an array of integers, return indices of the two numbers such that they add up to a specific target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Given nums = [2, 7, 11, 15], target = 9,

//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].
namespace cavity_map
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0;
            int j = 1;
            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                        return new int[] { i, j };
                }
            }
            return new int[] { i, j };
        }
    }
}
