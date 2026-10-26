class Program
{
    static void Main()
    {
        string Produto1 = "Shape Element";
        double Preco1 = 350;
        int quant1 = 2;

        string Produto2 = "Lixa Jessup";
        double Preco2 = 60;
        int quant2 = 1;

        string Produto3 = "Truck Truriun";
        double Preco3 = 190.90;
        int quant3 = 1;

        double P1_total = (Preco1 * quant1);
        double P2_total = (Preco2 * quant2);
        double P3_total = (Preco3 * quant3);

        double Subtotal = (P1_total + P2_total + P3_total);
        double Desconto = (Subtotal * 0.10);
        double ValorFinal = (Subtotal - Desconto);

        Console.WriteLine($"{"Produto",-20} {"Preço",12} {"Qtd",5} {"Total",12}");
        Console.WriteLine(new string('-', 53));

        Console.WriteLine($"{Produto1,-20} {Preco1,12:C} {quant1,5} {P1_total,12:C}");
        Console.WriteLine($"{Produto2,-20} {Preco2,12:C} {quant2,5} {P2_total,12:C}");
        Console.WriteLine($"{Produto3,-20} {Preco3,12:C} {quant3,5} {P3_total,12:C}");

        Console.WriteLine(new string('-', 53));

        Console.WriteLine($"{"Subtotal:",-20} {Subtotal,12:C}");
        Console.WriteLine($"{"Desconto (10%):",-20} {Desconto,12:C}");
        Console.WriteLine($"{"Desconto percentual:",-20} {0.10,12:P}");
        Console.WriteLine($"{"Total final:",-20} {ValorFinal,12:C}");

        Console.WriteLine($"Subtotal (F2): {Subtotal:F2}");
        Console.WriteLine($"Subtotal (N): {Subtotal:N}");

    }
}