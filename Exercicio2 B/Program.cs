class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu CPF: ");
        string cpf = Console.ReadLine();

        cpf = cpf.Trim().Replace(".", "").Replace("-", "").Replace(" ", "");

        if(cpf.Length == 11)
        {
            cpf.StartsWith("1");

            string CpfFormatado = cpf.Substring(0, 3) + "." +
                               cpf.Substring(3, 3) + "." +
                               cpf.Substring(6, 3) + "-" +
                               cpf.Substring(9, 2);

            Console.Write($"Cpf formatado: {CpfFormatado} ");
        }
    }
}