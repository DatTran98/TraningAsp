using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

/// <summary>
/// namespace ReadExcelFile
/// </summary>
namespace ReadExcelFile
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
            // Get stream file
            FileStream fs = new FileStream(@"C:\Users\nguyenkhanhphung\OneDrive\Tài liệu\Kanji\Kanji N5.xlsx", FileMode.Open);

            //XSSF => for XLSX(Excel 2007 +)
            //HSSF => for cho XLS(Excel 97 - 2003)
            XSSFWorkbook wb = new XSSFWorkbook(fs);

            // Get first sheet
            ISheet sheet = wb.GetSheetAt(0);
             
            //count rows
            string keyEnd = "";
            int countRows = 0;
            do
            {
                countRows++;
                //key = Console.ReadLine();

                try
                {
                    keyEnd = sheet.GetRow(countRows).GetCell(1).StringCellValue;
                }
                catch (NullReferenceException )
                {
                    keyEnd = "end";
                    Console.WriteLine("In the last row!");
                }
            } while (!"end".Equals(keyEnd));

            Console.OutputEncoding = System.Text.Encoding.Unicode; ; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Thông tin từ file Excel XLSX");
            string key = "";

            // continous show in screen until enter 'q'
            do
            {
                Random rd = new Random();
                int rowIndex = rd.Next(2, countRows);
                if (rowIndex % 2 == 0)
                {
                    rowIndex -= 1;
                }
                // get row now
                var nowRow = sheet.GetRow(rowIndex);
                //var nextRow = sheet.GetRow(rowIndex+1);

                // get data in column B, C, D , E, F 
                var kanji = nowRow.GetCell(1).StringCellValue;
                var hanViet = nowRow.GetCell(2).StringCellValue;
                var nghia = nowRow.GetCell(3).StringCellValue;
                var amOn = nowRow.GetCell(4).StringCellValue;
                var amKun = nowRow.GetCell(5).StringCellValue;
                //var docOn = nextRow.GetCell(4).StringCellValue;
                //var docKun = nextRow.GetCell(5).StringCellValue;

                Console.WriteLine("Kanji: {0} ", kanji);
                Console.ReadLine();
                Console.WriteLine("Âm hán việt: {0} | Nghĩa: {1} | Âm On: {2} | Âm Kun: {3} ", hanViet, nghia, amOn, amKun);
                key = Console.ReadLine();

            } while (!"q".Equals(key));

        }
    }
}
