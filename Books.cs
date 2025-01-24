using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Books
    {
        public string Name = "Life";
        public string Author = "Vladimir";
        public int Year = 2010;
        public int Capacity = 240;
        public void Info()
        {
            Console.WriteLine($"Название: {Name}\nАвтор: {Author}\nГод: {Year}\nОбъём: {Capacity}");
        }
    }
}
