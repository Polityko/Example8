int[,] fillArray(int a, int b)
{
    int[,] arr = new int[a, b];
    Random rnd = new Random();
    HashSet<int> size = new HashSet<int> { };
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            int num = rnd.Next(10, 100);
            if (size.Contains(num))
            {
                j--;
            }
            else
            {
                arr[i, j] = num;
                size.Add(num);
            }
        }
    }
    return arr;
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] dimension;
bool notCorrectSize;
do
{
    notCorrectSize = false;
    Console.Write("\nВведите число строк и столбцов двумерного массива через пробел размерностью не более 50 элементов: ");
    dimension = Console.ReadLine().Split().Select(i => Convert.ToInt32(i)).ToArray();
    if (dimension[0] * dimension[1] > 50)
    {
        Console.WriteLine("\nРазмерность больше 50 элементов. Уменьшите число строк или столбцов.");
        notCorrectSize = true;
    }
} while (notCorrectSize);
Console.WriteLine();
printArray(fillArray(dimension[0], dimension[1]));