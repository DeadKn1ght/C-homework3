// Задача 19:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Input five-digit number :");
int number = int.Parse(Console.ReadLine());

if ((number > 99999) || (number < 10000))
    Console.WriteLine("You input incorect number");

int palifirst = number / 10000;
int palilast = number % 10;
int palisecond = (number / 1000)%10;
int paliprelast = (number / 10) % 10;

if ((palifirst == palilast) || (palisecond == paliprelast))
    Console.WriteLine("This number is palindrome");
else
    Console.WriteLine("This number is not palindrome");
