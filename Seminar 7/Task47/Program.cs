int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 1);
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
double[,] matrix = FillMatrix(ReadInt("Введите кол-во строк m"), ReadInt("Введите кол-во столбцов n"), 0, 10);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
