bool isNatural(double n)
{
    if (n > 0)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Число В должно быть натуральным!");
        return false;
    }
}

double Result(int[] ApowB)
{
    int result = ApowB[0];
    if (isNatural(ApowB[1]))
    {
        for (int i = 0; i < ApowB[1] - 1; i++)
        {
            result = result * ApowB[0];
        }
        return  result;
    }
    else
    {
        return 0;
    }

}

int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите число А и В");
System.Console.WriteLine(string.Join(", ", input) + " -> " + Result(input));

