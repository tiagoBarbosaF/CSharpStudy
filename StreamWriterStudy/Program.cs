using System;
using System.IO;

namespace StreamWriterStudy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sourcepath = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file1.txt";
            string targetpath = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter streamWriter = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
