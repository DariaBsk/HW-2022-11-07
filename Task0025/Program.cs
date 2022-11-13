// // Задача 25: Напишите цикл, который принимает на вход 
// // два числа (A и B) 
// // и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16


int degree = 1;
int Degree(int num1, int num2)
{   
   {
        for (int i = 1; i <= num2; i++)
         {
             degree *= num1;
         }
        return degree;
    }  
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0 )
{
    Console.WriteLine($"Число {b} некорректно");
}
else if (b == 0)
{
    Console.WriteLine($" => 1 ");
} 
else
{
    Degree(a, b);
    Console.WriteLine($" => {degree} ");
}