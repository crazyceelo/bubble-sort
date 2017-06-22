using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,5,1,2,3,45,56};
            ArrayBubbleSortAscending(nums);
            Console.WriteLine("================");
            ArrayBubbleSortDescending(nums);
        }

        /// <summary>
        /// Sorts integers in a descending order
        /// </summary>
        /// <param name="nums"></param>
        private static void ArrayBubbleSortDescending(int[] nums)
        {
            // prints unsorted array
            Console.WriteLine("Unsorted array is: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            int length = nums.Length;
            // sorts the array
            // 2,5,1,2,3,45,56
            for (int i = 0; i < length - 1; i++) // this loops from left to right and stops at the 2nd to last index.
            {
                for (int j = 0; j < length - 1 -i; j++) // what happens here.
                {
                    if (nums[j] < nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array: ");
            foreach (int numbers in nums)
            {
                Console.WriteLine(numbers + "");
            }

        }

        /// <summary>
        /// Sorts integers in an ascending order.
        /// </summary>
        /// <param name="nums"></param>
        private static void ArrayBubbleSortAscending(int[] nums)
        {
            // prints the unsorted array
            Console.WriteLine("UnSorted Array is: ");
            // loops through each index from 0 to 6 and prints them.
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            // sorts the array
            // i is equal to the length of array minus 1. [2,5,1,2,3,45,56] starts at index 45 and starts comparring.
            for (int i = nums.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i-1; j++) // dont know what goes on here. loops to the left or the right. not sure
                {
                    if (nums[j] > nums[j+1]) // if index previous is > index next.
                    {
                        int highValue = nums[j]; // index previous store in a temp variable

                        nums[j] = nums[j + 1]; // index next move to previous position
                        nums[j + 1] = highValue; // place the previous temp number in the higher position
                    }
                }
            }

            // prints the sorted array
            Console.WriteLine("the sorted array is: " );
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
