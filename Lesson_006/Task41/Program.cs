// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    array[i] = new Random().Next(-1000,1000);
    Console.Write(array[i] + "\t ");
}

  int count = 0;
  for (int i = 0; i < array.Length; i++)
{
   if(array[i] > 0 )  count += 1; 
}
  
Console.WriteLine();
Console.WriteLine($"В данном массиве чисел больше 0: {count} ");