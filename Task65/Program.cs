//Спирально заполнить двумерный массив.

Console.Clear();
Console.WriteLine();
int[,] FillArray()
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}

void SpirArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int firstnumber = 1;
    while (j < array.GetLength(1) - 1)
    {
        array[i, j] = firstnumber;
        firstnumber++;
        j++;
    }
    while (i < array.GetLength(0) - 1)
    {
        array[i, j] = firstnumber;
        firstnumber++;
        i++;
    }
    while (j > 0)
    {
        array[i, j] = firstnumber;
        firstnumber++;
        j--;
    }
    while (i > 0)
    {
        array[i, j] = firstnumber;
        firstnumber++;
        i--;
    }
    i++;
    j++;
    while (j < array.GetLength(1) - 1)
    {
        array[i, j] = firstnumber;
        firstnumber++;
        j++;
    }  
    while (j > 1)
    {
        array[i + 1, j -1] = firstnumber;
        firstnumber++;
        j--;
    }
}
void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 10)
                {
                    Console.Write($"  {array[i, j]} ");
                }
                else
                {Console.Write($" {array[i, j]} ");

                }
            }
            Console.WriteLine();
        }
    }
int[,] firstMatrix = FillArray();

SpirArray(firstMatrix);
PrintArray(firstMatrix);