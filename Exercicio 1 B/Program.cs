class Program
{
    static void Main()
    {
        double CapInicial;
        double TaxaJuros;
        int N;

        Console.WriteLine("Qual sua meta para esse investimento?: ");
        double Meta = double.Parse(Console.ReadLine());

        Console.WriteLine("insira seu capital inicial: ");
        CapInicial = double.Parse(Console.ReadLine());

        Console.WriteLine("insira a taxa de juros do investimento: ");
        TaxaJuros = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantos meses de investimento?: ");
        N = int.Parse(Console.ReadLine());

        double I = (1 + TaxaJuros / 100);
        double Pot = Math.Pow(I, N);

        double Montante = (CapInicial * Pot);

        double Lucro = Montante - CapInicial;
        double LucroArr = Math.Round(Lucro, 2);

        Console.WriteLine($"O montante final do investimento foi: R${Montante:F2}, com seu lucro de {LucroArr:F2} ");

        if(Lucro > Meta)
        {
            Console.Write("Seu investimento superou sua meta");
        }
        else if(Lucro == Meta)
        {
            Console.Write("Seu investimento atingiu a meta");
        }
        else
        {
            Console.Write("Seu investimento nao atingiu a meta");
        }

    }
}