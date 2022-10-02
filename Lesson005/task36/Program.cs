//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[size]; 
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(10);
    Console.Write(array[i] + "\t ");
}
 

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
  if (i % 2 == 1) sum += array[i];
  array[i] ++; 

}
Console.WriteLine();           
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна: {sum} ");