using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurrowLift
{
    [HideInInspector] public static string Vagary_WorshipBard; //归因渠道名称 由NetInfoMgr的CheckAdjustNetwork方法赋值
    static string Akin_AP; //ApplePie的本地存档 存储第一次进入状态 未来不再受ApplePie开关影响
    static string PatentKeelBard= "pie"; //正常模式名称
    static string Economize; //距离黑名单位置的距离 打点用
    static string Divert; //进审理由 打点用
    [HideInInspector] public static string WeftHut= ""; //判断流程 打点用

    public static bool ItChair()
    {
        //测试
         //return true;
        if (PlayerPrefs.HasKey("Save_AP"))  //优先使用本地存档
            Akin_AP = PlayerPrefs.GetString("Save_AP");
        if (string.IsNullOrEmpty(Akin_AP)) //无本地存档 读取网络数据
            TasteOriginSpan();

        if (Akin_AP != "P")
            return true;
        else
            return false;
    }

    static void TasteOriginSpan() //读取网络数据 判断进入哪种游戏模式
    {
        string OtherChance = "NO"; //进审之后 是否还有可能变正常
        Akin_AP = "P";
        if (TanGenuUSA.instance.ChiselSpan.apple_pie != PatentKeelBard) //审模式 
        {
            OtherChance = "YES";
            Akin_AP = "A";
            if (string.IsNullOrEmpty(Divert))
                Divert = "ApplePie";
        }
        WeftHut = "0:" + Akin_AP;
        //判断地理位置
        if (!string.IsNullOrEmpty(TanGenuUSA.instance.ChiselSpan.LocationList) && TanGenuUSA.instance.BoonSpan != null)
        {
            //判断运营商信息
            if (TanGenuUSA.instance.BoonSpan.IsHaveApple)
            {
                Akin_AP = "A";
                if (string.IsNullOrEmpty(Divert))
                    Divert = "HaveApple";
            }
            WeftHut += "  1:" + Akin_AP;
            //判断经纬度
            LocationData[] LocationDatas = LitJson.JsonMapper.ToObject<LocationData[]>(TanGenuUSA.instance.ChiselSpan.LocationList);
            if (LocationDatas != null && LocationDatas.Length > 0 && TanGenuUSA.instance.BoonSpan.lat != 0 && TanGenuUSA.instance.BoonSpan.lon != 0)
            {
                for (int i = 0; i < LocationDatas.Length; i++)
                {
                    float Distance = BisInscribe((float)LocationDatas[i].X, (float)LocationDatas[i].Y,
                    (float)TanGenuUSA.instance.BoonSpan.lat, (float)TanGenuUSA.instance.BoonSpan.lon);
                    Economize += Distance.ToString() + ",";
                    if (Distance <= LocationDatas[i].Radius)
                    {
                        Akin_AP = "A";
                        if (string.IsNullOrEmpty(Divert))
                            Divert = "Location";
                        break;
                    }
                }
            }
            WeftHut += "  2:" + Akin_AP;
            //判断城市
            string[] HeiCityList = LitJson.JsonMapper.ToObject<string[]>(TanGenuUSA.instance.ChiselSpan.HeiCity);
            if (!string.IsNullOrEmpty(TanGenuUSA.instance.BoonSpan.regionName) && HeiCityList != null && HeiCityList.Length > 0)
            {
                for (int i = 0; i < HeiCityList.Length; i++)
                {
                    if (HeiCityList[i] == TanGenuUSA.instance.BoonSpan.regionName
                    || HeiCityList[i] == TanGenuUSA.instance.BoonSpan.city)
                    {
                        Akin_AP = "A";
                        if (string.IsNullOrEmpty(Divert))
                            Divert = "City";
                        break;
                    }
                }
            }
            WeftHut += "  3:" + Akin_AP;
            //判断黑名单
            string[] HeiIPs = LitJson.JsonMapper.ToObject<string[]>(TanGenuUSA.instance.ChiselSpan.HeiNameList);
            if (HeiIPs != null && HeiIPs.Length > 0 && !string.IsNullOrEmpty(TanGenuUSA.instance.BoonSpan.query))
            {
                string[] IpNums = TanGenuUSA.instance.BoonSpan.query.Split('.');
                for (int i = 0; i < HeiIPs.Length; i++)
                {
                    string[] HeiIpNums = HeiIPs[i].Split('.');
                    bool isMatch = true;
                    for (int j = 0; j < HeiIpNums.Length; j++) //黑名单IP格式可能是任意位数 根据位数逐个比对
                    {
                        if (HeiIpNums[j] != IpNums[j])
                            isMatch = false;
                    }
                    if (isMatch)
                    {
                        Akin_AP = "A";
                        if (string.IsNullOrEmpty(Divert))
                            Divert = "IP";
                        break;
                    }
                }
            }
            WeftHut += "  4:" + Akin_AP;
        }
        WeftHut += "  5:" + Akin_AP;
        //判断自然量
        if (!string.IsNullOrEmpty(TanGenuUSA.instance.ChiselSpan.fall_down))
        {
            if (TanGenuUSA.instance.ChiselSpan.fall_down == "bottom") //仅判断Organic
            {
                if (Vagary_WorshipBard == "Organic") //打开自然量 且 归因渠道是Organic 审模式
                {
                    Akin_AP = "A";
                    if (string.IsNullOrEmpty(Divert))
                        Divert = "FallDown";
                }
            }
            else if (TanGenuUSA.instance.ChiselSpan.fall_down == "down") //判断Organic + NoUserConsent
            {
                if (Vagary_WorshipBard == "Organic" || Vagary_WorshipBard == "No User Consent") //打开自然量 且 归因渠道是Organic或NoUserConsent 审模式
                {
                    Akin_AP = "A";
                    if (string.IsNullOrEmpty(Divert))
                        Divert = "FallDown";
                }
            }
        }
        WeftHut += "  6:" + Akin_AP;

        PlayerPrefs.SetString("Save_AP", Akin_AP);
        PlayerPrefs.SetString("OtherChance", OtherChance);
        //打点
        if (!string.IsNullOrEmpty(AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe)))
            CastSheer();


        //本地log
        Debug.Log("++++++判断流程： " + WeftHut);
        if (TanGenuUSA.instance.BoonSpan != null)
        {
            string Genu= "游戏模式：" + (Akin_AP == "A" ? "审" : "正常")
                       + "\n进审理由：" + Divert
                       + "\n开关： " + TanGenuUSA.instance.ChiselSpan.apple_pie
                       + "\n是否包含苹果： " + TanGenuUSA.instance.BoonSpan.IsHaveApple
                       + "\n位置黑名单： " + TanGenuUSA.instance.ChiselSpan.LocationList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户位置： " + TanGenuUSA.instance.BoonSpan.lat + "," + TanGenuUSA.instance.BoonSpan.lon
                       + "\n黑名单城市： " + TanGenuUSA.instance.ChiselSpan.HeiCity?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户城市: " + TanGenuUSA.instance.BoonSpan.regionName
                       + "\n与黑名单地点距离： " + Economize
                       + "\nIP黑名单： " + TanGenuUSA.instance.ChiselSpan.HeiNameList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户IP： " + TanGenuUSA.instance.BoonSpan.query
                       + "\n自然量开关： " + TanGenuUSA.instance.ChiselSpan.fall_down
                       + "\n归因渠道： " + Vagary_WorshipBard
                       + "\n接口返回信息： " + TanGenuUSA.instance.BoonSpanLap;
            Debug.Log("++++++" + Genu);
        }
    }
    static float BisInscribe(float lat1, float lon1, float lat2, float lon2)
    {
        const float R = 6371f; // 地球半径，单位：公里
        float latDistance = Mathf.Deg2Rad * (lat2 - lat1);
        float lonDistance = Mathf.Deg2Rad * (lon2 - lon1);
        float a = Mathf.Sin(latDistance / 2) * Mathf.Sin(latDistance / 2)
               + Mathf.Cos(Mathf.Deg2Rad * lat1) * Mathf.Cos(Mathf.Deg2Rad * lat2)
               * Mathf.Sin(lonDistance / 2) * Mathf.Sin(lonDistance / 2);
        float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return R * c * 1000; // 距离，单位：米
    }

    public static void CastSheer()
    {
        //打点
        if (TanGenuUSA.instance.BoonSpan != null)
        {
            string Info1 = "[" + (Akin_AP == "A" ? "审" : "正常")
                                       + "] [" + Divert + "]";
            string Info2 = "[" + TanGenuUSA.instance.BoonSpan.lat + "," + TanGenuUSA.instance.BoonSpan.lon
                           + "] [" + TanGenuUSA.instance.BoonSpan.regionName
                           + "] [" + Economize + "]";
            string Info3 = "[" + TanGenuUSA.instance.BoonSpan.query
                           + "] [" + Vagary_WorshipBard + "]";
            SelfSheerRibbon.BisFeedback().CastSheer("3000", Info1, Info2, Info3);
        }
        else
            SelfSheerRibbon.BisFeedback().CastSheer("3000", "No UserData");
        SelfSheerRibbon.BisFeedback().CastSheer("3001", (Akin_AP == "A" ? "审" : "正常"), WeftHut, TanGenuUSA.instance.SpanWavy);
        PlayerPrefs.SetInt("SendedEvent", 1);
    }

    public static bool ItCounty()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool ItAlkaloid()
    {
        return Screen.height > Screen.width;
    }


}
