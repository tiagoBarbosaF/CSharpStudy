using System;
using System.IO;

namespace FileFileInfo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file1.txt";
            string targetPath = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                Console.WriteLine("File copy sucess!");
                Console.WriteLine();

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.Write(line);
                    Console.WriteLine($" - Qtd characteres on line: {line.Length}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocorrer");
                Console.WriteLine(e.Message);
            }
        }
    }
}
