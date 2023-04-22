Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1)
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
        System.Console.WriteLine($"{i}");
    
        }

    }
}
        else
        {
        Console.WriteLine("Number has to be bigger than 1"); 
        }
