using System;

class ProblemaGrupo2
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (n1 + n2 + n3) / 3;

        Console.WriteLine("El promedio es: " + promedio);
    }
}