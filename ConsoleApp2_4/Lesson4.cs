/*4. Написать программу для решения следующей задачи: 
Вычислить сумму элементов второй  половины одномерного массива, 
не превышающих значения минимального  среди элементов с четными номерами.
Исходный массив задавать, используя генерацию случайных чисел.
Для генерирования случайных чисел используйте класс Random*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_4
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Условие: размер массива не можеть быть меньше 4, также он должен быть четным.");
            Console.WriteLine("Данные условия следует соблюдать для корректной работы!!!");
            Console.Write("Укажите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            while (true) // защита от "дурня"
            {
                if (size < 4)
                {
                    Console.Write("Размер массива не должен быть меньше 4, попробуйте еще раз: ");
                    size = int.Parse(Console.ReadLine());
                }
                else if (size % 2 != 0)
                {
                    Console.Write("Массив должен содержать четное количество элементов, попробуйте еще раз: ");
                    size = int.Parse(Console.ReadLine());
                }
                else
                    break;
            }

            int[] arr = new int[size]; //объявляем массив

            Random random = new Random(); // Подключаем класс Random

            for (int i = 0; i < size; i++) // инициализируем массив
            {
                arr[i] = random.Next(100);
            }

            Console.WriteLine("Получившийся массив"); // выводим наш массив 
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int min = arr[1]; // определяем минимумальное значение
            for (int i = 3; i < size; i += 2)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            int sum = 0;

            for (int i = size / 2; i < size; i++) // определяем сумму четных элементов массива, которые больше минимального значен
            {
                if (arr[i] > min || arr[i] % 2 == 0)
                {
                    sum += arr[i]; 
                }
            }

            Console.WriteLine($"\nСумма четных элементов второй половины массива = {sum}");

            Console.ReadKey();
        }
    }
}
