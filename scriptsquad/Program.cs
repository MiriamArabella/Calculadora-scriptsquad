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
            case 3:
            Multiplicar();
            break;
            default:
            Console.WriteLine("Opciíon no válida o no implementada aún.");
            break;
        }
    }

    static void Multiplicación()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.parse(Console.ReadLine());

        Console.Write("Ingrese el Segundo número: ");
        double num2 = double.parse(Console.ReadLine());

        double resultado = num1 * num2;
        Console.Write($"El resultado de la multiplicación es: (resultado)");
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
}