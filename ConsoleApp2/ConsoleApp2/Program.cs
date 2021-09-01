using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的名字");
            string str = Console.ReadLine();
            Console.WriteLine("你的名字是{0}", str);
            Console.ReadKey();
        }
    }
}
