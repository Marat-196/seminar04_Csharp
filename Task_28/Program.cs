// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int PrNumber(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    checked
    {
        count *= i;
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

int sumNumbers = PrNumber(num);

Console.WriteLine($"{num} -> {sumNumbers}");
