using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class UploadResult:BaseResult
    {
        public int index { get; set; }
        public UploadResult()
        {
            Console.WriteLine("子类无参构造函数！！");
        }

        public UploadResult(string filename) : base(filename)
        {

        }

        public UploadResult(int index)
        {
            Console.WriteLine("子类有参构造函数！！");
            this.index = index;
        }
    }
}
