internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=======DATOS ACADEMICOS========");
        Console.WriteLine("Nombre: Fatima Jimenez\n" + "Grado: IVC - Clave:15\n");
        Console.Write("Introduce una frase: ");
        string frase = Console.ReadLine();
        string fraseInvertida = "";
        for (int i = frase.Length - 1; i >= 0; i--)
        {
            fraseInvertida += frase[i];
        }
        Console.WriteLine("\nLa frase invertida es:");
        Console.WriteLine(fraseInvertida);
    }
}