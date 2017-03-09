using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadConfig
{
    /// <summary>
    /// 集合中的每个元素
    /// *** 注意其继承自配置元素
    /// </summary>
    public class MyKeyValueSetting:ConfigurationElement
    {
        [ConfigurationProperty("key",IsRequired =true)]
        public string Key
        {
            get { return this["key"].ToString(); }
            set { this["key"] = value; }
        }

        [ConfigurationProperty("value",IsRequired =true)]
        public string Value
        {
            get { return this["value"].ToString(); }
            set { this["value"] = value; }
        }
    }
}
