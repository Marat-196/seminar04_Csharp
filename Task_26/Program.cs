// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNumbers(int num)
{  
    if (num == 0) return 1;
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count += 1;
    }
    return count;
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int countNumbers = CountNumbers(num);

Console.WriteLine($"{num} -> {countNumbers}");


