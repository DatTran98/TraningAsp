using System;

/// <summary>
/// namespace Namespace02
/// </summary>
namespace Namespace02
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
            var arr1 = new[] { 1, 2, 3, 4, 5, 6 };
            var arr2 = new[] { 6, 5, 4, 3, 2, 1 };
            Array.Copy(arr1, 0, arr2, 0, 6);

            //Array.ForEach(arr2, Console.WriteLine);
            //Console.WriteLine(string.Join("\n", arr2));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
        }
    }
}
