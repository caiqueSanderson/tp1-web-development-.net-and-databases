using System;
using System.Collections.Generic;

namespace tpConsole.Exercicios
{
    internal class TemperatureSensor
    {
        public event Action<double> TemperatureExceeded;

        public void ReadTemperature(double temperature)
        {
            Console.WriteLine($"Temperatura lida: {temperature}°C");
            if (temperature > 100)
            {
                TemperatureExceeded?.Invoke(temperature);
            }
        }
    }

    internal class Exercicio04
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 04 --");

            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += (temp) => Console.WriteLine($"Alerta! Temperatura excedida: {temp}°C");

            while (true)
            {
                Console.Write("Digite a temperatura (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "sair")
                {
                    break;
                }

                if (double.TryParse(input, out double temperature))
                {
                    sensor.ReadTemperature(temperature);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}
