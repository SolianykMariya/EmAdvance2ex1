using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        public static string textGenerator(int length)
        {
            Random random = new Random();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int ascii = random.Next(97, 122);
                text.Append((char)ascii);
            }
            return text.ToString();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть кількість символів у кожній комірці");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] text = new string[10];

            for(int i = 0;i < text.Length;i++)
            {
                text[i] = textGenerator(length);
            }
            foreach(string str in text)
            {
                Console.WriteLine(str);
            }

                 

        }

    }
}

