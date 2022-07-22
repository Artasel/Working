/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

//  снизу-вверх и справа-налево.  4 метод

int Inizialisazion4(int[,] Arr, int index4, int count4)
{
    int j = 0;

    if (index4 != 0)
    {
        j = index4;
        index4 = Arr.GetLength(1) - 1 + (index4 * (-1));
    }
    else
    {
        index4 = Arr.GetLength(1) - 1;
        j = 0;
    }
    for (; index4 >= 0; index4--)
    {
        if (Arr[index4, j] == 0)
        {
            Arr[index4, j] = count4;
            count4++;
        }
    }
    return count4;
}

//   справа-нелево и снизу-вверх. 3 метод

int Inizialisazion3(int[,] array, int index3, int count3)
{
    if (index3 != 0) index3 = array.GetLength(0) - 1 + (index3 * (-1));
    else  index3 = array.GetLength(0) - 1;

    for (int j = array.GetLength(0) - 1; j >= 0; j--)
    {
        if (array[index3, j] == 0)
        {
            array[index3, j] = count3;
            count3++;
        }
    }
    return count3;
}

//  сверху-вниз и слева-направо.  2 метод

int Inizialisazion2(int[,] Array, int index2, int count2)
{
    int j = Array.GetLength(1) - 1;
    if (index2 != 0) j = Array.GetLength(1) - 1 + (index2 * (-1));

    for (; index2 < Array.GetLength(1); index2++)
    {
        if (Array[index2, j] == 0)
        {
            Array[index2, j] = count2;
            count2++;
        }
    }
    return count2;
}

int Inizialisazion(int[,] mass, int index, int count)    //1 метод
{
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        if (mass[index, j] == 0)
        {
            mass[index, j] = count;
            count++;
        }
    }
    return count;
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

int[,] matrix = new int[4, 4];
int counter = 1;
int border = (matrix.GetLength(0) / 2) - 1;
for (int i = 0; i <= border; i++)
{
    counter = Inizialisazion(matrix, i, counter);
    counter = Inizialisazion2(matrix, i, counter);
    counter = Inizialisazion3(matrix, i, counter);
    counter = Inizialisazion4(matrix, i, counter);
}
ReadMass(matrix);