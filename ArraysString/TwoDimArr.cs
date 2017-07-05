using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysString
{
    class TwoDimArr
    {
        public void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + ", ");
                }
                Console.WriteLine();
            }
        }
        public void InsertLineAfterMinElem(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        
                    }
                }
               
            }
        }
    }
}
