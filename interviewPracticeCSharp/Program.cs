using System;
using System.Collections.Generic;

namespace interviewPracticeCSharp
{
    class MainClass
    {

        /* QUESTION: A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become .

 Given an array  of  integers and a number, , perform  left rotations on the array. Return the updated array to be printed as a single line of space-separated integers.*/


        //First attempt solution, will should be able to optimize further
        static int[] rotLeft(int[] a, int d)
        {

            var rtnArray = new int[a.Length];
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + d) >= a.Length)
                {
                    rtnArray[i] = a[counter];
                    counter++;
                }
                else
                {
                    rtnArray[i] = a[i + d];
                }
            }

            return rtnArray;

        }


        //driver function
        public static void Main(string[] args)
        {
            int[] testArr = { 1, 2, 3, 4, 5};
            int rotations = 2;
            var testAnswer = rotLeft(testArr, rotations);

            Console.WriteLine("Original array: ");
            foreach (var y in testArr)
            {
                Console.Write(y + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("rotated array: ");
            foreach(var x in testAnswer)
            {
                Console.Write(x + " ");
            }

        }
    }
}

