using System;
using System.IO;

namespace HTMLEditor
{
    public static class Save
    {
        public static void SaveFunc(string fileName, string text)
        {
            Console.Clear();
            Console.WriteLine($"Salvando o arquivo como '{fileName}'...");

            try
            {
                using (var file = new StreamWriter(fileName))
                {
                    file.Write(text);
                }
                Console.WriteLine($"\nO arquivo '{fileName}' foi salvo com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
