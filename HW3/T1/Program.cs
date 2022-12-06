//Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if(num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Число:{num} - не является пятизначным,повторите попытку");
}