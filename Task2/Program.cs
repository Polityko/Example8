Console.WriteLine($"\nВведите размеры матриц: ");
int a = InputNumbers("Введите число строк 1-й матрицы: ");
int b = InputNumbers("Введите число столбцов 1-й матрицы: ");
int c = InputNumbers("Введите число столбцов 2-й матрицы: ");
int digit = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[a, b];
PrintArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
FillArray(firstMartrix);

int[,] secomdMartrix = new int[b, c];
PrintArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
FillArray(secomdMartrix);

int[,] newMatrix = new int[a,c];

MultiplicationMatrix(firstMartrix, secomdMartrix, newMatrix);
Console.WriteLine($"\nПроизведение двух матриц: ");
FillArray(newMatrix);

void MultiplicationMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resMatrix)
{
  for (int i = 0; i < resMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int n = 0; n < firstMartrix.GetLength(1); n++)
      {
        sum += firstMartrix[i,n] * secomdMartrix[n,j];
      }
      resMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(digit);
    }
  }
}

void FillArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}