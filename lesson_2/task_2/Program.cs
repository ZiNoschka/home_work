﻿using System;

class Program
{
    static void Main()
    {
        double x, y;

        Console.Write("Введите координаты точки X: ");
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Неверный формат ввода для X. Введите число.");
            return;
        }

        Console.Write("Введите координаты точки Y: ");
        if (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Неверный формат ввода для Y. Введите число.");
            return;
        }

        int quadrant;

        if (x > 0 && y > 0)
        {
            quadrant = 1;
        }
        else if (x < 0 && y > 0)
        {
            quadrant = 2;
        }
        else if (x < 0 && y < 0)
        {
            quadrant = 3;
        }
        else if (x > 0 && y < 0)
        {
            quadrant = 4;
        }
        else
        {
        return;
        }

        Console.WriteLine($"Точка находится в {quadrant}-й координатной четверти.");
    }
}