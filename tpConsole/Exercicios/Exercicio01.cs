using System;

namespace tpConsole.Exercicios
{
    internal class Exercicio01
    {
        public delegate decimal CalculateDiscount(decimal price);

        public static decimal DiscountTenPercent(decimal price)
        {
            return price * 0.9m;
        }

        public void Main()
        {
            Console.WriteLine("-- Exercicio 01 --");

            Console.Write("Insira o preço original do produto: ");
            string originalPrice = Console.ReadLine();

            if (decimal.TryParse(originalPrice, out decimal originalPriceDecimal) == false)
            {
                Console.WriteLine("Valor inválido.");
                return;
            }

            CalculateDiscount priceWithDiscountTenPercent = DiscountTenPercent;
            decimal discountedPrice = priceWithDiscountTenPercent(originalPriceDecimal);

            Console.WriteLine($"Preço Original: R${originalPrice}");
            Console.WriteLine($"Preço com desconto: R${discountedPrice:F2}");
        }
    }
}
