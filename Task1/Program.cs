int a = 9;
int b = 9;
int[,] array = new int[a, b];
Random rnd = new Random();
int numsum = Int32.MaxValue;
int index = 0;

void PrintArray(int[,] array)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.Write($"\n");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < a; i++)
    {
        int sum = 0;
        for (int j = 0; j < b; j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < numsum)
        {
            numsum = sum;
            index++;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой: " + (index) + ", сумма равна: " + (numsum));
}

PrintArray(array);
FillArray(array);