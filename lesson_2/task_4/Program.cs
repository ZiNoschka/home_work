﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Цифры числа: ");

        while (n > 0)
        {
            int digit = n % 10;
            Console.Write(digit);

            n /= 10;

            if (n > 0)
            {
                Console.Write(",");
            }
        }

        Console.WriteLine();
    }
}