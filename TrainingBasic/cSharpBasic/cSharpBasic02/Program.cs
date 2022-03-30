using System;

/// <summary>
/// Name space cSharpBasic02
/// </summary>
namespace cSharpBasic02
{
    /// <summary>
    /// Class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            string userName = "";
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("User Name: ");
                userName = Console.ReadLine();
                if (userName == "Scrappy")
                {
                    Console.WriteLine("Scrappy was the name entered by the user.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
