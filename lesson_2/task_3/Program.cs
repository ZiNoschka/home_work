﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число от 10 до 99: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 10 && number <= 99)
        {
            int maxDigit = 0;
            while (number > 0)
            {
                maxDigit = Math.Max(maxDigit, number % 10);
                number /= 10;
            }
            Console.WriteLine($"Наибольшая цифра в числе {maxDigit}");
        }
        
    }
}