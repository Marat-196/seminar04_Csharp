// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumber(int number)
{
    int count = 0;
    for (int i=0; i <= number; i++)
    {
        count += i;
    }
    return count;
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} -> {SumNumber(num)}");

