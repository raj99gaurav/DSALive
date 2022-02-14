using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev_Array_Iteration
{
    class Program
    {
        static void reverseArray(int []arr,int start,int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 6, 8, 9, 12, 23 };
            int n = arr.Length;
            Console.WriteLine("Old Array : ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            reverseArray(arr, 0, n-1);

            Console.WriteLine(" ");

            Console.WriteLine("New Array : ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            Console.ReadLine();
        }
    }
}
