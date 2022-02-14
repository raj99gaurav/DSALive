using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Array_Min_Comparisons_Pairs
{
    class Program
    {
        class MM
        {
            public int min;
            public int max;
        }
        static MM minMax(int[] arr, int n)
        {
            MM minmax = new MM();
            int i;

            if (n %2 == 0)
            {
                if( arr[0] > arr[1] )
                {
                    minmax.max = arr[0];
                    minmax.min = arr[1];
                }
                else
                {
                    minmax.max = arr[1];
                    minmax.min = arr[0];
                }
                i = 2;
               
            }
            else
            {
                minmax.max = arr[0];
                minmax.min = arr[0];
                i = 1;
            }
            while(i<n-1)
            {
                if(arr[i] > arr[i+1])
                {
                    if (arr[i] > minmax.max)
                        minmax.max = arr[i];
                    if (arr[i+1] < minmax.min)
                        minmax.min = arr[i+1];
                }
                else
                {
                    if (arr[i + 1] > minmax.max)
                        minmax.max = arr[i + 1];
                    if (arr[i] > minmax.min)
                        minmax.min = arr[i];
                }
                i = i + 2;
            }
            return minmax;

        }
        public static void Main()
        {
            int[] arr = { 23, 45, 26, 432, 34, 6 };
            int n = arr.Length;
            MM minma = new MM();
            minma = minMax(arr, n);
            Console.WriteLine("Max element : " + minma.max + " " + " Min element " + minma.min);
            Console.ReadLine();
        }
    }
}
