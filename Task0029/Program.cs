// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] CreateArray(int size)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 99);
        array[i] = rnd.Next(1, 99);
    }
 return array;

}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(" , ");
    }
    Console.WriteLine(" ]");
}

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 0)
{
    Console.WriteLine($"Число {a} некорректно, нужно ввести целое положительное число.");
}
else
{
    int[] createArray = CreateArray(a);
    PrintArray(createArray);  
}

