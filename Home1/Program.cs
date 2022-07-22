/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Arrange(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int indexMinRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = j + 1; l < array.GetLength(1); l++)
            {
                if (array[i, indexMinRow] > array[i, l])
                {
                    int storage = array[i, indexMinRow];
                    array[i, indexMinRow] = array[i, l];
                    array[i, l] = storage;
                }
            }

            Console.Write(array[i, j] + "\t");
            indexMinRow++;
        }
        Console.WriteLine();
    }
}

int[,] SomeArray = new int[15, 10];

Initializer(SomeArray);
ReadMass(SomeArray);
Console.WriteLine();
Arrange(SomeArray);