using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracker._12306.Helper.Model
{
    public class Station
    {
        /// <summary>
        /// 站点名
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 车站编码
        /// </summary>
        public string Code
        {
            get;
            set;
        }
        /// <summary>
        /// 首字母
        /// </summary>
        public string FirstLetter
        {
            get;
            set;
        }
        /// <summary>
        /// 全拼
        /// </summary>
        public string Pinyin
        {
            get;
            set;
        } 
        /// <summary>
        /// 简写
        /// </summary>
        public string Shorthand
        {
            get;
            set;
        }
        /// <summary>
        /// 排序
        /// </summary>
        public string Order
        {
            get;
            set;
        }
    }
}
