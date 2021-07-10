using System;
using System.Collections.Generic;
using System.Linq;

namespace interviewPracticeCSharp
{
    class MainClass
    {
        // 1 2 3 4 5    
        // 1 2 3 5 4   1 move
        // 1 2 5 3 4   2 move

        // 2 1 5 3 4   3 move
        //-1 2 3 4 5
        //=1 -1 2 -1 -1

        // 1 + 2 = 3

        // 1 2 3 5 4
        //-1 2 3 4 5
        // 0 0 0 1 -1 



        // 1 2 3 4 5    
        // 1 2 3 5 4   1 move
        // 1 3 2 5 4   2 move


        // 3 1 2 5 4   3 move

        // 1 2 5  3 7 8  6  4
        //-1 2 3  4 5 6  7  8
        //=0 0 2 -1 2 2 -1 -4




        //new year chaos problem **not optimized
        static void minimumBribes(int[] q)
        {
            int moves = 0;
            var length = q.Length;

            for (int k = length - 1; k >= 0; k--)
            {
                if (q[k] - k > 3)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                for (int j = k; j <= length - 1; j++)
                {
                    if (q[k] > q[j])
                    {
                        moves++;
                    }
                }
            }
            Console.WriteLine(moves);
        }









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
        static void Main(string[] args)
        {
            /*int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            } */

            for (int i = 5; i >= 0; i--)
            {
                for (int j = Math.Max(0, i - 2); j < i; j++)
                {
                    Console.WriteLine(j);
                }
                 
            }
            return;
        }
    }
}

