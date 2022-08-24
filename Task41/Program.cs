using System;
class Program
{
    static int[] CreateArray()
    {
        Console.WriteLine("Введите числа через запятую: ");
        string? InputNums = Console.ReadLine();

        string[] StringNums = InputNums!.Split(", ", StringSplitOptions.RemoveEmptyEntries);
        int[] IntNums = new int[StringNums.Length];

        for (int i = 0; i < StringNums.Length; i++)
        {
            IntNums[i] = int.Parse(StringNums[i]);
        }
        return IntNums;
    }

    static int Counter(int[] CountArray)
    {
        int count = 0;
        for (int i = 0; i < CountArray.Length; i++)
        {
            if (CountArray[i] > 0) count++;
        }
        return count;
    }

    static void Main()
    {
        int[] NewArray = CreateArray();
        Console.Write("[" + String.Join(", ", NewArray) + "] -> " + Counter(NewArray));
    }
}