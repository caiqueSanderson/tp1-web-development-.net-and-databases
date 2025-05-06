using System;
using System.Collections.Generic;

namespace tpConsole.Exercicios
{
    internal class DownloadManager
    {
        public event Action DownloadCompleted;
        public void StartDownload()
        {
            Console.WriteLine($"Iniciando download...");

            Thread.Sleep(2000);
            Console.WriteLine("Processando...");
            DownloadCompleted?.Invoke();
        }
    }
    internal class Exercicio05
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 05 --");

            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Download concluído com sucesso!");
                Console.ResetColor();
            };

            manager.StartDownload();
        }
    }
}
