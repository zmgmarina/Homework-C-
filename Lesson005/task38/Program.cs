// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = {3, 7, 22, 2, 78};

double maxValue = array[0]; 
double minValue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxValue)
    {
        maxValue = array[i];
    }
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
}

Console.Write($"Разница между максимальным и минимальным элементом массива равна: {maxValue - minValue}");