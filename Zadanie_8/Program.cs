using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //input output


namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Input.txt";

            double f = 400;
            double w = 10000;
            double Ф = 1.25 * Math.Pow(10, -4);

            StreamWriter sw = new StreamWriter(path, false);

            sw.WriteLine(f);
            sw.WriteLine(w);
            sw.WriteLine(Ф);

            sw.Close();

            Console.WriteLine("Запись произведена");

            Console.ReadKey();

            //чтение из файла Input.txt



            StreamReader sr = new StreamReader(path);

            double f_read = Convert.ToDouble(sr.ReadLine());
            double w_read = Convert.ToDouble(sr.ReadLine());
            double Ф_read = Convert.ToDouble(sr.ReadLine());
            //вычисление результата по формуле
            double E = 4.44 * f_read * w_read * Ф_read;//формула
            //запись результата в файл Result.txt

            string path1 = @"Result.txt";
            StreamWriter sw1 = new StreamWriter(path1, false);
            sw1.WriteLine(E);
            sw1.Close();
            Console.WriteLine("Подсчет и Запись выполнены");
            Console.ReadKey();
        }
    }
}
        