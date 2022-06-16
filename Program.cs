using System;

namespace Automovel 
{
    class Teste
    {
        static void Main(string[] args)
        {
            Automovel auto01 = new Automovel("FCI5F27", "FIAT Toro", 2, "vinho", 2022);
            byte a = auto01.combustivel;
            double v = auto01.calcularPreco(a);
            Console.WriteLine($"O preço final do automóvel é R${v}");

            AutomovelLuxo autoLuxo01 = new AutomovelLuxo("FCI5F27", "FIAT Toro", 4, "vinho", 2022, true, true, true);
            byte b = autoLuxo01.combustivel;
            double x = autoLuxo01.calcularPreco(b);
            Console.WriteLine($"O preço final do automóvel de luxo é R${x}");
        }
    }
}