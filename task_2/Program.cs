/*Задача 2: Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.*/
Console.Write("Введите число num_a: ");
int num_a = int.Parse(Console.ReadLine());
Console.Write("Введите число num_b: ");
int num_b = int.Parse(Console.ReadLine());
if (num_a > num_b)
{
    Console.WriteLine("max = num_a");
}
else
{
    Console.WriteLine("max = num_b");
}
