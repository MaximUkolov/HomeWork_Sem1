// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int a = new Random().Next(100,999);
Console.WriteLine(a);
int first = a / 100;
int second = (a % 100) / 10;
int therd = a % 10;

Console.WriteLine(second);
