using System;

/// <summary>
/// name space DelegateEvent01
/// </summary>
namespace DelegateEvent01
{
    /// <summary>
    /// class program
    /// </summary>
    class Elements
    {
        static public int size = 5;
        private int[] arr = new int[size];

        //Contructor Elements
        public Elements()
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }
        }

        //Property Element
        public int this[int index]
        {
            //get
            //{
            //    int tmp;

            //    if (index >= 0 && index <= size - 1)
            //    {
            //        tmp = arr[index];
            //    }
            //    else
            //    {
            //        tmp = 0;
            //    }

            //    return (tmp);
            //}
            //set
            //{
            //    if (index >= 0 && index <= size - 1)
            //    {
            //        arr[index] = value;
            //    }
            //}
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
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
            Elements el = new Elements();
            el[0] = 1;
            el[1] = 2;
            el[2] = 3;
            el[3] = 4;
            el[4] = 5;

            for (int i = 0; i < Elements.size; i++)
            {
                Console.WriteLine(el[i]);
            }
            Console.ReadLine();
        }
    }
}
