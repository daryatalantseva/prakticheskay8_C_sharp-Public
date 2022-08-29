//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размер массива m x n");
int m  = Convert.ToInt32(Console.ReadLine());
int n  = Convert.ToInt32(Console.ReadLine());
int x = InputNumbers("Введите диапазон: случайных чисел от 1 до ... ");

int[,] array = new int[m, n];
ZapolnenieArray(array);
VivodArray(array);

int[] new_array = new int[m];  // вывод массива с суммщй элементов каждой строки
for (int i = 0; i < array.GetLength(0); i++)
  { int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum+=array[i,j];
    }
    new_array[i] = sum;
  }
Console.WriteLine("Сумма элементов каждой строки массива");
VivodnewArray(new_array);
Console.WriteLine();
int min = new_array[0]; 
int NumberStr = 0; // Нахождение минимального элемента в одномерном массиве
for (int i = 0; i < new_array.GetLength(0); i++)
{
    if (new_array[i] < min) 
    {
        min = new_array[i];
        NumberStr = i;
    }
}

Console.WriteLine("Строка с минимальной суммой элементов номер " + NumberStr);
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
      array[i, j] = new Random().Next(x);
    }
  }
}

void VivodArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
void VivodnewArray(int[] new_array)
{
  for (int i = 0; i < new_array.GetLength(0); i++)
  {
      Console.Write(new_array[i] + " ");
    }
}