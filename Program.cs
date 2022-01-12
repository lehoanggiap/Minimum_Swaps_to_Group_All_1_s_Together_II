using System;

namespace Minimum_Swaps_to_Group_All_1_s_Together_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 0, 0, 1 };
            Console.WriteLine(MinSwaps(nums));
            Console.ReadLine();
        }

        public static int MinSwaps(int[] nums) {
            int ones = 0, count = 0, onesInWindow = 0, i = 0, n = nums.Length;
            foreach (int v in nums)
                if (v == 1) ones++;
            int[] nums2 = new int[n * 2];
            for (i = 0; i < n * 2; i++)
                nums2[i] = nums[i % n];

            for (i = 0; i < ones; i++)
            {
                if(nums2[i] == 1)
                {
                    count++;
                }
            }
            onesInWindow = count;
            for (i = ones; i < n*2; i++)
            {
                if(nums2[i - ones] == 1)
                {
                    count--; 
                }
                if(nums2[i] == 1)
                {
                    count++;
                }
                onesInWindow = Math.Max(count, onesInWindow);
            }

            //for(i = 0; i < n*2; i++){
                //if(i >= ones && nums2[i - ones] == 1) count--;
                //if(nums[i] == 1) count++;
                //onesInWindow = Math.Max(count, onesInWindow);
            //} this is the shorter way of writting code I read on leetcode, but the complexity is still O(n)
            return ones - onesInWindow;
    }
        
    }
}
