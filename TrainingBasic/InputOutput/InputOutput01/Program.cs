using System;
using System.IO;

/// <summary>
/// namespace InputOutput01
/// </summary>
namespace InputOutput01
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
            string path = @"C:\Users\dattb\Documents\Member\Mem\InputOutput\User.txt";
            if (File.Exists(path))
            {
                ////Count number of line by read all line ---> wrong when last line don't have any character
                //lines = File.ReadAllLines(path);
                //Console.WriteLine($"Number of line: { lines.Length}");

                //Read all text 
                String text = File.ReadAllText(path);

                Console.WriteLine("Number of line: " + text.Split('\n').Length);

                //Read number of character
                Console.WriteLine("Number of character " + text.Length);

                //Read nunber of word
                char[] delimiters = new char[] { ' ', '\t', '\n', '\r' };
                int countWord = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
                Console.WriteLine("Number of word: " + countWord);
            }
            else
            {
                Console.WriteLine("File does not exists!");
            }
            Console.ReadKey();
        }
    }
}
