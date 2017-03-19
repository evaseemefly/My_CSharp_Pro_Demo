using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BaseResult
    {
        public string FullFileName { get; set; }

        public string Ext { get; set; }

        public BaseResult()
        {
            Console.WriteLine("父类无参构造函数！！");
            Init();
        }

        public BaseResult(string filename):this()
        {
            Console.WriteLine("父类有参构造函数！！");
            
            this.FullFileName = filename;

            Init();
        }

        private void Init()
        {
            if (FullFileName != null)
            {
                Ext = FullFileName.Substring(FullFileName.LastIndexOf('.'));
            }
        }

        
    }
}
