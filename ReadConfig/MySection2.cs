using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadConfig
{
    public class MySection2:ConfigurationSection
    {
        [ConfigurationProperty("users",IsRequired =true)]
        public MySectionElement Users
        {
            get { return (MySectionElement)this["users"]; }
        }
    }

}
