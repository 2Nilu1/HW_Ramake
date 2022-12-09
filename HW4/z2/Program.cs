//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int len = NumLenght(num);
int sum = 0;

int NumLenght(int num)
{
    int i = 0;
    while( num > 0)
    {
        num = num / 10;
        i++;
    }
    return i;
}


int NumSum(int num ,int len)
{
    for(int i = 1; i <= len; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(NumSum(num,len));