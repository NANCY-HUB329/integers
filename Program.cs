using System;
using System.Collections.Generic;
using System.Drawing;

public class ArrayChunkBreaker
{
    public static void Main(string[] args)
    {
        /*
         * 
         * Given an array and chunk size divide the array into subarrays where each subarray is of length is the chunk size. E.g. 
                //[1,2,3,3,4,5,6,7],3)  ===[ [ 1, 2, 3 ], [ 3, 4, 5 ], [ 6, 7 ] ] 
                //([1,2,3,5,6,7],1) ===[ [ 1 ], [ 2 ], [ 3 ], [ 5 ], [ 6 ], [ 7 ] ] 
         * 
         */

       
        static int[] breakArray(int[] array, int size)
        {
            int[] chunked_arr = [];
            for (int i = 0; i < array.Length; i++)
            {
                int last = chunked_arr[chunked_arr.Length - 1];
                if (last == null || last.length === size)
                {
                    chunked_arr.push([array[i]]);
                }
                else
                {
                    last.push(array[i]);
                }
            }
            return chunked_arr;
        }

    }
    }