// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());
int number2 = (threeDigit / 10) % 10;

if (threeDigit >= 100 && threeDigit <1000)
{
    Console.WriteLine($"Это вторая цифра твоего числа: {number2}");
}
else
{
    Console.WriteLine("Введено неверное значение");
}