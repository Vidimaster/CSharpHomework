int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = count;
            count++;
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

int[,] ChangeElementPos(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result[0, i] = matrix[0, i];
    }

    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        result[i, matrix.GetLength(1) - 1] = matrix[1, i - 1];
    }

    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        result[i, 0] = matrix[2, matrix.GetLength(1) - i];
    }

    result[1, 1] = matrix[3, 0];
    result[1, 2] = matrix[3, 1];
    result[2, 1] = matrix[3, 3];
    result[2, 2] = matrix[3, 2];
    result[3, 1] = matrix[2, 0];
    result[3, 2] = matrix[1, 3];

    return result;
}

int[,] matrix = FillMatrix(4, 4, 0, 10);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
matrix = ChangeElementPos(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

