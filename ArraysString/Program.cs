using System;
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
            // 1
            int[] arr = {5, 8, 9, 10, 11, 40, 43};
            //DeleteEven(ref arr);
            InsertElemBeginDigit(ref arr, 333, 9);
            PrintArray(arr);
            // 2
            

            
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

                    for (int a = i; a < arr.Length-1; a++)
                    {
                        arr[a + 1] = arr[a];

                    }
                    PrintArray(arr);
                    //arr[i + 1] = elem;
                  
                }
                i++;

            }
        }

        // 3
        public static void DeleteRepeatElem(ref int[] arr)
        {
            
        }
    }
}
