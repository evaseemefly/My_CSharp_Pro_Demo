using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadConfig
{
    /// <summary>
    /// *** 注意ConfigurationSection需要手动添加system.configuration的类库引用
    /// </summary>
    public class MySection1:ConfigurationSection
    {
        [ConfigurationProperty("username",IsRequired =true)]
        public string UserName
        {
            get { return this["username"].ToString(); }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("url",IsRequired =true)]
        public string Url
        {
            get { return this["url"].ToString(); }
            set { this["url"] = value; }
        }
    }
}
