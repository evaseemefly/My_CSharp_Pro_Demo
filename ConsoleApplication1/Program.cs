using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 调用子类无参数构造函数，并通过字面量表示法赋值");
            /*
            实际顺序如下：
            1、父类无参构造函数
            2、子类无参构造函数
             */
            var model = new UploadResult() { FullFileName = "123.jpg" };
            Console.WriteLine("****************************");

            Console.WriteLine("2 调用子类有参数构造函数，不通过字面量表示法赋值");
            /*
            实际顺序如下：
            1、父类无参构造函数
            2、父类有参构造函数
             */
            var model2 = new UploadResult("123.jpg");
            Console.WriteLine("****************************");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
