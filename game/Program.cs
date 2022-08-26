using System;
class Program
{
    static void Main()
    {
        int[,] number = { {0, 2, 0, 0, 0, 0, 0},
                          {0, 2, 0, 0, 2, 2, 0},
                          {0, 3, 0, 0, 0, 2, 0},
                          {2, 2, 2, 1, 0, 2, 0},
                          {0, 0, 0, 0, 2, 2, 0},
                          {0, 0, 2, 2, 2, 0, 0},
                          {0, 0, 0, 0, 0, 0, 0} };

        int[,] number2 = new int[5, 5];

        int row = 3;
        int column = 3;
        int oldRow = 0;
        int oldColumn = 0;
        int Score = 0;
        bool Flag = false;
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            oldRow = row;
            oldColumn = column;
            number[row, column] = 0;
            if (key.Key == ConsoleKey.W)
            {
                row--;
            }

            if (key.Key == ConsoleKey.S)
            {
                row++;
            }

            if (key.Key == ConsoleKey.A)
            {
                column--;
            }

            if (key.Key == ConsoleKey.D)
            {
                column++;
            }

            if (row > number.GetLength(0) - 1)
            {
                row = number.GetLength(0) - 1;
            }

            if (row < 0)
            {
                row = 0;
            }

            if (column > number.GetLength(1) - 1)
            {
                column = number.GetLength(1) - 1;
            }

            if (column < 0)
            {
                column = 0;
            }

            Console.Clear();
            if (number[row, column] == 2)
            {
                row = oldRow;
                column = oldColumn;
            }

            if (number[row, column] == 3)
            {
                Score += 10;
                Flag = true;
            }

            if (Flag == true)
            {
                while (Flag == true)
                {
                    int ScoreRow = new Random().Next(0, number.GetLength(0) - 1);
                    int ScoreColumn = new Random().Next(0, number.GetLength(1) - 1);
                    if (number[ScoreRow, ScoreColumn] == 0)
                    {
                        number[ScoreRow, ScoreColumn] = 3;
                        Flag = false;
                    }
                }


            }


            number[row, column] = 1;

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write(number[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Очки: " + Score);
        }
    }

}
