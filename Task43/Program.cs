using System;
class Program
{
    static double[] Result()
    {
        Console.WriteLine("Введите коэффиценты для первой прямой "+"y = k1 * x + b1");
        Console.Write("k1 = ");
        double k1 = int.Parse(Console.ReadLine()!);
        Console.Write("b1 = ");
        double b1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Введите коэффиценты для второй прямой "+"y = k2 * x + b2");
        Console.Write("k2 = ");
        double k2 = int.Parse(Console.ReadLine()!);
        Console.Write("b2 = ");
        double b2 = int.Parse(Console.ReadLine()!);

        double x = (b2 - b1) / (k1 - k2); 
        double y = k1 * x + b1;   

        double[] Point = {x, y, k1, k2, b1, b2};
        return Point;
    }

    static void Verification(double[] Solution)
    {
         Console.WriteLine();
         Console.WriteLine("Проверка: для первой прямой y = k1 * x + b1");
         Console.WriteLine($"{Solution[1]} = {Solution[2]} * {Solution[0]} + {Solution[4]} ");
         Console.WriteLine($"{Solution[1]} = {Solution[2] * Solution[0] + Solution[4]} ");

         Console.WriteLine("Проверка: для второй прямой y = k2 * x + b2");
         Console.WriteLine($"{Solution[1]} = {Solution[3]} * {Solution[0]} + {Solution[5]} ");
         Console.WriteLine($"{Solution[1]} = {Solution[3] * Solution[0] + Solution[5]} ");

         if ((Solution[1] == Solution[2] * Solution[0] + Solution[4]) && (Solution[1] == Solution[2] * Solution[0] + Solution[4])) Console.WriteLine("Решение верное");
         else Console.WriteLine("Решение не верное");
    }
    
    static void Main()
    {
     double[] Intrsection = Result();
     Console.WriteLine($"Точка пересечения прямых: ({Intrsection[0]}; {Intrsection[1]}) ");
     Verification(Intrsection);
    }
}