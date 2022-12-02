// Семинар 1. Знакомство

// Задача 2. Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write($"{a} > {b}");
}
else
{
    Console.Write($"{a} < {b}");
}
*/

//Задача 4.  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input the first number: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: "); 
int c = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a > c)
        Console.Write($"{a}");
    else
        Console.Write($"{c}");
}
else
{
    if(b > c)
        Console.Write($"{b}");
    else 
        Console.Write($"{c}");
}
*/

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n%2 != 0)
{
    Console.Write("The number is odd");
}
else
{
    Console.Write("The number is even");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

int current = a;

while(current <= n)
{
    if(current%2 == 0)
    {
        Console.Write(current + " ");
    }
    
current++;
}
*/