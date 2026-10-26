using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual o seu nome?: ");
        string Nome = Console.ReadLine();

        Console.WriteLine("Insira a data e hora do seu compromisso: ");
        string DataHoratxt = Console.ReadLine();

        DateTime DataHora = DateTime.ParseExact(
            DataHoratxt,
            "dd/MM/yyyy HH:mm",
            System.Globalization.CultureInfo.InvariantCulture
            );

        DateTime DataAtual = DateTime.Now;

        TimeSpan Dif = DataHora - DataAtual;

        int Dias = (int)Math.Ceiling(Dif.TotalDays);

        string DiaSemana = DataHora.ToString(
            "dddd",
            new CultureInfo("pt-BR")
        );

        string DataFormatada = DataHora.ToString(
            "dd/MM/yyyy 'às' HH:mm"
        );

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3}",
            Nome,
            Dias,
            DiaSemana,
            DataFormatada
        );

        Console.WriteLine(mensagem);
    }
}
