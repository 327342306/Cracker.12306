using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cracker._12306.Helper
{
    public class Public
    {
        public static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586";
        public static string AcceptEncoding = "gzip, deflate";
        public static string Domain = "https://kyfw.12306.cn";
        public static string Random(int Length)
        {
            string RandomStr = "";
            int [] IntArray = new int[]{0,1,2,3,4,5,6,7,8,9};
            Random r = new Random();
            for (int i = 0; i < Length; i++)
            {
                RandomStr += IntArray[r.Next(IntArray.Length - 1)].ToString();
            }
            return RandomStr;
        }
    }
}
