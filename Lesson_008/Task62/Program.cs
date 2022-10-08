// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
 
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int n = 4;
int[,] squareMatrix = new int[n, n];


void GetArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int tmp = 1;
int i = 0;
int j = 0;

while (tmp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
  squareMatrix[i, j] = tmp;
  tmp++;
  if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

GetArray(squareMatrix);
