using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
namespace Cracker._12306.Helper.Handle
{
    public class Login
    {
        private string InitUrl = "https://kyfw.12306.cn/otn/login/init";
        private string DynamicFormUrl = "https://kyfw.12306.cn{0}";

        //获取验证码链接
        private string PassCodeUrl = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module={0}&rand=sjrand&{1}";


        //判断验证码是否正确
        //https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn
        public Login Init()
        {
            var InitResponse = Http.Get(InitUrl, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            var InitStr = InitResponse.ResponseStreamToString();
            Regex InitRegex = new Regex(@"<script src=""(?<url>[^""]*)"" type=""text/javascript"" xml:space=""preserve""></script>", RegexOptions.Singleline);
            if (InitRegex.IsMatch(InitStr))
            {
                DynamicFormUrl = string.Format(DynamicFormUrl, InitRegex.Match(InitStr).Groups["url"].Value);
            }
            else
            {
                throw new NullReferenceException("未换取到获取cookie的url");
            }
            return this;
        }

        public Login GetDynamicFormUrl()
        {
            var GetDynamicFormUrlResponse = Http.Get(DynamicFormUrl, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            var GetDynamicFormUrlStr = GetDynamicFormUrlResponse.ResponseStreamToString();
            return this;
        }

        public Login GetPassCodeUrl(out Image image)
        {
            string RandomStr = "0." + Public.Random(15);
            var PassCodeResponse = Http.Get(string.Format(PassCodeUrl, "login", RandomStr), Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            image = PassCodeResponse.ResponseStreamToImage();
            return this;
        }
    }
}
