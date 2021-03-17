using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectory
{
    class Program
    {
        static string path = @"F:\test.txt";
        static string path1 = @"F:\test1.txt";
        static string directory = @"C:\Users";

        static void Main(string[] args)
        {
            //Write();
            //Read();
            //WriteFile();
            //ReadFile();
            //AllDirectory();
            //AllFiles();
            Names();
            Console.ReadLine();
        }


        public static void Write()
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Leo Messi!!!");
                sw.Write("Barcelona!!");

                sw.Close();
            }
        }


        public static void Read()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string line = null;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                
            }
        }

        public static void WriteFile()
        {
            FileStream fs = new FileStream(path1, FileMode.Append, FileAccess.Write);
            StreamWriter ws = new StreamWriter(fs);
            Console.WriteLine("Enter text!!");
            string str = Console.ReadLine();
            ws.WriteLine(str);
            ws.Close();
        }

        public static void ReadFile()
        {
            FileStream fs = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = null;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
        }

        public static void AllDirectory()
        {
            string[] dirs = Directory.GetDirectories(directory);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
        }

        public static void AllFiles()
        {
            string[] files= Directory.GetFiles(directory);

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }

        public static void Names()
        {
            string[] names = { "Daniel", "Stefani", "Tomi", "Teo" };

            string textPath = @"F:\name.txt";

            File.WriteAllLines(textPath, names);

            foreach (string item in File.ReadAllLines(textPath))
            {
                Console.WriteLine(item);
            }
        }
    }
}
