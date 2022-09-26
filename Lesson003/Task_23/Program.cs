// Напишите прогр., которая принимает на вход число (N)
// и  выдает таблицу кубов чисел от 1 до N/
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125

int end = Convert.ToInt32(Console.ReadLine());

for(int start = 1; start <= end; start++)
{
    Console.WriteLine(start*start*start);
}