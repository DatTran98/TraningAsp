using System;

/// <summary>
/// namespace OOP01
/// </summary>
namespace OOP01
{
    /// <summary>
    /// class B
    /// </summary>
    public class B
    {
        public B() { }

        /// <summary>
        /// method SM
        /// </summary>
        public static void SM()
        {
            Console.WriteLine("Hello from B.SM().");
        }

        /// <summary>
        /// method VIM
        /// </summary>
        public virtual void VIM()
        {
            Console.WriteLine("Hello from B.VIM().");
        }

        /// <summary>
        /// method NIM
        /// </summary>
        public void NIM()
        {
            Console.WriteLine("Hello from B.NIM().");
        }

    }

    /// <summary>
    /// class C
    /// </summary>
    class C : B
    {
        /// <summary>
        /// method VIM
        /// </summary>
        public void VIM()
        {
            Console.WriteLine("Hello from C.VIM().");
        }
    }

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
            B b = new B();
            C c = new C();
            b.VIM();
            b.NIM();
            c.VIM();
            c.NIM();
        }
    }
}
