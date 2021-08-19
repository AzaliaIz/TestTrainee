using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Задание 1
             */
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 7)
            {
                Console.WriteLine("Привет");
            }
            else
            {
                Console.WriteLine($"Число {num} меньше числа 7") ;
            }

            /**
             * Задание 2
             */
            Console.Write("\nВведите имя: ");
            string name = Console.ReadLine();
            string name2 = "Вячеслав";

            if (name == name2)
            {
                Console.WriteLine($"Привет, {name}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }

            /**
             * Задание 3
             */
            int n;
            Console.WriteLine("\nВведите число элементов массива");
            n = Convert.ToInt32(Console.ReadLine());
            // Объявим одномерный массив arr с n-элементами 
            int[] arr = new int[n];
            int i = 0;
            while (i < n)
            {
                //заполняем  массив 
                Console.WriteLine($"Введите элемент массива {i}");         
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("\nКратные трем:");
            //Кратные 3
            for (int k = 0; k < n; k++)
            {
                if (arr[k] % 3 == 0)
                {
                    Console.WriteLine(arr[k]);
                }
            }


            Console.ReadKey();
        }
    }
}
