using System;
using System.Text;
using EditorHtml;
using Microsoft.VisualBasic;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("============");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.AppendLine(Console.ReadLine());
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("=========");
            Console.WriteLine("Deseja salvar o arquivo? (y/n)");

            char saveOp;
            while (!char.TryParse(Console.ReadLine(), out saveOp) || (saveOp != 'y' && saveOp != 'n'))
            {
                Console.WriteLine("Opção inválida. Por favor, digite 'y' para salvar ou 'n' para não salvar:");
            }

            if (saveOp == 'y')
            {
                Console.WriteLine("Digite o nome do arquivo para salvar:");
                string fileName = Console.ReadLine();
                Save.SaveFunc(fileName, file.ToString());
                Console.WriteLine("Arquivo salvo com sucesso!");
            }
            else
            {
                Console.WriteLine("Arquivo não salvo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para ir ao visualizador...");
            Console.ReadKey();
            Viewer.Show(file.ToString());
        }
    }
}