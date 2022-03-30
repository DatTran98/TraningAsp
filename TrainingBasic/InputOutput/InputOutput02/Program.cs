using System;
using System.IO;

/// <summary>
/// namespace InputOutput02
/// </summary>
namespace InputOutput02
{
    /// <summary>
    /// class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name: ");
            string resourceFile = Console.ReadLine();
            Console.WriteLine("Enter the directory: ");
            string desDirrectory = Console.ReadLine();

            //check resource file exists?
            if (File.Exists(resourceFile))
            {
                if (!Directory.Exists(desDirrectory))
                {
                    Directory.CreateDirectory(desDirrectory);
                }
                //if destination file is exists in destination dirrectory, delete destination file
                if (File.Exists(desDirrectory + "\\copyFile.txt"))
                {
                    File.Delete(desDirrectory + "\\copyFile.txt");
                }

                //Copy by IOStream
                //File.Copy(resourceFile, desDirrectory + "\\copyFile.txt");

                //Copy by Reader
                string arrReader = File.ReadAllText(resourceFile);
                File.Create(desDirrectory + "\\copyFile.txt").Dispose();
                using (var desFile = File.AppendText(desDirrectory + "\\copyFile.txt"))
                {
                    desFile.WriteLine(arrReader);
                }

                Console.WriteLine("Copied!");
            }
            else
            {
                Console.WriteLine("File is not exist!");
            }
            Console.ReadKey();
        }
    }
}
