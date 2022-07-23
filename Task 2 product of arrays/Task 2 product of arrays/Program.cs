using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_GeekBrains
{

	using System;

	class Program
	{
		//Программа определяет произведение массивов любой длинны и степени

		static int[] multiply(int[] array1, int[] array2,
								int size1, int size2)
		{
			int[] prod = new int[size1 + size2 - 1];

			for (int i = 0; i < size1 + size2 - 1; i++)
			{
				prod[i] = 0;
			}


			for (int i = 0; i < size1; i++)
			{

				for (int j = 0; j < size2; j++)
				{
					prod[i + j] += array1[i] * array2[j];
				}
			}

			return prod;
		}


		static void White(int[] poly, int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.Write(poly[i]);
				if (i != 0)
				{
					Console.Write("x^" + i);
				}
				if (i != n - 1)
				{
					Console.Write(" + ");
				}
			}
			Console.WriteLine();
		}


		public static void Main(String[] args)
		{

			int[] array1 = { 8, 1 };  /*Здесь можно задать любой массив*/
			int[] array2 = { 4, 2 }; /*Здесь можно задать любой массив*/
			int size1 = array1.Length;
			int size2 = array2.Length;

			Console.Write("Первый многочлен:  ");
			White(array1, size1);
			Console.Write("Второй многочлен:  ");
			White(array2, size2);

			int[] prod = multiply(array1, array2, size1, size2);

			Console.Write("Произведеие:  ");
			White(prod, size1 + size2 - 1);


		}
	}


}
