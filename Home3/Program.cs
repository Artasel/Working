/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
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
void Multiplication(int[,] array, int[,] Array)
{
    if(array.GetLength(1) != Array.GetLength(1) || array.GetLength(0) != Array.GetLength(0))
    {
        Console.WriteLine("Введены не соразмерные массивы, введите массивы одинаковые по количеству строк и рядов!");
        return;
    }  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] *= Array[i, j];
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SomeArray = new int[3, 4];
int[,] Matrix = new int[3, 3];

Initializer(SomeArray);
Initializer(Matrix);
ReadMass(SomeArray);
Console.WriteLine("и");
ReadMass(Matrix);
Console.WriteLine("Их произведение будет равно следующему массиву:");
Multiplication(SomeArray, Matrix);