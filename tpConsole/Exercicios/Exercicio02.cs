using System;
using System.Collections.Generic;

namespace tpConsole.Exercicios
{
    internal class Exercicio02
    {
        public void Main()
        {
            Console.WriteLine("\n-- Exercicio 02 --");
            Console.WriteLine("Idiomas disponíveis: ");
            Console.WriteLine("1. Português");
            Console.WriteLine("2. Inglês");
            Console.WriteLine("3. Espanhol");

            Console.Write("Insira o número do idioma desejado: ");
            string option = Console.ReadLine();

            Action<string> welcomePt = name => Console.WriteLine($"Seja muito bem-vindo, {name}!");
            Action<string> welcomeEn = name => Console.WriteLine($"Welcome, {name}!");
            Action<string> welcomeEs = name => Console.WriteLine($"Bienvenido, {name}!");

            Console.Write("Digite seu nome: ");
            string userName = Console.ReadLine();

            Action<string> welcomeAction;

            switch (option)
            {
                case "1":
                    welcomeAction = welcomePt;
                    break;
                case "2":
                    welcomeAction = welcomeEn;
                    break;
                case "3":
                    welcomeAction = welcomeEs;
                    break;
                default:
                    Console.WriteLine("Idioma inválido. Usando português por padrão.");
                    welcomeAction = welcomePt;
                    break;
            }

            welcomeAction(userName);
        }
    }
}
