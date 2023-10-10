using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_2
{
    public class Utility
    {
        public void addArray(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.WriteLine("Nhap gia tri phan tu tai vi tri hang {0} cot {1}", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void showArray(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public int SumArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        public void Smallest(int[,] arr)
        {
            
            for(int i = 0;i<= arr.GetUpperBound(0); i++)
            {
                int temp = arr[i,0];
                for(int j =0;j<= arr.GetUpperBound(1); j++)
                {               
                    if (arr[i, j]< temp)
                    {
                        temp = arr[i, j];
                    }
                }
                Console.Write(temp + "\t");

            }
        }
        public int SumArray1(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum += arr[0, i];
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[arr.GetLength(0) - 1, i];
            }
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                sum += arr[i, 0];
            }
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                sum += arr[i, arr.GetLength(1) - 1];
            }
            return sum;
        }
        public void SwapArray(int[,] arr, int[] arr1)
        {
            int index = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (index < arr1.Length)
                    {
                        arr1[index] = arr[i, j];
                        index++;
                    }
                }
            }
        }
        public void SortUp(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
