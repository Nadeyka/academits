﻿using System;

namespace Range
{
    class Program
    {
        static void Main()
        {
            Range range = new Range(-0.1, 25);
            double length = range.GetLength();
            Console.WriteLine("Длина интервала: " + length);
            double number = -2.6;
            bool isInInterval = range.IsInside(number);
            if (isInInterval)
            {
                Console.WriteLine("Число {0} входит в интервал {1} - {2}", number, range.From, range.To);
            }
            else
            {
                Console.WriteLine("Число {0} не входит в интервал {1} - {2}", number, range.From, range.To);
            }

            Range r1 = new Range(-200, 220);
            Range r2 = new Range(200, 550);
            Console.WriteLine("Исходный интервал 1: {0} ... {1}", r1.From, r1.To);
            Console.WriteLine("Исходный интервал 2: {0} ... {1}", r2.From, r2.To);

            Range intersectRange = Range.GetIntersect(r1, r2);
            if (intersectRange != null)
            {
                Console.WriteLine("Интервал пересечения: {0} ... {1}", intersectRange.From, intersectRange.To);
            }
            else
            {
                Console.WriteLine("Интервалы не пересекаются");
            }

            Range[] unionRange = Range.GetUnion(r1, r2);
            if (unionRange[1] != null)
            {
                Console.WriteLine("Интервал объединения 1: {0} ... {1}", unionRange[0].From, unionRange[0].To);
                Console.WriteLine("Интервал объединения 2: {0} ... {1}", unionRange[1].From, unionRange[1].To);
            }
            else
            {
                Console.WriteLine("Интервал объединения: {0} ... {1}", unionRange[0].From, unionRange[0].To);
            }

            Range[] differenceRange = Range.GetDifference(r1, r2);
            if (differenceRange[1] != null)
            {
                Console.WriteLine("Интервал разности 1: {0} ... {1}", differenceRange[0].From, differenceRange[0].To);
                Console.WriteLine("Интервал разности 2: {0} ... {1}", differenceRange[1].From, differenceRange[1].To);
            }
            else
            {
                Console.WriteLine("Интервал разности: {0} ... {1}", differenceRange[0].From, differenceRange[0].To);
            }

        }
    }
}
