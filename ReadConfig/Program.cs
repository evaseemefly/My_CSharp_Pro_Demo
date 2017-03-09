using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetConfigSection1();
            //GetConfigSection2();
            GetConfigSection4();
        }

        static void GetConfigSection1()
        {
            var config= ConfigurationManager.GetSection("MySection111") as MySection1;
        }

        static void GetConfigSection2()
        {
            var config2 = ConfigurationManager.GetSection("MySection2") as MySection2;
        }

        static void GetConfigSection4()
        {
            var config4 = ConfigurationManager.GetSection("MySection4") as MySection4;
        }
    }
}
