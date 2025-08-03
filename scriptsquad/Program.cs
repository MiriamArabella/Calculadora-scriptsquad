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
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());


        // TODO: Implementar la lógica de menú
        switch (opcion)
        {
            case 1:
                Suma();
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
            
                break;
            case 5:
                Console.WriteLine("Saliendo de la calculadora...");
                return;
            default:
                Console.WriteLine("Opciíon no válida o no implementada aún.");
                break;
        }

        // Fin de programa
        Console.WriteLine("Fin del programa");
        Console.ReadKey();
        Console.Clear();
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    static void Suma()
    {
        Console.WriteLine("Ingrese el primer número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        int b = int.Parse(Console.ReadLine());
        int resultado = a + b;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }

    
    
}