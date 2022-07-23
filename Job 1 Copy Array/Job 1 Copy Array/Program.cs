using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_1_Copy_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 0, 1, 2, 3 };
            int[] array2 = new int[4];

            //ВАРИАНТ 1

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array2[i] = array1[i];
            //    Console.WriteLine(array2[i]);
            //}


            //ВАРИАНТ 2

            Array.Copy(array1, array2, 4);

            foreach (var element in array2)
            {
                Console.WriteLine(element);
            }



        }
    }
}
