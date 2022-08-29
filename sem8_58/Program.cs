// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите размеры матриц, количество столбцов первой равно количеству строк второй");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ...");

int[,] firstMart = new int[m, n];
ZapolnenieArray(firstMart);
Console.WriteLine("Первая матрица:");
VivodArray(firstMart);

int[,] secomdMart = new int[n, p];
ZapolnenieArray(secomdMart);
Console.WriteLine("Вторая матрица:");
VivodArray(secomdMart);

int[,] resultMart = new int[m,p];

ProizvedMatrix(firstMart, secomdMart, resultMart);
Console.WriteLine("Произведение первой и второй матриц:");
VivodArray(resultMart);

void ProizvedMatrix(int[,] firstMart, int[,] secomdMart, int[,] resultMart)
{
  for (int i = 0; i < resultMart.GetLength(0); i++)
  {
    for (int j = 0; j < resultMart.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMart.GetLength(1); k++)
      {
        sum += firstMart[i,k] * secomdMart[k,j];
      }
      resultMart[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void ZapolnenieArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void VivodArray (int[,] array)
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