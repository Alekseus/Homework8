//Сформировать трёхмерный массив с неповторяющимися двузначными числами и вывести его на экран построчно, с индексами элементов.


Console.Clear();
Console.WriteLine();
Random rand = new Random();
int[,,] TripleMass()
{
    int[,,] array = new int[3, 3, 3];
    int n = rand.Next(10, 50);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = n;
                n++;
            }
        }
    }
    return array;
}
void PrintOdd(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.WriteLine($"Элемент с индексами [{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}
int[,,] matrix = TripleMass();
Console.WriteLine("Индексы трехмерного массива:");
PrintOdd(matrix);