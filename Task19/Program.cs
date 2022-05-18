/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Write("Введите пятизначное число - ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 9999 && Number < 100000)
{
    int a5 = Number % 10;
    int a4 = (Number / 10) % 10;
    int a2 = (Number / 1000) % 10;
    int a1 = Number / 10000;

    if (a1 == a5 && a2 == a4)
    {
        Console.Write($"Введенное число {Number} является палиндромом!");
    }
    else
    {
        Console.Write($"Введенное число {Number} не является палиндромом!");
    }
}
else
{
    Console.Write($"Введенное число {Number} не является пятизначным!");
}