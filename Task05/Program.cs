﻿using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 1.
 * В программе сформировать целочисленный массив,
 * содержащий N первых элементов последовательности Фибоначчи:
 * A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], …
 * 
 * Формирование массива организовать при помощи метода.
 * Элементы массива вывести на экран в обратном порядке.
 * Методы класса Array НЕ использовать.
 *
 * Пример входных данных:
 * 5
 *
 * Пример выходных данных:
 * 5 3 2 1 1
 */

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask05();
        }


        public static void RunTask05()
        {
            long N = long.Parse(Console.ReadLine());

            // TODO: объявите массив и вызовите метод для его заполнения
            long[] array = new long[N];
            FillArray(array);

            // TODO: выведите массив на экран в требуемом порядке
            for (long i = array.Length - 1; i >= 0; --i)
            {
                Console.Write($"{array[i]} ");
            }
        }

        private static void FillArray(long[] arr)
        {
            arr[0] = arr[1] = 1;
            for (long i = 2; i < arr.Length; ++i)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
        }
        
    }
}