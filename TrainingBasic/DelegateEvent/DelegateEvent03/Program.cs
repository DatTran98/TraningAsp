using System;

/// <summary>
/// namespace DelegateEvent03
/// </summary>
namespace DelegateEvent03
{
    //Create event GotFive() 
    public delegate void GotFive();

    /// <summary>
    /// class program
    /// </summary>
    class Program
    {
        //Create event
        public static event GotFive Got5;

        /// <summary>
        /// Main progrsm
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            Got5 += Got5Number;

            //If the user enters the number 5 call event 
            if (Enter5Number() == 5)
            {
                Got5();
            }
            else
            {
                Console.WriteLine("No event!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Enter 5 input
        /// </summary>
        /// <returns>Number of input type int entered</returns>
        private static int Enter5Number()
        {
            Console.WriteLine("Enter 5 numbers: ");
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                string strInput = Console.ReadLine();
                int intInput = 0;
                if (Int32.TryParse(strInput, out intInput))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Do while event happen
        /// </summary>
        private static void Got5Number()
        {
            Console.WriteLine("Event: You got 5 number!");
        }
    }
}
