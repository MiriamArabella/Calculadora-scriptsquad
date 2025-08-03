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


        // TODO: Implementar la lógica de menú
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has seleccioando la opcion de suma.");
                Console.Write("Ingrese el primer número: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Suma(num1, num2);
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                break;
        }

        // Fin de programa
        Console.WriteLine("Fin del programa");
        Console.ReadKey();
        Console.Clear();
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
    static void Suma(int num1, int num2)
    {
        Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
    }
}