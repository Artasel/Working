/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Initializer(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1, 11);
        }
    }
}

void ReadMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void StringSmallestSumItems(int[,] array)
{
    int stringSmallestSumItems = 1;
    int result2 = 100000000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
        Console.WriteLine($"В {i + 1} строке сумма элементов-{result}");
        if (result2 > result)
        {
            result2 = result;
            stringSmallestSumItems = i + 1;
        }
    }
    Console.WriteLine($"{stringSmallestSumItems} строка имеет наименьшую сумму элементов.");
}

int[,] SomeArray = new int[15, 30];

Initializer(SomeArray);
ReadMass(SomeArray);
Console.WriteLine();
StringSmallestSumItems(SomeArray);