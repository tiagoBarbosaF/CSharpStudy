using System;
using System.IO;

namespace BlockUsing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = @"/Users/tiagobarbosa/Documents/Estudos/Programação/Udemy/C# - COMPLETO/ProjectsCSharpStudy/FilesTest/file1.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            //try
            //{
            //    using (FileStream fileStream = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader streamReader = new StreamReader(fileStream))
            //        {
            //            while (!streamReader.EndOfStream)
            //            {
            //                string line = streamReader.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
