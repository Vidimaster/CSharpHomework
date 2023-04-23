Console.WriteLine("Enter number");
int N1 = Convert.ToInt32(Console.ReadLine());
int N2 = N1;
int N3 = N1;
int digit = 0;
int i = 0;
if (N1 / 100 != 0)
{
    while (N1 > 0)
    {
       N1 = N1 / 10; 
       i++;
    }
    for (int j = i; j>=1; j--)
    {
        if (j==3)
        {
            digit = (N2 - (N2 / 100 * 100)) % 10;
            System.Console.WriteLine($"The third digit is: {N3} -> {digit}");
        }
        N2 = N2 / 10;
    }
}
else
{
    System.Console.WriteLine($"{N1} -> There is no third digit");
}
