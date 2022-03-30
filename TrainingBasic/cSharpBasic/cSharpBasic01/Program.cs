using System;

/// <summary>
/// Name space cSharpBasic01
/// </summary>
namespace cSharpBasic01
{
    /// <summary>
    /// class  Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Program
        /// </summary>
        /// <param name="args"> Array param</param>
        static void Main(string[] args)
        {
            string userName = "";
            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Your name is {userName}");
            Console.ReadKey();
        }
    }
}
