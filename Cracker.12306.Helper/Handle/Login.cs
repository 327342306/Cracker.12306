using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cracker._12306.Helper.Handle
{
    public class Login
    {
        private string InitUrl = "https://kyfw.12306.cn/otn/login/init";
        private string getDynamicFormUrl = "";

        //换取cookie的链接
        //https://kyfw.12306.cn/otn/dynamicJs/lwtenws

        //获取验证码链接
        //https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=login&rand=sjrand&0.500551644480113


        //判断验证码是否正确
        //https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn
        public Login Init()
        {
            var InitResponse = Http.Get(InitUrl, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            var InitStr = InitResponse.ResponseStreamToString();
            Regex InitRegex = new Regex(@"<script src=""(?<url>[^""]*)"" type=""text/javascript"" xml:space=""preserve""></script>", RegexOptions.Singleline);
            if (InitRegex.IsMatch(InitStr))
            {
                getDynamicFormUrl = "https://kyfw.12306.cn" + InitRegex.Match(InitStr).Groups["url"].Value;
            }
            else
            {
                throw new NullReferenceException("未换取到获取cookie的url");
            }
            return this;
        }

        public Login GetDynamicFormUrl()
        {
            var GetDynamicFormUrlResponse = Http.Get(getDynamicFormUrl, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            var GetDynamicFormUrlStr = GetDynamicFormUrlResponse.ResponseStreamToString();
            return this;
        }
    }
}
