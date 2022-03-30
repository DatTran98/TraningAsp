using System;
using System.Text;

/// <summary>
/// name space DelegateEvent02
/// </summary>
namespace DelegateEvent02
{
    /// <summary>
    /// class ArrayDele
    /// </summary>
    class ArrayDele
    {
        private delegate int[] aDel(int[] arr);

        /// <summary>
        /// Main program
        /// </summary>
        /// <param name="args">Array param</param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] arr = EnterArray();
            string action = EnterAction();
            aDel result = ActionToArray(action);
            int[] arrResult = result(arr);
            Console.ReadKey();
        }

        /// <summary>
        /// Revert array
        /// </summary>
        /// <param name="arr">Array input </param>
        /// <returns>int[]: reverted array </returns>
        private static int[] ArrayRev(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("Reverted!");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }

        /// <summary>
        /// Sort array
        /// </summary>
        /// <param name="arr">Array input</param>
        /// <returns>int[]: sorted array</returns>
        private static int[] ArraySort(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted!");
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }
        private static int[] ArrayDefault(int[] arr)
        {
            return arr;
        }

        /// <summary>
        /// Choose action to do
        /// </summary>
        /// <param name="action">action entered</param>
        /// <returns>aDel: event fit to action entered </returns>
        private static aDel ActionToArray(string action)
        {
            if ("sort".Equals(action))
            {
                return ArrayDele.ArraySort;
            }
            else if ("rev".Equals(action))
            {
                return ArrayDele.ArrayRev;
            }
            return ArrayDele.ArrayDefault;
        }

        /// <summary>
        /// Enter array from the keyboard
        /// </summary>
        /// <returns>int[]: An array type int</returns>
        private static int[] EnterArray()
        {
            int size = 0;
            string strSize = "";

            while (!Int32.TryParse(strSize, out size))
            {
                Console.WriteLine("Enter the number of array: ");
                strSize = Console.ReadLine();
            }
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                string input = "";
                while (!Int32.TryParse(input, out arr[i]))
                {
                    Console.Write($"Array[{i}]: ");
                    input = Console.ReadLine();
                }
            }
            return arr;
        }

        /// <summary>
        /// Enter the action
        /// </summary>
        /// <returns>string: action to do</returns>
        private static string EnterAction()
        {
            ////Loop input until action is Rev/ Sort
            var arrAction = new[] { "rev", "sort" };
            Console.WriteLine("Enter a action: ");
            string action = "";
            action = Console.ReadLine();

            //Check action is correct?
            while (Array.IndexOf(arrAction, action) < 0)
            {
                Console.WriteLine("Action must be rev/ sort. Please enter: ");
                action = Console.ReadLine();
            }
            return action;
        }
    }
}