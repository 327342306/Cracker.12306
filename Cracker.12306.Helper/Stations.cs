using Cracker._12306.Helper.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cracker._12306.Helper
{
    public class Stations
    {
        /// <summary>
        /// 站点信息列表
        /// </summary>
        public static List<Station> StationList {get;set;}
        /// <summary>
        /// 站点起售时间列表
        /// </summary>
        public static List<StationStartTime> StationStartTimeList{get;set;}

        public static void Init()
        {
            StationList = new List<Station>();
            StationStartTimeList = new List<StationStartTime>();
            #region 获取车站站点信息
            var StationResponse = Http.Get(
                "https://kyfw.12306.cn/otn/resources/js/framework/station_name.js",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586",
                "gzip, deflate",
                "kyfw.12306.cn"
                );
            string StationsStr = StationResponse.ResponseStreamToString();
            try
            {
                Regex stationRegex = new Regex("'(?<stationNames>[^\']*?)'");
                if (stationRegex.IsMatch(StationsStr))
                {
                    string stationNames = stationRegex.Matches(StationsStr)[0].Groups["stationNames"].Value;
                    string[] stations = stationNames.Split('@');
                    foreach (var station in stations)
                    {
                        if (string.IsNullOrEmpty(station))
                        {
                            continue;
                        }
                        string[] names = station.Split('|');
                        StationList.Add(new Station()
                        {
                            Shorthand = names[0],
                            Name = names[1],
                            Code = names[2],
                            Pinyin = names[3],
                            FirstLetter = names[4],
                            Order = names[5]
                        });
                    }
                }
            }
            catch (Exception)
            {

            }
            #endregion
            #region 获取车站起售时间信息
            var StationStartTimeResponse = Http.Get(
                "https://kyfw.12306.cn/otn/resources/js/query/qss.js",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586",
                "gzip, deflate",
                "kyfw.12306.cn"
                );
            string stationStartTimeStr = StationStartTimeResponse.ResponseStreamToString();
            try
            {
                Regex stationStartTimeRegex = new Regex(@"""(?<stationNames>[^""]*)""[^""]*""(?<stationStartTime>[^""]*)""", RegexOptions.Singleline);
                if (stationStartTimeRegex.IsMatch(stationStartTimeStr))
                {
                    MatchCollection stationStartTimeMatchCollection = stationStartTimeRegex.Matches(stationStartTimeStr);
                    foreach (Match stationStartTimeMatch in stationStartTimeMatchCollection)
                    {

                        StationStartTimeList.Add(new StationStartTime()
                        {
                            Name = stationStartTimeMatch.Groups["stationNames"].Value,
                            Time = stationStartTimeMatch.Groups["stationStartTime"].Value
                        });
                    }
                }
            }
            catch { }
            #endregion
        }
    }
}
