using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadConfig
{
    public class MySectionElement:ConfigurationElement
    {
        /// <summary>
        /// 用户名
        /// ConfigurationProperty为实例化配置属性
        /// </summary>
        [ConfigurationProperty("username",IsRequired =true)]
        public string UserName
        {
            get { return this["username"].ToString(); }
            set { this["username"] = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        [ConfigurationProperty("pwd",IsRequired =true)]
        public string Password
        {
            get { return this["pwd"].ToString(); }
            set { this["pwd"] = value; }
        }
    }
}
