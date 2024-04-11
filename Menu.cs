using System;
using System.Data;
using System.Threading;
using System.Linq.Expressions;
namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            DrawScreen();
            WriteOption();
            double? option = null;
            while (option == null || option < 0 || option > 2)
            {
                // Console.Write("Option: ");
                var input = Console.ReadLine();
                if (!double.TryParse(input, out double result))
                {
                    Console.WriteLine("Opção invalida. Porvafor Digite um valor entre 0 e 2");
                    Console.Write("\nDigite o valor novamnete: ");
                }
                else
                {
                    option = result;
                    if (option < 0 || option > 2)
                    {
                        Console.WriteLine("Opção invalida. Porvafor Digite um valor entre 0 e 2");
                        Console.Write("Digite o valor novamnete: ");
                    }
                }
            }
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Line01();
            Colunes();
            Line01();
        }
        static void Line01()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i += 1)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        static void Colunes()
        {
            for (int line = 0; line <= 10; line += 1)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i += 1)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }
        public static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- Novo Arquivo.");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir Arquivo.");

            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0- Sair.");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(double? option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Open.OpenFunc(); break;
                case 0:
                    {
                        Console.Clear();
                        Finalization();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
        public static void Finalization()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Saindo da aplicação...");
            Thread.Sleep(1000);
        }
    }
}
