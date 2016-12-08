using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Cracker._12306.Helper.Handle
{
    public class Login
    {
       
        private string InitUrl = "https://kyfw.12306.cn/otn/login/init";
        private string DynamicFormUrl = "https://kyfw.12306.cn{0}";
        //获取验证码链接
        private string PassCodeUrl = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module={0}&rand=sjrand&{1}";
        //判断验证码是否正确
        private string CheckCodeUrl = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
        private string LoginUrl = "https://kyfw.12306.cn/otn/login/loginAysnSuggest";

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

        public Image GetPassCode()
        {
            string RandomStr = "0." + Public.Random(15);
            var PassCodeResponse = Http.Get(string.Format(PassCodeUrl, "login", RandomStr), Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn");
            Image image = PassCodeResponse.ResponseStreamToImage();
            return image;
        }

        public bool CheckPassCode(List<Point> PassCodeAllPoint)
        {
            string pointStr = string.Join(",",PassCodeAllPoint.Select<Point, string>(i => (i.X.ToString() + "," + i.Y.ToString())).ToList());
            byte[] postData = Encoding.UTF8.GetBytes("randCode=" + pointStr + "&rand=sjrand");
            var CheckPassCodeResponse = Http.Post(CheckCodeUrl, postData, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn", InitUrl, Public.Domain, "application/x-www-form-urlencoded; charset=UTF-8", true);
            var CheckPassCodeJson = CheckPassCodeResponse.ResponseStreamToJson();
            return CheckPassCodeJson["data"]["result"].ToString() == "1";
        }

        public bool Start(string UserName, string Password, List<Point> PassCodeAllPoint)
        {
            string pointStr = string.Join(",", PassCodeAllPoint.Select<Point, string>(i => (i.X.ToString() + "," + i.Y.ToString())).ToList());
            byte[] postData = Encoding.UTF8.GetBytes("loginUserDTO.user_name="+UserName+"&userDTO.password="+Password+"&randCode=" + pointStr);
            var LoginResponse = Http.Post(LoginUrl, postData, Public.UserAgent, Public.AcceptEncoding, "kyfw.12306.cn", InitUrl, Public.Domain, "application/x-www-form-urlencoded", true);
            var LoginJson = LoginResponse.ResponseStreamToJson();
            return LoginJson["data"]["loginCheck"].ToString().ToLower() == "y";
        }
    }
}
