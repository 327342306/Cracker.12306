using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cracker._12306.Helper
{
    public static class Extend
    {
        /// <summary>
        /// 扩展方法,Response返回流转换为String
        /// </summary>
        /// <param name="httpWebResponse"></param>
        /// <returns></returns>
        public static string ResponseStreamToString(this HttpWebResponse httpWebResponse)
        {
            Stream ResponseStream = httpWebResponse.GetResponseStream();
            if (httpWebResponse.ContentEncoding.ToLower().Contains("gzip"))
            {
                ResponseStream = new GZipStream(ResponseStream, CompressionMode.Decompress);
            }
            StreamReader ResponseStreamReader = new StreamReader(ResponseStream);
            string responseStr = ResponseStreamReader.ReadToEnd();
            ResponseStream.Close();
            httpWebResponse.Close();
            return responseStr;
        }
    }
}
