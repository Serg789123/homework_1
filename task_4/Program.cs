//Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Write("Введите число a: ");
int num_a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int num_b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int num_c = int.Parse(Console.ReadLine());
int max = 0;
if (num_a > max)
{
    max = num_a;
}
if (num_b > max)
{
    max = num_b;
}
if (num_c > max)
{
    max = num_c;
}
Console.WriteLine($"максимальное число = {max}");
