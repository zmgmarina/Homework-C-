// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//14212-> нет
//23432-> да
//12821-> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int n = number.Length;


if (n == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - это не палиндром");
    }
}
else
{
    Console.WriteLine($"Error: {number} - число не является пятизначным");
}
