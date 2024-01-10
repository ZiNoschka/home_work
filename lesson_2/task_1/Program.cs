﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
           
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine($"{number} кратно и 7, и 23.");
            }
            else
            {
                Console.WriteLine($"{number} не кратно одновременно и 7, и 23.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
    }
}