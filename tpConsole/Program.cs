namespace tpConsole
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Menu de Exercicios ---");
            Console.WriteLine("1. Exercicio 01 - Implementação de Delegate Personalizado para Descontos");
            Console.WriteLine("2. Exercicio 02 - Ações Multilíngues com Action<string>");
            Console.WriteLine("3. Exercicio 03 - Cálculo de Área Utilizando Func");
            Console.WriteLine("4. Exercicio 04 - Monitoramento de Temperatura com Evento Personalizado");
            Console.WriteLine("5. Exercicio 05 - Notificação de Conclusão de Download com Eventos");
            Console.WriteLine("6. Exercicio 06 - Sistema de Registro com Multicast Delegate");
            Console.WriteLine("7. Exercicio 07 - Garantia de Robustez em Invocação de Delegates");

            Console.Write("\nInsira sua escolha: ");
            string option = Console.ReadLine();

            switch (option.Trim())
            {
                case "1":
                    var exercicio01 = new Exercicios.Exercicio01();
                    exercicio01.Main();
                    break;
                case "2":
                    var exercicio02 = new Exercicios.Exercicio02();
                    exercicio02.Main();
                    break;
                case "3":
                    var exercicio03 = new Exercicios.Exercicio03();
                    exercicio03.Main();
                    break;
                case "4":
                    var exercicio04 = new Exercicios.Exercicio04();
                    exercicio04.Main();
                    break;
                case "5":
                    var exercicio05 = new Exercicios.Exercicio05();
                    exercicio05.Main();
                    break;
                case "6":
                    var exercicio06 = new Exercicios.Exercicio06();
                    exercicio06.Main();
                    break;
                case "7":
                    var exercicio07 = new Exercicios.Exercicio07();
                    exercicio07.Main();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
