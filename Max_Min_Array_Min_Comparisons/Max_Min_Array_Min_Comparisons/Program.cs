using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Array_Min_Comparisons
{
    class Program
    {
        class MM
        {
            public int min;
            public int max;
        }

        static MM minMax(int [] arr,int n)
        {
            MM minmax = new MM();
            int i;

            if(n==1)
            {
                minmax.max = arr[0];
                minmax.min = arr[0];
                return minmax;
            }
            if(arr[0] > arr[1])
            {
                minmax.max = arr[0];
                minmax.min = arr[1];
            }
            else
            {
                minmax.max = arr[1];
                minmax.min = arr[0];
            }
            for(i=2;i<n;i++)
            {
                if(arr[i]>minmax.max)
                {
                    minmax.max = arr[i];
                }
                else if ( arr[i] < minmax.min)
                {
                    minmax.min = arr[i];
                }
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
