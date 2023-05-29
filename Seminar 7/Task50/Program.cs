int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();

    }
}

void WhatIsTheNumberByPosition(int[,] matrix, int row, int col)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == col)
            {
                System.Console.WriteLine(matrix[i, j]);
                return;
            }
        }
    }
    System.Console.WriteLine("Такого числа в массиве нет");
}

int[,] matrix = FillMatrix(ReadInt("Введите количество строк"), ReadInt("Введите количество столбцов"), 0, 20);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
WhatIsTheNumberByPosition(matrix, ReadInt("Введите номер строки") - 1, ReadInt("Введите номер столбца") - 1);