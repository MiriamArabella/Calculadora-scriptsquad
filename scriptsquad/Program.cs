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

        // Lógica de resta
        Console.WriteLine($"Restando {a} - {b}");
        
        MostrarResultadoSuma(a, b);
    
    {
        Console.WriteLine($"Resultado de la suma: {a + b}");
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división
}

    private static void MostrarResultadoSuma(int a, int b)
    {
        throw new NotImplementedException();
    }
}
