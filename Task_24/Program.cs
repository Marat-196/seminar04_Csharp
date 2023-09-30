// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

using System.Globalization;

int SumNumber(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    checked
    {
        count += i;
    }
    
    return count;
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
} 

int sumNumbers = SumNumber(num);

Console.WriteLine($"{num} -> {sumNumbers}");

