using System;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int itemsCount = int.Parse(Console.ReadLine());
            
            int[] array = new int[itemsCount];
            // TODO: считайте массив
            for (int i=0; i < itemsCount; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            PrintArray(array);
            
            // TODO: считайте новое значение
            var newValue = int.Parse(Console.ReadLine());
            ReplaceMaxElem(ref array, newValue);

            // TODO: реализуйте вывод необходимых данных
            PrintArray(array);
        }

        static void ReplaceMaxElem(ref int[] array, int value)
        {
            // TODO: реализуйте замену всех вхождений максимального элемента массива arr на значение val
            int max = array[0];
            for (int i=1; i < array.Length; ++i)
            {
                max = Math.Max(max, array[i]);
            }
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = array[i] == max ? value : array[i];
            }
        }
        
        
        private static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}