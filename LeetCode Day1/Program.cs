namespace LeetCode_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****Two Sum*****\\
            //(Easy)
            /* Given an array of integers 'nums' and an interger 'target', return indices (index plural) of the two numbers such as they add up to target */

            int[] nums = {  11, 15, 5, 7 };

            int target = 12; 

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"Indices that add up to target: {i}, {j}");
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
