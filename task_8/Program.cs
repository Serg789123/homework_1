﻿/*Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num_ch = 2;
while (num_ch <= num)
{
    Console.Write($"{num_ch}, ");
    num_ch = num_ch + 2;
}