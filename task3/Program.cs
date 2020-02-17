using System;
using System.IO;
using System.Text;

namespace Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            Console.InputEncoding = Encoding.Default;

            string path = "stud.txt";

            string[] surname = { "Берестяк Г.С.", "Заєць О.М.", "Зоренко П.М", "Іванчук С.О",
                "Кравченко З.І.", "Панченко І.А.", "Сидорук В.Р.", "Снопок П.О.", "Якимець Н.С.", "Якубів Р.Н."};
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] mark = { 4, 5, 3, 4, 3, 5, 4, 3, 5, 4 };

            //for (int i = 0; i < 10; i++)
            //{
            //    using (StreamWriter stream = new StreamWriter(path, true))
            //        stream.WriteLine(surname[i] + " " + number[i] + " " + mark[i]);
            //}

            Console.WriteLine($"file {path}:");

            using (StreamReader streamR = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                string line;
                while ((line = streamR.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            int mid = 0;
            for (int i = 0; i < 10; i++)
            {
                mid += mark[i];
            }
            Console.WriteLine($"Middle mark for math is {(double)(mid / 10)}");
        }
    }
}