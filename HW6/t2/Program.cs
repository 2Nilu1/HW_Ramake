// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Выполнение обеих задач с использованием созданных вами функций.
Console.Clear();
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
double Fun(double x)
{
    x = (b1 - b2) / (k1 - k2);
    return x;
}


double Fun1(double y)
{
    y = k1 * x + b1;
    return y;
}

// if (k1==k2)
// {
//     Console.WriteLine("Прямые не пересекаютсяю");
//     else
//     {
//         if(k1==k2; b1 > b2 || b1 < b2)
//         {

//         }
//     }
// }




Console.WriteLine($"Координаты точки пересечения: ({Fun(x)}; {Fun1(y)})" );

