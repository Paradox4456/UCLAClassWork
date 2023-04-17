using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        double y = 3.14;
        float z = 2.5f;

        int sum = x + (int)y;
        Console.WriteLine("x + y = " + sum);

        float difference = (float)y - z;
        Console.WriteLine("y - z = " + difference);

        double product = x * z;
        Console.WriteLine("x * z = " + product);

        double quotient = x / z;
        Console.WriteLine("x / z = " + quotient);
    }
}