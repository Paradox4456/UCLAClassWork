using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        float y = 5.5f;
        double z = 2.5;

        int sum = x + (int)y;
        Console.WriteLine("x + y = " + sum);

        float difference = y - (float)z;
        Console.WriteLine("y - z = " + difference);

        double product = x * z;
        Console.WriteLine("x * z = " + product);

        double quotient = x / z;
        Console.WriteLine("x / z = " + quotient);

        double sqrt = Math.Sqrt(x);
        Console.WriteLine("Square Root of X = " + sqrt);

        double sin = Math.Sin(x);
        Console.WriteLine("Sine of y  = " + sin);

        double cos = Math.Cos(z);
        Console.WriteLine("Cosine of z = " + cos);
        
        Console.WriteLine("The Program has completed click enter to close!");
        Console.ReadLine();

    }
}