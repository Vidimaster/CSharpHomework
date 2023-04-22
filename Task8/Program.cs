Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
   if (i % 2 == 0)
   {
    System.Console.WriteLine($"{i}");
   }
}
