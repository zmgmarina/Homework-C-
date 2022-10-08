// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9

double m = Convert.ToDouble(Console.ReadLine());
double n = Convert.ToDouble(Console.ReadLine());



double[,] GetMatrix(double m, double n)            
{
    double[,] matrix = new double[m, n];         
    for (int j = 0; j < m; j++)                  
    {
        for (int i = 0; i < n; i++)      
              
        {
            matrix[j,i] = new Random().Next(11); 

        }

    }

    return matrix;
}

Console.WriteLine(GetMatrix(m,n));



