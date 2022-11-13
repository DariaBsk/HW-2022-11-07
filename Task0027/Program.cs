// Задача 27: Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



int SumNumbers(int num)
{
    int sum = 0;
    if (num < 0)
     num *= -1;
    while (num!= 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());


int sumNumbers = SumNumbers(a);
Console.WriteLine($"Сумма цифр в числе {a} равна {sumNumbers}");
