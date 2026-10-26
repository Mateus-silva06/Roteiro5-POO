class Program
{
    public static void Main()
    {
        double[] num = new double[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"insira o {i + 1}° numero decimal: ");
            num[i] = double.Parse(Console.ReadLine());
        }

        double numArredondado = Math.Round(num[1]);
        double numArrebaixo = Math.Floor(num[2]);
        double numArreCima = Math.Ceiling(num[3]);
        double numTruncate = Math.Truncate(num[4]);

        Console.WriteLine($"numero original: {num[0]}");
        Console.WriteLine($"numero arredondado: {numArredondado}");
        Console.WriteLine($"numero arredondado para baixo: {numArrebaixo}");
        Console.WriteLine($"numero arredondado para cima: {numArreCima}");
        Console.WriteLine($"numero truncado: {numTruncate}");

    }
}