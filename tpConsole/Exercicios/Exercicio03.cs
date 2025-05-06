using System;
using System.Collections.Generic;

namespace tpConsole.Exercicios
{
    internal class Exercicio03
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 03 --");

            Console.Write("Digite a base do retângulo (em metros): ");
            string baseInput = Console.ReadLine();

            Console.Write("Digite a altura do retângulo (em metros): ");
            string heightInput = Console.ReadLine();

            if (!double.TryParse(baseInput, out double baseValue) || !double.TryParse(heightInput, out double heightValue))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira números válidos.");
                return;
            }

            Func<double, double, double> calculateArea = (b, h) => b * h;

            double area = calculateArea(baseValue, heightValue);
            Console.WriteLine($"A área do retângulo é: {area:F2} m²");
        }
    }
}
