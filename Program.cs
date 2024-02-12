using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of your array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0;i < n; i++)
            {
                Console.Write("Please enter " + i + "th value: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("This is the output of the INSERTION sort");
            Insertion_Sort insertion_Object = new Insertion_Sort(array);
            insertion_Object.sort();
            insertion_Object.printSortedArray(array);

      
        }
    }
}
