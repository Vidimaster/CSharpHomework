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
    double result = Math.Pow(ApowB[0], ApowB[1]);
    if (isNatural(ApowB[1]))
    {
        return result;
    }
    else
    {
        return 0;
    }

}

int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

System.Console.WriteLine("Введите число А и В");
System.Console.WriteLine(string.Join(", ", input) + " -> " + Result(input));

