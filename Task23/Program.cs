﻿/*
Задача 23: Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число - ");
int Number = Convert.ToInt32(Console.ReadLine());

int result = 0;
Console.Write($"Таблица кубов чисел от 1 до {Number} = ");
for (int i = 1; i <= Number; i++)
{
    result = i * i * i;
    Console.Write(result);
    Console.Write(", ");
}