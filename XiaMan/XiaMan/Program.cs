using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XiaMan.Algorithm;

namespace XiaMan
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 10, 5, 3, 1, 7, 2, 8 };
            Console.WriteLine("排序之前：");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

            Sort.quickSort(array, 0, array.Length - 1);

            Console.WriteLine("\n排序之后：");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

            Console.ReadLine();
        }
    }
}
