// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.


Console.Write("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов 2-й матрицы:  ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон случайных чисел: от 1 до ");
int range = Convert.ToInt32(Console.ReadLine());



int[,] resultMatrix = new int[m,p];
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[n, p];

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
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


GetArray(firstMatrix);
Console.WriteLine($"Первая матрица: " );
WriteArray(firstMatrix);

GetArray(secondMatrix);
Console.WriteLine($"Вторая матрица: ");
WriteArray(secondMatrix);

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Результат: ");
WriteArray(resultMatrix);
