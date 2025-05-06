using System;
using System.Collections.Generic;

namespace tpConsole.Exercicios
{
    internal class LoogerV2
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public void LogToFile(string message)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, $"[Arquivo] {message}{Environment.NewLine}");
        }

        public void LogToDatabase(string message)
        {
            Console.WriteLine($"[Banco de Dados] {message}");
        }
    }
    internal class Exercicio07
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 07 --");

            LoogerV2 logger = new LoogerV2();

            Action<string> logDelegate = null;

            //logDelegate += logger.LogToConsole;
            //logDelegate += logger.LogToFile;
            //logDelegate += logger.LogToDatabase;

            Console.Write("Digite uma mensagem para ser registrada: ");
            string message = Console.ReadLine();

            logDelegate?.Invoke(message);
            Console.WriteLine("Mensagem registrada com sucesso!");
        }
    }
}
