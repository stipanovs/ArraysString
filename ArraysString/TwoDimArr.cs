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
            // coloana completata cu 0
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
        //p. 2.2
        public int[,] InsertColBefNum(int[,] arr, int number)
        {
            
            int positionCol = arr.GetLength(1);
            // find number element
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
                    }
                }
            }
           
            return AddColIndPos(arr, positionCol);

        }
        //p. 2.3
        public int[,] DeleteLinesConEvensElem(int[,] arr)
        {

            for (int n = 0; n < arr.GetLength(0); n++)
            {
                int RowNum = -1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    string evensline = ""; //if evensline contine F - line not evens
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] % 2 == 0)
                        {
                            evensline += "T";
                        }
                        else
                        {
                            evensline += "F";
                        }

                        if (!evensline.Contains("F"))
                        {
                            RowNum = i;
                        }
                    }
                }
                DeleteRowIndPos(ref arr, RowNum);
            }

            return arr;
        }

        public void DeleteRowIndPos(ref int[,] arr, int rowIndex)
        {
            // 0 4,5,7,6
            // 1 8,9,1,8
            // 2 2,4,6,8 del 
            // 3 3,8,9,7

            int lastRow = arr.GetLength(0);
            int lastColumn = arr.GetLength(1);
            int[,] result = new int[lastRow - 1, lastColumn];

            // Copy
            for (int i = 0; i < rowIndex; i++)
            {
                for (int x = 0; x < lastColumn; x++)
                {
                    result[i, x] = arr[i, x];
                }
            }

            for (int i = rowIndex; i < result.GetLength(0); i++)
            {
                for (int x = 0; x < lastColumn; x++)
                {
                    result[i, x] = arr[i + 1, x];
                }
            }

            arr = result;
       
        }

        public void DeleteColIndPos(ref int[,] arr, int colIndex)
        {
            //   d
            // 0 4,5,7,6
            // 1 8,9,1,8
            // 2 2,4,6,8  
            // 3 3,8,9,7

            int lastRow = arr.GetLength(0);
            int lastColumn = arr.GetLength(1);
            int[,] result = new int[lastRow, lastColumn - 1];

            // Copy in new array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int x = 0; x < colIndex; x++)
                {
                    result[i, x] = arr[i, x];
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int x = colIndex; x < lastColumn; x++)
                {
                    result[i, x] = arr[i, x + 1];
                }
            }

            arr = result;

        }


    }
}
