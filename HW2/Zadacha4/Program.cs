//Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.

Console.Clear();
Console.WriteLine("Введите число ");
int B = Int32.Parse(Console.ReadLine());
int A = Int32.Parse(Console.ReadLine());
if(B * B == A)
Console.WriteLine($"True {B}** = {A}");
else
Console.WriteLine("False");