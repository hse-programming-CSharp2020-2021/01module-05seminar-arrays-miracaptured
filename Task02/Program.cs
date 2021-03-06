﻿using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
            {
                RunTask02();
            }

            public static void RunTask02()
            {
                
                int N = int.Parse(Console.ReadLine());
                ulong[] array = new ulong[N];
                FillArray(ref array);
                foreach (ulong item in array)
                {
                    Console.Write($"{item} ");
                }
            }

            static void FillArray(ref ulong[] array)
            {
                array[0] = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = array[i - 1] * 2;
                }
            }
    }
}

                
                
                
              