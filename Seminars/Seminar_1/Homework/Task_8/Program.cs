﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!); //в переменную n записываем введенное (конечное) число
int index = 1; // переменная index (искомые числа) начинается с 1 по условию

while (index <= n) // цикл пока index меньше или равно введенного значения
{
    if (index % 2 == 0) // если остаток от деления текущего числа на 2 равен нулю
    {
        Console.Write($"{index} "); // то выводим это число
    }
    index++; // переходим к следующему числу
}
