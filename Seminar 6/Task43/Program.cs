double AreLinesCrossedX(double k1, double k2, double b1, double b2)
{
double x = (b2 - b1)/(k1 - k2);
return x;
}
double AreLinesCrossedY(double k1, double x, double b1)
{
double y = k1 * x + b1;
return y;
}
double ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}
double k1 = ReadInt("Введите k1");
double k2 = ReadInt("Введите k2");
double b1 = ReadInt("Введите b1");
double b2 = ReadInt("Введите b2");
double coordsX = AreLinesCrossedX (k1, k2, b1, b2);
double coordsY  = AreLinesCrossedY (k1, coordsX, b1);
System.Console.WriteLine($"{coordsX}, {coordsX}");
