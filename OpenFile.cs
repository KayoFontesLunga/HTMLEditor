using System;

namespace HTMLEditor
{
    public static class Open
    {
        public static void OpenFunc()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                var text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu.Show();
        }
    }
}