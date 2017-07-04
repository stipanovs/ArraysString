﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArraysString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = {5, 8, 9, 10, 11, 40, 43};
            //DeleteEven(ref arr);
            InsertElemBeginDigit(ref arr, 777, 11);
            PrintArray(arr);
            
            

            
            Console.ReadKey();
        }
        

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Write(i + ", ");
            }
        }

        // 1
        public static void DeleteEven(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    for (int a = i; a < arr.Length-1; a++)
                    {
                        arr[a] = arr[a + 1];

                    }
                    Array.Resize(ref arr, arr.Length-1);
                }
            }
        }

        // 2
        public static void InsertElemBeginDigit(ref int[] arr, int elem, int digit)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == digit)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    
                    for (int j = arr.Length-1 ; j > i+1; j--)
                    {
                        arr[j] = arr[j-1];

                    }
                    arr[i+1] = elem;
                  
                }
            }
        }

        // 3
        public static void DeleteRepeatElem(ref int[] arr)
        {
            int find = arr[0];
            bool first = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == find & !first)
                {
                    first = true;
                }
                else if(arr[i] == find & first)
                { 
                    for (int a = i; a < arr.Length - 1; a++)
                    {
                        arr[a] = arr[a + 1];

                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }

        }
    }
}
