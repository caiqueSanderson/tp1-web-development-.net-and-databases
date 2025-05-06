using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpConsole.Exercicios
{
    internal class Looger
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
    internal class Exercicio06
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 06 --");

            Looger logger = new Looger();

            Action<string> logDelegate = logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            Console.Write("Digite uma mensagem para ser registrada: ");
            string message = Console.ReadLine();

            logDelegate(message);

            Console.WriteLine("Mensagem registrada com sucesso!");
        }
    }
}
