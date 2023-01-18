/*Задача 6: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/
Console.Write("Введите число a: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("число является чётным");
}
else
{
    Console.WriteLine("число не чётное");
}