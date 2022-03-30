using System;

/// <summary>
/// namespace DelegateEvent04
/// </summary>
namespace DelegateEvent04
{
    public delegate void GetBodyTemp();

    /// <summary>
    /// class animal
    /// </summary>
    class Animals
    {
        public event GetBodyTemp GetBT;
        private int _BodyTemp;
        public int BodyTemp
        {
            get
            {
                //call event if get data
                if (GetBT != null)
                {
                    GetBT();
                }
                return _BodyTemp;
            }
            set
            {
                _BodyTemp = value;
            }
        }

    }

    /// <summary>
    /// class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            animal.BodyTemp = 100;
            animal.GetBT += GotBT;

            Console.WriteLine("Body temp: " + animal.BodyTemp);
        }

        /// <summary>
        /// show in screen when call event
        /// </summary>
        private static void GotBT()
        {
            Console.WriteLine("Event! ");
        }
    }
}
