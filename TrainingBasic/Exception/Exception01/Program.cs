using System;

/// <summary>
/// namespace Exception01
/// </summary>
namespace Exception01
{
    /// <summary>
    /// class MyException
    /// </summary>
    class MyException : Exception
    {
        public MyException(string msg) : base(msg)
        {

        }
    }
    /// <summary>
    /// class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            try
            {
                //MyException not happen
                showResult(100);

                //MyException happen
                showResult(-2);
            }
            catch (MyException me)
            {
                Console.WriteLine(me.Message);
            }
        }

        /// <summary>
        /// show Result if number >0
        /// </summary>
        /// <param name="number"> number from key board</param>
        private static void showResult(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Number is greater than 0");
            }
            else
            {
                throw (new MyException("MyException: Number must be greater than 0"));
            }
        }
    }
}
