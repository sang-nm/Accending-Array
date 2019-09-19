using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accending_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int len1, len2, len3, len4, i, j, k, l, change;
            Console.Write("Enter the lengh of the first array:");
            len1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the lengh of the second array:");
            len2 = int.Parse(Console.ReadLine());
            len3 = len4 = len1 + len2;
            int[] arr1 = new int[len1];
            int[] arr2 = new int[len2];
            int[] arr3 = new int[len3];
            int[] arr4 = new int[len4];
            for (i = 0; i < len1; i++)
            {
                Console.Write("Enter the value of arr[{0}]:", i);
                arr1[i] = int.Parse(Console.ReadLine());
                k = i;
                arr3[k] = arr1[i];
            }
            for (j = 0; j < len2; j++)
            {
                Console.Write("Enter the value of arr[{0}]:", j);
                arr2[j] = int.Parse(Console.ReadLine());
                k = j + i;
                arr3[k] = arr2[j];
            }
            for (k = 0; k < len3; k++)
            {
                Console.Write("\t{0}", arr3[k]);
            }
            change = 0;
            Console.WriteLine();
            Console.Write("All value of the accending array:");
            for (k = 0; k < len3 - 1; k++)
            {
                for (l = k + 1; l < len3; l++)
                {
                    if (arr3[k] > arr4[l])
                    {
                        change = arr3[k];
                        arr3[k] = arr4[l];
                        arr4[l] = change;
                    }
                }
                Console.Write("\t{0}", arr3[k]);
            }
            Console.ReadLine();
        }
    }
}
