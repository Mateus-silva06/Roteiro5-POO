class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva uma frase: ");
        string Frase = Console.ReadLine();

        Console.WriteLine(Frase.Trim( ));
        Console.WriteLine(Frase.Split(','));
        Console.WriteLine(Frase.Replace("Mateus", "Josenildo"));
        Console.WriteLine(Frase.StartsWith("Ola"));
        Console.WriteLine(Frase.EndsWith("adeus"));

        string[] partes = Frase.Split(',');

        foreach (string parte in partes)
        {
            Console.WriteLine(parte);
        }
    }

}