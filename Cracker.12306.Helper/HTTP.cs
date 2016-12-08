using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cracker._12306.Helper
{
    public class Http
    {
        private static CookieContainer cookieContainer;
        private static HttpWebRequest request;
        static Http()
        {
            cookieContainer = new CookieContainer();
        }

        public static HttpWebResponse Get(string url, string UserAgent = null, string AcceptEncoding = null, string Host = null, bool KeepAlive = false, string Accept = "*/*", string AcceptLanguage = "zh-CN", string CacheControl = "no-cache")
        {
            request = WebRequest.Create(url) as HttpWebRequest;
            request.CookieContainer = cookieContainer;
            request.Method = "GET";
            request.KeepAlive = KeepAlive;
            request.Accept = Accept;
            if (!string.IsNullOrEmpty(Host))
            {
                request.Host = Host;
            }
            if (!string.IsNullOrEmpty(UserAgent))
            {
                request.UserAgent = UserAgent;
            }
            if (!string.IsNullOrEmpty(AcceptEncoding))
            {
                request.Headers.Add("Accept-Encoding", AcceptEncoding);
            }
            if (!string.IsNullOrEmpty(AcceptLanguage))
            {
                request.Headers.Add("Accept-Language", AcceptLanguage);
            }
            if (!string.IsNullOrEmpty(CacheControl))
            {
                request.Headers.Add("Cache-Control", CacheControl);
            }
            if (!string.IsNullOrEmpty(Public.WebProxy))
            {
                request.Proxy = new WebProxy(Public.WebProxy);
            }
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response;
        }
        private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
        public static HttpWebResponse Post(string url,byte[] postData, string UserAgent = null, string AcceptEncoding = null, string Host = null, string Referer = null, string Origin = null, string ContentType = null, bool isAjax=false, bool KeepAlive = false, string Accept = "*/*", string AcceptLanguage = "zh-CN", string CacheControl = "no-cache")
        {
            request = WebRequest.Create(url) as HttpWebRequest;
            request.CookieContainer = cookieContainer;
            request.Method = "POST";
            request.KeepAlive = KeepAlive;
            request.Accept = Accept;
            if (!string.IsNullOrEmpty(Host))
            {
                request.Host = Host;
            }
            if (!string.IsNullOrEmpty(UserAgent))
            {
                request.UserAgent = UserAgent;
            }
            if (!string.IsNullOrEmpty(AcceptEncoding))
            {
                request.Headers.Add("Accept-Encoding", AcceptEncoding);
            }
            if (!string.IsNullOrEmpty(AcceptLanguage))
            {
                request.Headers.Add("Accept-Language", AcceptLanguage);
            }
            if (!string.IsNullOrEmpty(CacheControl))
            {
                request.Headers.Add("Cache-Control", CacheControl);
            }
            if (!string.IsNullOrEmpty(Referer))
            {
                request.Referer = Referer;
            }
            if (!string.IsNullOrEmpty(Origin))
            {
                request.Headers.Add("Origin", Origin);
            }
            if (!string.IsNullOrEmpty(ContentType))
            {
                request.ContentType = ContentType;
            }
            if (isAjax)
            {
                request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            }
            if (!string.IsNullOrEmpty(Public.WebProxy))
            {
                request.Proxy = new WebProxy(Public.WebProxy);
            }
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postData, 0, postData.Length);
            requestStream.Close();
            ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidate;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return response;
        }
    }
}
