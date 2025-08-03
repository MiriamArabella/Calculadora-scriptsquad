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

        switch (opcion)
        {
            case 2:
            Resta();
            break;
            
            case 3:
            Multiplicar();
            break;
            default:
            Console.WriteLine("Opciíon no válida o no implementada aún.");
            break;
        }
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

    }
      static void Multiplicación()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el Segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 * num2;
        Console.Write($"El resultado de la multiplicación es: {resultado}");

      }
}
