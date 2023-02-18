using System;

public class Funciones
{
    public static void sumar() 
    {
        int num1, num2;
        Console.WriteLine("ingrese dos valores a sumar");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"el valor resultante es: {num1+num2}");

    }
    public static void restar()
    {
        int num1, num2;
        Console.WriteLine("ingrese dos valores a restar");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"el valor resultante es: {num1 - num2}");

    }
    public static void dividir()
    {
        int num1, num2;
        Console.WriteLine("ingrese dos valores a dividir");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"el valor resultante es: {num1 / num2}");

    }
    public static void multiplicacion()
    {
        int num1, num2;
        Console.WriteLine("ingrese dos valores a sumar");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"el valor resultante es: {num1 * num2}");

    }
    public static void powering()
    {
        int num1, num2;
        Console.WriteLine("ingrese valor a potenciar");
        num1 = int.Parse(Console.ReadLine());
        const int num3 = num1;
        Console.WriteLine("ingrese veces a potenciar");
        num2 = int.Parse(Console.ReadLine());
        for (int i = 0;i < num2; i++) 
        {
            num1 = num1 * num3;
        }
        Console.WriteLine($"el valor resultante es: {num1}");

    }
}

