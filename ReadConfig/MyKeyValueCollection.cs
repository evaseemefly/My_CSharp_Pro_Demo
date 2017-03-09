using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadConfig
{
    /// <summary>
    /// *** 继承自一个元素集合的配置元素
    /// 其中的集合类型为MyKeyValueSetting
    /// </summary>
    [ConfigurationCollection(typeof(MyKeyValueSetting))]
    public class MyKeyValueCollection : ConfigurationElementCollection
    {
        //忽略大小写
        public MyKeyValueCollection() : base(StringComparer.OrdinalIgnoreCase) { }

        /// <summary>
        /// 注意这是一个索引器
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        new public MyKeyValueSetting this[string name]
        {
            get
            {
                return (MyKeyValueSetting)base.BaseGet(name);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MyKeyValueSetting();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MyKeyValueSetting)element).Key;
        }
    }
}
