// Задача 1. Какое число больше, какое меньше.
/*
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());  
   
    if 
    (a > b)
{
        Console.WriteLine("Первое число больше второго");
}   

    else if (a==b) 
{    
    Console.WriteLine("Числа равны");
}
    else
{
        Console.WriteLine("Второе число больше первого");
}
*/

// Задача 2. Дано 3 числа, вывести большое.

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третее целое число");
int c = Convert.ToInt32(Console.ReadLine());
//int max=0; Попробовать потом сделать цикл

    if (a>b&a>c)
{
        Console.WriteLine("Первое число больше останльных");
}
    else if (b>a&b>c)
{
        Console.WriteLine("Второе число больше остальных");
}
    else 
{
        Console.WriteLine("Третее число больше остальных");
}
    