// напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452-> 11
// 82 -> 10
// 9012 ->12


Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    sum = sum + a % 10;
    a = a /10 ;
}
Console.WriteLine(sum);