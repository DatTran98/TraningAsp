using System;
using System.IO;
using System.Text;

/// <summary>
///  namespace InputOutput03
/// </summary>
namespace InputOutput03
{
    /// <summary>
    /// class User
    /// </summary>
    class User
    {
        public string userName;
        public int age;
        public string address;
        public float score;
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
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"C:\Note\User.txt";
            EnterUser(path);
            SortByUserName(path);
            TotalScore(path);
        }

        /// <summary>
        /// Enter user infor and write into the file
        /// </summary>
        /// <param name="path">path file to write</param>
        private static void EnterUser(string path)
        {
            User user = new User();
            Console.Write("Enter number of user: ");
            string strNumUser = Console.ReadLine();
            int numUser = 0;
            while (!Int32.TryParse(strNumUser, out numUser))
            {
                Console.WriteLine("Please enter a number! ");
                strNumUser = Console.ReadLine();
            }
            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine($"==============User {i + 1}================ ");
                Console.Write("User name: ");
                user.userName = Console.ReadLine();
                Console.Write("Age: ");
                Int32.TryParse(Console.ReadLine(), out user.age);
                Console.Write("Address: ");
                user.address = Console.ReadLine();
                Console.Write("Score: ");
                float.TryParse(Console.ReadLine(), out user.score);


                //Tạo file để lưu thông tin nhập vào
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }

                //Ghi vao file
                using (var txtFile = File.AppendText(path))
                {
                    txtFile.WriteLine(user.userName + ";" + user.age + ";" + user.address + ";" + user.score);
                }
            }
            Console.WriteLine("Wrote in file!");
        }

        /// <summary>
        /// Sort user by user name and show in screen
        /// </summary>
        /// <param name="path">path file to read user infor</param>
        private static void SortByUserName(string path)
        {
            string[] arrReader = File.ReadAllLines(path);
            for (int i = 1; i < arrReader.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (string.Compare(arrReader[i], arrReader[j]) < 0)
                    {
                        string temp = arrReader[i];
                        arrReader[i] = arrReader[j];
                        arrReader[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nThe result after sort: ");
            Console.WriteLine(string.Join("\n", arrReader));
        }

        /// <summary>
        /// Caculate total score and show in screen
        /// </summary>
        /// <param name="path">path file to get score</param>
        private static void TotalScore(string path)
        {
            //Đọc file, lưu mỗi user la 1 phân tử của mảng
            string[] arrReader = File.ReadAllLines(path);
            //Score ở vị trí cuối của mỗi phần tử. Thưc hiện cắt lấy score
            int totalScore = 0;
            for (int i = 0; i < arrReader.Length; i++)
            {
                int score = 0;
                string[] strSub = arrReader[i].Split(';');
                Int32.TryParse(strSub[strSub.Length - 1], out score);
                totalScore += score;
            }
            Console.WriteLine("\nTotal score: " + totalScore);
        }
    }
}
