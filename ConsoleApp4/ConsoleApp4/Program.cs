using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }
    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person zsperson;
            zsperson._name = "张三";
            zsperson._gender = Gender.男;
            zsperson._age = 18;

            Person lsperson;
            lsperson._name = "李四";
            lsperson._gender = Gender.男;
            lsperson._age = 19;
            Console.WriteLine("我叫{0},性别为{1},我今年{2}岁",zsperson._name,zsperson._gender,zsperson._age);
            Console.WriteLine("我叫{0},性别为{1},我今年{2}岁", lsperson._name, lsperson._gender, lsperson._age);
            Console.ReadKey();
        }
    }
}
