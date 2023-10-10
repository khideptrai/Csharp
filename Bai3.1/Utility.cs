using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3._1
{
    class Utility
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void ArrayAdd(int[]arr)
        {
            for(int i = 0;i< arr.Length; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu tai vi tri " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int SmallestNumber(int[] arr)
        {
            int temp =arr[0];
            for(int i = 0;i< arr.Length; i++)
            {
                if (arr[i] < temp)
                {
                    Swap(ref arr[i],ref temp);
                }
            }
            return temp;
        }
        public void ReverseArray(int[] arr)
        {
            for(int i = 0;i< arr.Length/2; i++)
            {
                Swap(ref arr[i], ref arr[arr.Length - 1 - i]);
            }
        }
        public void SortUp(int[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        Swap(ref arr[j], ref arr[i]);
                    }
                }
            }
        }
        public void ShortDown(int[] arr)
        {
            for(int i = 0;i< arr.Length; i++)
            {
                for(int j = i+1;j< arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        Swap(ref arr[j], ref arr[i]);
                    }
                }
            }
        }
        public bool PrimeNumber(int n)
        {
            if(n < 2)
            {
                return false;
            }
            int number =(int)Math.Sqrt(n);
            for(int i = 2; i < number; i++)
{
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int Average(int[] arr)
        {
            int sum = 0;
            int count = 0;
            for(int i = 0;i< arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }
            if(sum > 0)
            {
                sum /= count;
            }
            return sum;
        }

        public bool isIntertwined(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > 0 && arr[i+1]>0)|| (arr[i] < 0 && arr[i+1] < 0))
                {
                    return false;
                }
            }
            return true;
        }
        public int MaxConsecutivePositive(int[] arr)
        {
            int maxCount = 0;  
            int currentCount = 0;  

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    currentCount++; 
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;  
                    }
                    currentCount = 0; 
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }
    }
}
