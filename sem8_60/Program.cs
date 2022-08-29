// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.WriteLine("Введите размер трехмерного массива");
int x = SluchNumbers("Введите X: ");
int y = SluchNumbers("Введите Y: ");
int z = SluchNumbers("Введите Z: ");
Console.WriteLine("");

int[,,] array3 = new int[x, y, z];
ZapolnenieArray(array3);
VivodArray(array3);

int SluchNumbers(string input)
{
  Console.Write(input);
  int numb = Convert.ToInt32(Console.ReadLine());
  return numb;
}

void VivodArray (int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void ZapolnenieArray(int[,,] array3)
{
  int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3.GetLength(0); x++)
  {
    for (int y = 0; y < array3.GetLength(1); y++)
    {
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
