using System;
using System.Collections.Generic;
using System.IO;
namespace Revstring
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            string rev = Console.ReadLine();
            string[] a = rev.Split(' ');
            int l = a.Length - 1;
            temp = l;
            for (int i = temp; temp >= 0; temp--)
            {
                Console.Write(a[temp] + ' ');
                
            }
            Console.ReadKey();

            Permutation_sort permutation_Sort = new Permutation_sort();

            string str = "Ok";
            char[] arr = str.ToCharArray();
            Permutation_sort.GetPer(arr);
        }

    }
}