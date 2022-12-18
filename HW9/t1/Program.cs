﻿//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void Sum(int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма  элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    Sum(M, N, sum);
}

Sum(M, N, 0);
