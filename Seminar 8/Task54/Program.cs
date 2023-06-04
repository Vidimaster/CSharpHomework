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

void SortRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                if (matrix[i,k] < matrix[i,k + 1])
                {
                    int temp = matrix[i,k];
                    matrix[i,k] = matrix[i,k + 1];
                    matrix[i,k + 1] = temp;
                }
        }
    }

}

int[,] matrix = FillMatrix(6, 6, 0, 20);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
SortRow(matrix);
PrintMatrix(matrix);