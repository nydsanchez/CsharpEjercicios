using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Selecciona un ejercicio:");
        Console.WriteLine("1. Saludo");
        Console.WriteLine("2. Suma de números");
        Console.WriteLine("3. Número par o impar");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Ejercicio1.Ejecutar();
                break;
            case "2":
                Ejercicio2.Ejecutar();
                break;
            case "3":
                Ejercicio3.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}