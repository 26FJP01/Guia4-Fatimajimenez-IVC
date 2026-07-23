internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========DATOS ACADEMICOS=========");
        Console.WriteLine("Nombre: Fatima Jimenez-Grado: IVC - Clave:15");
        Console.WriteLine("=== CALCULADORA DE IMC ===");
        Console.Write("Ingrese su peso en kg (ej. 70.5): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese su altura en metros (ej. 1.75): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine($"\nsu Índice de Masa Corporal (IMC) es: {Math.Round(imc, 2)}");
    }
}