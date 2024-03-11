using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Collections_13._6._1
{
    internal class Program
    {
        private static List<string> List = new List<string>();
        private static LinkedList<string> LinkedList = new LinkedList<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу");
            string path = File.ReadAllText(Console.ReadLine());

            var timer = Stopwatch.StartNew();

            List.Add(path);

            Console.WriteLine($"Вставка в  List: {timer.Elapsed.TotalMilliseconds}  мс");

            timer.Start();

            LinkedList.AddFirst(path);

            Console.WriteLine($"Вставка в  LinkedList: {timer.Elapsed.TotalMilliseconds}  мс");
        }
    }
}
