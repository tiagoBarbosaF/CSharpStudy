using System;
using System.IO;

namespace FIleStreamStreamReader
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file1.txt";

            StreamReader streamReader = null;

            try
            {
                streamReader = File.OpenText(path);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}
