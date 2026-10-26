using System.Globalization;

class Program
{
    static void Main()
    {
        double PercentualDesconto = 0.10;

        Console.WriteLine("---- CADASTRO DO EVENTO ----");

        Console.WriteLine("Insira o nome do evento: ");
        string NomeEvent = Console.ReadLine();

        Console.WriteLine("Insira a data do evento: ");
        string DataEvent = Console.ReadLine();

        Console.WriteLine("Insira o valor do ingreso: ");
        double ValorEvent = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a categoria: (VIP) ou (COMUM): ");
        string Categoria = Console.ReadLine();

        DateTime DataEventFormat = DateTime.ParseExact(
            DataEvent,
            "dd/MM/yyyy",
            System.Globalization.CultureInfo.InvariantCulture
            );

        Categoria = Categoria.ToUpper();

        if ((Categoria.Contains("VIP") && Categoria == "VIP") ||
            (Categoria.Contains("COMUM") && Categoria == "COMUM"))
        {
            Console.WriteLine("Categoria válida!");
        }
        else
        {
            Console.WriteLine("Categoria inválida!");
        }

        DateTime Agora = DateTime.Now;
        TimeSpan Contador = (DataEventFormat - Agora );

        int DiasRestantes = (int)Math.Ceiling(Contador.TotalDays);

        double Desconto = (ValorEvent * PercentualDesconto);
        double DescontoArr = Math.Round(Desconto, 2);

        double ValorFinal = (ValorEvent - DescontoArr);

        string Ingresso = string.Format(
            CultureInfo.GetCultureInfo("pt-BR"),
            "\n========================================\n" +
            "           INGRESSO DO EVENTO\n" +
            "========================================\n" +
            "Evento:          {0,-20}\n" +
            "Data:            {1:dd/MM/yyyy}\n" +
            "Categoria:       {2,-10}\n" +
            "Dias restantes:  {3,5}\n" +
            "Valor original:  {4,10:C}\n" +
            "Desconto (10%):  {5,10:C}\n" +
            "Valor final:     {6,10:C}\n" +
            "========================================",
            NomeEvent,
            DataEventFormat,
            Categoria,
            DiasRestantes,
            ValorEvent,
            DescontoArr,
            ValorFinal
        );


        Console.Write(Ingresso);
    }
}