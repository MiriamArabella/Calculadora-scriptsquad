using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 2)
        {
            Resta();
        }
        // TODO: Implementar la lógica de menú

    }
    static void Resta()
    {
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine());
        int resultado = a - b;


        // Lógica de resta
        Console.WriteLine($"Restando {a} - {b}");
        Console.WriteLine($"Resultado de la resta: {resultado}");






        // TODO: Implementar funciones de suma, resta, multiplicación, división
    }

}
