using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public enum QQState
    {
        Online,
        Offline,
        Leave,
        Busy,
        Qme
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            while (input !=0)
            {
                Console.WriteLine("请输入你的QQ状态(1-Online,2-Offline,3-Leave,4-Busy,5-Qme)");
                string str = Console.ReadLine();
                try
                {


                    int i = int.Parse(str);
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("你的QQ状态是{0}", QQState.Online);
                            input = 0;
                            break;
                        case 2:
                            Console.WriteLine("你的QQ状态是{0}", QQState.Offline);
                            input = 0;
                            break;
                        case 3:
                            Console.WriteLine("你的QQ状态是{0}", QQState.Leave);
                            input = 0;
                            break;
                        case 4:
                            Console.WriteLine("你的QQ状态是{0}", QQState.Busy);
                            input = 0;
                            break;
                        case 5:
                            Console.WriteLine("你的QQ状态是{0}", QQState.Qme);
                            input = 0;
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("你输入的格式错误，请重试");
             //       break;
                }
            }
            Console.ReadKey();

        }
    }
}
