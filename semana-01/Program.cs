using System;

class Program
{
    static void Main()
    {
        
    }
    static void Ejercicio1()
    {
        Console.Write("Introduce tu nombre: ");
        string nombreUsuario = Console.ReadLine()!;

        Console.Write("Introduce tu edad: ");
        int edadUsuario = int.Parse(Console.ReadLine()!);

        Console.Write("Introduce tu altura: ");
        double alturaUsuario = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce un número entero: ");
        int primerNumeroUsuario = int.Parse(Console.ReadLine()!);
        Console.Write("Introduce otro número entero: ");
        int segundoNumeroUsuario = int.Parse(Console.ReadLine()!);

        int sumaEnteros = primerNumeroUsuario + segundoNumeroUsuario;
        int productoEnteros = primerNumeroUsuario * segundoNumeroUsuario;

        Console.WriteLine("---- FICHA ----");
        Console.WriteLine($"Nombre: {nombreUsuario}");
        Console.WriteLine($"Edad: {edadUsuario}");
        Console.WriteLine($"Altura: {alturaUsuario}");
        Console.WriteLine($"Suma: {primerNumeroUsuario} + {segundoNumeroUsuario} = {sumaEnteros} ");
        Console.WriteLine($"Producto: {primerNumeroUsuario} * {segundoNumeroUsuario} = {productoEnteros}");
        Console.WriteLine("----------------"); 
    }

    static void Ejercicio2()
    {
        Console.Write("Introduce la cantidad en euros (€): ");
        double eurosUsuario = double.Parse(Console.ReadLine()!);

        double dolaresUsuario = eurosUsuario * 1.07;
        double yenesUsuario = eurosUsuario * 161.2;

        Console.WriteLine($"{eurosUsuario}€ son {dolaresUsuario}$ y {yenesUsuario}¥");
    }
}



