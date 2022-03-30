using System;

/// <summary>
/// Name space cSharpBasic03
/// </summary>
namespace cSharpBasic03
{
    /// <summary>
    /// class Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string strInput1 = "";
            string strInput2 = "";
            string action = "";

            Console.WriteLine("Please enter 2 number and a action:");

            //Loop input until data type is int
            do
            {
                Console.WriteLine("Frirst number: ");
                strInput1 = Console.ReadLine();
            }
            while (!int.TryParse(strInput1, out num1));

            //Loop input until data type is int
            do
            {
                Console.WriteLine("Second number: ");
                strInput2 = Console.ReadLine();
            }
            while (!int.TryParse(strInput2, out num2));

            ////Loop input until action is Add/ Subtract/ Multiply/ Divide
            var arrAction = new[] { "Add", "Subtract", "Multiply", "Divide" };
            Console.WriteLine("Enter a action: ");
            action = Console.ReadLine();

            //Check action is correct?
            while (Array.IndexOf(arrAction, action) < 0)
            {
                Console.WriteLine("Action must be Add/ Subtract/ Multiply/ Divide. Please enter: ");
                action = Console.ReadLine();
            }

            //Show the result in the screen
            if (String.Equals(action, "Add"))
            {
                Console.WriteLine($"Number1 + Number 2 = {num1 + num2}");
            }
            else if (String.Equals(action, "Subtract"))
            {
                Console.WriteLine($"Number1 - Number 2 = {num1 - num2}");
            }
            else if (String.Equals(action, "Multiply"))
            {
                Console.WriteLine($"Number1 * Number 2 = {num1 * num2}");
            }
            else if (String.Equals(action, "Divide"))
            {
                Console.WriteLine($"Number1 / Number 2 = {num1 / num2}");
            }
            Console.ReadKey();
        }
    }
}
