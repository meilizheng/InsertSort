using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace InsertSort_MeiliZheng
{
    public class Program
    {
        //declare variables
        static Random rand = new Random();
        static int arrSize = 10;
        static int minNum = 1;
        static int maxNum = 101;
        
        static void Main(string[] args)
        {
            //Call InsertSort Method with Random Array
            InsertSort(RandomArray());
        }

        //Created a Random Array
        static int[] RandomArray()
        {
            // Comment for input validation
            // Check if the array size is less than 0 or if minNum is greater than maxNum
            if (arrSize < 0 || minNum > maxNum)
            {
                    throw new ArgumentException("Invalid arguments");
            }

            // Create a new int array with arrSize that declared in global scope
            int[] array = new int[arrSize];

            // Use a for loop to assign random values to each index
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minNum, maxNum);
            }

            Console.WriteLine("Unsorted Random Array:");

            // Use foreach loop to display each index value

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            
            //return array
            return array;
        }


        //Create a InsertSort method use it to sort the random array
        static void InsertSort(int[] array)
        {
            //use for loop to check each index if it need swap, start from the second number index 1
            for (int i = 1; array.Length > i; i++)
            {
               // Initialize j to represent the number before the current index i
                int j = i - 1;

                // If j is greater than or equal to zero and the value at index j is greater than the current index's value, swap them, until all the number sorted
                while (j >= 0 && array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                    j--; 
                }                           
            }

            Console.WriteLine("Sorted Random Array:");

            //use foreach to display each index value in the array

            foreach (int i in array)
            {             
                Console.WriteLine(i);
            }
        }
    }
}



//pseudo-code for insert sort

//// Declare variables
//Random rand = new Random();
//int arrSize = 10;
//int minNum = 1;
//int maxNum = 101;

//// Main method
//    // Call InsertSort Method with Random Array
//    InsertSort(RandomArray());


//// Create a Random Array
//int[] RandomArray()
//{
//    // Check if the array size is less than 0 or if minNum is greater than maxNum
//    if (arrSize < 0 || minNum > maxNum)
//    {
//        throw new ArgumentException("Invalid arguments");
//    }

//    // Create a new int array with arrSize that declared in global scope
//    int[] array = new int[arrSize];

//    // Use a for loop to assign random values to each index
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = rand.Next(minNum, maxNum);
//    }

//    Console.WriteLine("Unsorted Random Array:");

//    // Use foreach loop to display each index value
//    foreach (int i in array)
//    {
//        Console.WriteLine(i);
//    }

//    // Return array
//    return array;
//}

//// Create an InsertSort method and use it to sort the random array
//    // Use for loop to check each index if it needs swap, start from the second number index 1
//    for (int i = 1; array.Length > i; i++)
//    {
//        // Initialize j to represent the number before the current index i
//        int j = i - 1;

//        // If j is greater than or equal to zero and the value at index j is greater than the current index's value, swap them, until all the numbers are sorted
//        while (j >= 0 && array[j] > array[j + 1])
//        {
//            int temp = array[j];
//            array[j] = array[j + 1];
//            array[j + 1] = temp;
//            j--;
//        }
//    }

//    Console.WriteLine("Sorted Random Array:");

//    // Use foreach to display each index value in the array
//    foreach (int i in array)
//    {
//        Console.WriteLine(i);
//    }
//}
