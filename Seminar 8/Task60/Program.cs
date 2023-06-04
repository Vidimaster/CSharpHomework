int[] CreateArrayWithUniques(int size, int leftRange, int rightRange)
{
    int[] uniqueArr = new int[size];
    int count = 0;
    Random rand = new Random();
    while (count < uniqueArr.Length)
    {
        bool elementrepeat = false;
        int a = rand.Next(leftRange, rightRange + 1);
        for (int i = 0; i < uniqueArr.Length; i++)
        {
            if (uniqueArr[i] == a)
            {
                elementrepeat = true;
                break;
            }
        }
        if (elementrepeat != true)
        {
            uniqueArr[count] = a;
            count++;
        }
    }
    count = 0;
    return uniqueArr;
}

int[,,] FillMatrixWithUniques(int row, int col, int vol, int leftRange, int rightRange)
{
    int[,,] matrix = new int[row, col, vol];
    int count = 0;
    int[] uniqueArr = CreateArrayWithUniques(row * col * vol, leftRange, rightRange);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = uniqueArr[count];
                count++;
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]}");
                System.Console.Write($"{(i, j, k)}");
                System.Console.Write("\t");
            }
            System.Console.WriteLine();
        }
    }
}
int[,,] matrix = FillMatrixWithUniques(2, 2, 2, 10, 99);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();

