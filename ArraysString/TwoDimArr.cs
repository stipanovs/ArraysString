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

        public int[,] AddRowIndPos(int[,] original, int rowIndex, int[] line)
        {
            int lastRow = original.GetLength(0);
            int lastColumn = original.GetLength(1);
            // Create new array.
            int[,] result = new int[lastRow + 1, lastColumn];
            // Copy existing array into the new array.
            for (int i = 0; i < lastRow; i++)
            {
                for (int x = 0; x < lastColumn; x++)
                {
                    result[i, x] = original[i, x];
                }
            }
            // 
            for (int j=result.GetLength(0)-1; j>rowIndex; j--)
            {
                for (int x = 0; x < result.GetLength(1); x++)
                {
                   result[j, x] = result[j-1, x];
                }
            }
            result[rowIndex, 0] = line[0];
            result[rowIndex, 1] = line[1];


            return result;
        }

        public int[,] InsertLineAfterMinElem(int[,] arr, int[] newLine )
        {
            int min = arr[0, 0];
            int positionRow = -1;
            // find min element
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            
            // find firt occurence of the min
            bool find = false;
            for (int x = 0; x < arr.GetLength(0); x++)
            {
                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[x, j] == min & !find)
                    {
                        positionRow = x;
                        find = true;
                        break;
                    }
                }
                
            }
            Console.WriteLine("min: {0}", min);
            Console.WriteLine("position: {0}", positionRow);

            return AddRowIndPos(arr, positionRow + 1, newLine);

        }
    }
}
