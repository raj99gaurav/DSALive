using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev_Array_Rec
{
    class Program
    {
        static void revArray(int[] arr,int s,int e)
        {
            int temp;
            if (s >= e)
                return;
            temp = arr[s];
            arr[s] = arr[e];
            arr[e] = temp;

            revArray(arr, s + 1, e - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 6, 8, 9, 12, 23 };
            int n = arr.Length;
            Console.WriteLine("Old Array : ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            revArray(arr, 0, n - 1);

            Console.WriteLine(" ");

            Console.WriteLine("New Array : ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");

            Console.ReadLine();
        }
    }
}
