/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

bool uniqueNumberCheck(int[] Array, int someNumber)
{
    bool checkUnique = true;

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == someNumber)
            {
                return checkUnique = false;
            }
        }
    return checkUnique;
}
int FillingMass(int[] array, int counter, int numberSome)
{
    return array[counter] = numberSome;
}
void BubbleSorter(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[i] >  arr[j])
            {
                int container = arr[i];
                arr[i] = arr[j];
                arr[j] = container;
            }
        }
    }
}
void InitializerUniqueNumber(int[,,] mass)
{
    int count = 0;
    int len = mass.GetLength(0) * mass.GetLength(1) * mass.GetLength(2);
    int[] array = new int[len];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int l = 0; l < mass.GetLength(2); l++)
            {
                bool checkNum = false;

                while (checkNum == false)
                {
                    int uniqueNumber = new Random().Next(10, 100);

                    checkNum = uniqueNumberCheck(array, uniqueNumber);

                    if (checkNum)
                    {
                        FillingMass(array, count, uniqueNumber);
                        mass[i, j, l] = uniqueNumber;
                        count++;
                    }
                }
            }
        }
    }
    Console.WriteLine("{0}", string.Join(",", array));
    Console.WriteLine();
    BubbleSorter(array);
    Console.WriteLine("{0}", string.Join(",", array));
    Console.WriteLine();
}
void ReadMass(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                Console.Write($"{arr[i, j, l]}({i},{j},{l}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] SomeArray = new int[2, 2, 2];
InitializerUniqueNumber(SomeArray);
ReadMass(SomeArray);
