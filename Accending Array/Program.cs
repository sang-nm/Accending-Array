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
            int len1,len2,len3,i,j,k,l;
            int iswitch = 0;
            Console.Write("Enter the lengh of the first array:");
            len1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the lengh of the second array:");
            len2=int.Parse(Console.ReadLine());
            len3=len1+len2;
            int[] arr1=new int[len1];
            int[] arr2=new int[len2];
            int[] arr3=new int[len3];
            for(i=0;i<len1;i++)
            {
                Console.Write("Enter the value of arr[{0}]:", i);
                arr1[i] = int.Parse(Console.ReadLine());
                k = i;
                arr3[k] = arr1[i];
            }
            for(j=0;j<len2;j++)
            {
                Console.Write("Enter the value of arr[{0}]:", j);
                arr2[j] = int.Parse(Console.ReadLine());
                k = j+i;
                arr3[k] = arr2[j];
            }
            Console.Write("\nNew array of 2 arrays:");
            for (k = 0; k < len3;k++ )
            {
                Console.Write("\t{0}",arr3[k]);
            }
            Console.WriteLine();
            Console.Write("\nThe accending array:");
            for (k = 0; k < len3; k++)
            {
                for(l=k+1;l<len3;l++)
                    if (arr3[k] > arr3[l])
                    {
                        iswitch = arr3[k];
                        arr3[k] = arr3[l];
                        arr3[l] = iswitch;
                    }
                Console.Write("\t{0}", arr3[k]);
            }
            Console.ReadLine();
        }
    }
}
