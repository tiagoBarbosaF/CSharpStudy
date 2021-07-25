using System;
using System.IO;

namespace PathStudy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file1.txt";

            Console.WriteLine($"DirectorySeparatorChar => {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator => {Path.PathSeparator}");
            Console.WriteLine($"GetDirectoryName => {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName => {Path.GetFileName(path)}");
            Console.WriteLine($"GetExtension => {Path.GetExtension(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension => {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetFullPath => {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath => {Path.GetTempPath()}");
        }
    }
}
