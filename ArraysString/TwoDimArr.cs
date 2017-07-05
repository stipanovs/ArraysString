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

        public int[,] AddColIndPos(int[,] original, int colIndex)
        {
            int lastRow = original.GetLength(0);
            int lastColumn = original.GetLength(1);
            int[,] result = new int[lastRow, lastColumn + 1];

            // Copy existing array into the new array.
            for (int i = 0; i < lastRow; i++)
            {
                for (int x = 0; x < lastColumn; x++)
                {
                    result[i, x] = original[i, x];
                }
            }
            // 
            for (int j = 0; j < lastRow; j++)
            {
                
                for (int x = result.GetLength(1)-1; x > colIndex; x--)
                {
                    result[j, x] = result[j, x-1];
                }
            }
            // coloana compleatata cu 0
            for (int i = 0; i < lastRow; i++)
            {
                result[i, colIndex] = 0;
         
            }
            
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
            
            // find first occurence of the min
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
            
            return AddRowIndPos(arr, positionRow + 1, newLine);

        }

        public int[,] InsertColBefNum(int[,] arr, int number)
        {
            
            int positionCol = 1000;
            //int[] positions = new int [arr.GetLength(1)];
            // find min element
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == number)
                    {
                        if (j < positionCol)
                        {
                            positionCol = j;
                        }
                        //positionCol = j;
                    }
                }
            }
            Console.WriteLine("positCol: {0}", positionCol);

            //// find first occurence of the min
            //bool find = false;
            //for (int x = 0; x < arr.GetLength(0); x++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (arr[x, j] == min & !find)
            //        {
            //            positionCol = x;
            //            find = true;
            //            break;
            //        }
            //    }

            //}

            return AddColIndPos(arr, positionCol);

        }


    }
}
