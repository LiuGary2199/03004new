/***
 * 
 * 
 * 网络信息控制
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using com.adjust.sdk;
//using MoreMountains.NiceVibrations;

public class TanGenuUSA : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("CashOut_Data")]    [UnityEngine.Serialization.FormerlySerializedAs("SuchWay_Hall")]public CashOutData BillPpm_Span; //提现相关后台数据
    public static TanGenuUSA instance;
    //请求超时时间
    private static float TIMEOUT= 3f;
[UnityEngine.Serialization.FormerlySerializedAs("BaseUrl")]    //base
[UnityEngine.Serialization.FormerlySerializedAs("LastSum")]    public string FirmCry;
[UnityEngine.Serialization.FormerlySerializedAs("BaseLoginUrl")]    //登录url
[UnityEngine.Serialization.FormerlySerializedAs("LastGrantSum")]    public string FirmIdiomCry;
[UnityEngine.Serialization.FormerlySerializedAs("BaseConfigUrl")]    //配置url
[UnityEngine.Serialization.FormerlySerializedAs("LastScreamSum")]    public string FirmChiselCry;
[UnityEngine.Serialization.FormerlySerializedAs("BaseTimeUrl")]    //时间戳url
[UnityEngine.Serialization.FormerlySerializedAs("LastFastSum")]    public string FirmTiltCry;
[UnityEngine.Serialization.FormerlySerializedAs("BaseAdjustUrl")]    //更新AdjustId url
[UnityEngine.Serialization.FormerlySerializedAs("LastCosmosSum")]    public string FirmVagaryCry;
[UnityEngine.Serialization.FormerlySerializedAs("GameCode")]    //后台gamecode
[UnityEngine.Serialization.FormerlySerializedAs("UtahTone")]    public string WideTusk= "20000";
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("DataFrom")][UnityEngine.Serialization.FormerlySerializedAs("HallSort")]public string SpanWavy; //数据来源 打点用
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]    //channel渠道平台
[UnityEngine.Serialization.FormerlySerializedAs("Channel")]
#if UNITY_IOS
    public string Legally= "iOS";
#elif UNITY_ANDROID
    public string Channel = "GooglePlay";
#else
    public string Channel = "Other";
#endif
    //工程包名
    private string LicenseBard{ get { return Application.identifier; } }
    //登录url
    private string IdiomCry= "";
    //配置url
    private string ChiselCry= "";
    //更新AdjustId url
    private string VagaryCry= "";
[UnityEngine.Serialization.FormerlySerializedAs("country")]    //国家
[UnityEngine.Serialization.FormerlySerializedAs("Restore")]    public string Iceberg= "";
[UnityEngine.Serialization.FormerlySerializedAs("ConfigData")]    //服务器Config数据
[UnityEngine.Serialization.FormerlySerializedAs("ScreamHall")]    public ServerData ChiselSpan;
[UnityEngine.Serialization.FormerlySerializedAs("InitData")]    //游戏内数据
[UnityEngine.Serialization.FormerlySerializedAs("TireHall")]    public Init BiteSpan;
[UnityEngine.Serialization.FormerlySerializedAs("GameData")]    
[UnityEngine.Serialization.FormerlySerializedAs("UtahHall")]    public GameData WideSpan;
[UnityEngine.Serialization.FormerlySerializedAs("adManager")]    
[UnityEngine.Serialization.FormerlySerializedAs("ItWrapper")]    //ADThinker
    public GameObject ToThinker;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("gaid")]    [UnityEngine.Serialization.FormerlySerializedAs("Hiss")]public string Sage;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("aid")]    [UnityEngine.Serialization.FormerlySerializedAs("Ere")]public string Ice;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("idfa")]    [UnityEngine.Serialization.FormerlySerializedAs("Tray")]public string Roam;
    int Harsh_Trash= 0;
[UnityEngine.Serialization.FormerlySerializedAs("ready")]    [UnityEngine.Serialization.FormerlySerializedAs("Study")]public bool Harsh= false;
[UnityEngine.Serialization.FormerlySerializedAs("Exchange")]
   public double[] Hardware= new double[] { 0,0};
    //ios 获取idfa函数声明
#if UNITY_IOS
    [DllImport("__Internal")]
    internal extern static void getIDFA();
#endif
    void Awake()
    {
        instance = this;
        IdiomCry = FirmIdiomCry + WideTusk + "&channel=" + Legally + "&version=" + Application.version;
        ChiselCry = FirmChiselCry + WideTusk + "&channel=" + Legally + "&version=" + Application.version;
        VagaryCry = FirmVagaryCry + WideTusk;
    }
    private void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaClass aj = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject p = aj.GetStatic<AndroidJavaObject>("currentActivity");
            p.Call("getGaid");
            p.Call("getAid");
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
#if UNITY_IOS
            getIDFA();
            string idfv = UnityEngine.iOS.Device.vendorIdentifier;
            AkinSpanThinker.GapAttest("idfv", idfv);
#endif
        }
        else
        {
            Idiom();           //编辑器登录
        }
        //获取config数据
        BisChiselSpan();
        CashOutManager.BisFeedback().Login();
    }

    /// <summary>
    /// 获取gaid回调
    /// </summary>
    /// <param name="gaid_str"></param>
    public void gaidAction(string gaid_str)
    {
        Debug.Log("unity收到gaid：" + gaid_str);
        Sage = gaid_str; 
        if (Sage == null || Sage == "")
        {
            Sage = AkinSpanThinker.BisAttest("gaid");
        }
        else
        {
            AkinSpanThinker.GapAttest("gaid", Sage);
        }
        Harsh_Trash++;
        if (Harsh_Trash == 2)
        {
            Idiom();
        }
    }
    /// <summary>
    /// 获取aid回调
    /// </summary>
    /// <param name="aid_str"></param>
    public void aidAction(string aid_str)
    {
        Debug.Log("unity收到aid：" + aid_str);
        Ice = aid_str;
        if (Ice == null || Ice == "")
        {
            Ice = AkinSpanThinker.BisAttest("aid");
        }
        else
        {
            AkinSpanThinker.GapAttest("aid", Ice);
        }
        Harsh_Trash++;
        if (Harsh_Trash == 2)
        {
            Idiom();
        }
    }
    /// <summary>
    /// 获取idfa成功
    /// </summary>
    /// <param name="message"></param>
    public void idfaSuccess(string message)
    {
        Debug.Log("idfa success:" + message);
        Roam = message;
        AkinSpanThinker.GapAttest("idfa", Roam);
        Idiom();
    }
    /// <summary>
    /// 获取idfa失败
    /// </summary>
    /// <param name="message"></param>
    public void idfaFail(string message)
    {
        Debug.Log("idfa fail");
        Roam = AkinSpanThinker.BisAttest("idfa");
        Idiom();
    }
    /// <summary>
    /// 登录
    /// </summary>
    public void Idiom()
    {
        //提现登录
        CashOutManager.BisFeedback().Login();
        //获取本地缓存的Local用户ID
        string localId = AkinSpanThinker.BisAttest(CChisel.Ox_EmptyThinMe);

        //没有用户ID，视为新用户，生成用户ID
        if (localId == "" || localId.Length == 0)
        {
            //生成用户随机id
            TimeSpan st = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            string timeStr = Convert.ToInt64(st.TotalSeconds).ToString() + UnityEngine.Random.Range(0, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString() + UnityEngine.Random.Range(1, 10).ToString();
            localId = timeStr;
            AkinSpanThinker.GapAttest(CChisel.Ox_EmptyThinMe, localId);
        }

        //拼接登录接口参数
        string url = "";
        if (Application.platform == RuntimePlatform.IPhonePlayer)       //一个参数 - iOS
        {
            url = IdiomCry + "&" + "randomKey" + "=" + localId + "&idfa=" + Roam + "&packageName=" + LicenseBard;
        }
        else if (Application.platform == RuntimePlatform.Android)  //两个参数 - Android
        {
            url = IdiomCry + "&" + "randomKey" + "=" + localId + "&gaid=" + Sage + "&androidId=" + Ice + "&packageName=" + LicenseBard;
        }
        else //编辑器
        {
            url = IdiomCry + "&" + "randomKey" + "=" + localId + "&packageName=" + LicenseBard;
        }

        //获取国家信息
        RoeCulture(() => {
            url += "&country=" + Iceberg;
            //登录请求
            TanToilThinker.BisFeedback().EmitBis(url,
                (data) => {
                    Debug.Log("Login 成功" + data.downloadHandler.text);
                    AkinSpanThinker.GapAttest("init_time", DateTime.Now.ToString());
                    ServerUserData serverUserData = JsonMapper.ToObject<ServerUserData>(data.downloadHandler.text);
                    AkinSpanThinker.GapAttest(CChisel.Ox_EmptyUnwellMe, serverUserData.data.ToString());

                    CastVagaryBath();
                    if (PlayerPrefs.GetInt("SendedEvent") != 1 && !String.IsNullOrEmpty(BurrowLift.WeftHut))
                        BurrowLift.CastSheer();

                },
                () => {
                    Debug.Log("Login 失败");
                });
        });
    }
    /// <summary>
    /// 获取国家
    /// </summary>
    /// <param name="cb"></param>
    private void RoeCulture(Action cb)
    {
        bool callBackReady = false;
        if (String.IsNullOrEmpty(Iceberg))
        {
            ////获取国家超时返回
            //StartCoroutine(NetWorkTimeOut(() =>
            //{
            //    if (!callBackReady)
            //    {
            //        country = "";
            //        callBackReady = true;
            //        cb?.Invoke();
            //    }
            //}));
            TanToilThinker.BisFeedback().EmitBis("https://a.mafiagameglobal.com/event/country/", (data) =>
            {
                Iceberg = JsonMapper.ToObject<Dictionary<string, string>>(data.downloadHandler.text)["country"];
                Debug.Log("获取国家 成功:" + Iceberg);
                if (!callBackReady)
                {
                    callBackReady = true;
                    cb?.Invoke();
                }
            },
            () => {
                Debug.Log("获取国家 失败");
                if (!callBackReady)
                {
                    Iceberg = "";
                    callBackReady = true;
                    cb?.Invoke();
                }
            });
        }
        else
        {
            if (!callBackReady)
            {
                callBackReady = true;
                cb?.Invoke();
            }
        }
    }

    /// <summary>
    /// 获取服务器Config数据
    /// </summary>
    private void BisChiselSpan()
    {
        Debug.Log("GetConfigData:" + ChiselCry);
        //StartCoroutine(NetWorkTimeOut(() =>
        //{
        //    GetLoactionData();
        //}));

        //获取并存入Config
        TanToilThinker.BisFeedback().EmitBis(ChiselCry,
        (data) => {
            SpanWavy = "OnlineData";
            Debug.Log("ConfigData 成功" + data.downloadHandler.text);
            AkinSpanThinker.GapAttest("OnlineData", data.downloadHandler.text);
            GapChiselSpan(data.downloadHandler.text);
        },
        () => {
            BisScrapingSpan();
            Debug.Log("ConfigData 失败");
        });
    }

    /// <summary>
    /// 获取本地Config数据
    /// </summary>
    private void BisScrapingSpan()
    {
        //是否有缓存
        if (AkinSpanThinker.BisAttest("OnlineData") == "" || AkinSpanThinker.BisAttest("OnlineData").Length == 0)
        {
            SpanWavy = "LocalData_Updated"; //已联网更新过的数据
            Debug.Log("本地数据");
            TextAsset json = Resources.Load<TextAsset>("LocationJson/LocationData");
            GapChiselSpan(json.text);
        }
        else
        {
            SpanWavy = "LocalData_Original"; //原始数据
            Debug.Log("服务器缓存数据");
            GapChiselSpan(AkinSpanThinker.BisAttest("OnlineData"));
        }
    }


    /// <summary>
    /// 解析config数据
    /// </summary>
    /// <param name="configJson"></param>
    void GapChiselSpan(string configJson)
    {
        //如果已经获得了数据则不再处理
        if (ChiselSpan == null)
        {
            
            RootData rootData = JsonMapper.ToObject<RootData>(configJson);
            ChiselSpan = rootData.data;
            if (!string.IsNullOrEmpty(ChiselSpan.CashOut_Data))
                BillPpm_Span = JsonMapper.ToObject<CashOutData>(ChiselSpan.CashOut_Data);
            switch (AkinSpanThinker.BisAttest(CChisel.Gut_Botanist))
            {
                case "Russian":
                    BiteSpan = JsonMapper.ToObject<Init>(ChiselSpan.init_ru);
                    WideSpan = JsonMapper.ToObject<GameData>(ChiselSpan.game_data_ru);
                    break;
                case "Portuguese (Brazil)":
                    BiteSpan = JsonMapper.ToObject<Init>(ChiselSpan.init_br);
                    WideSpan = JsonMapper.ToObject<GameData>(ChiselSpan.game_data_br);
                    break;
                case "English":
                    BiteSpan = JsonMapper.ToObject<Init>(ChiselSpan.init_us);
                    WideSpan = JsonMapper.ToObject<GameData>(ChiselSpan.game_data_us);
                    break;
                case "Japanese":
                    BiteSpan = JsonMapper.ToObject<Init>(ChiselSpan.init_jp);
                    WideSpan = JsonMapper.ToObject<GameData>(ChiselSpan.game_data_jp);
                    break;
                default:
                    BiteSpan = JsonMapper.ToObject<Init>(ChiselSpan.init);
                    WideSpan = JsonMapper.ToObject<GameData>(ChiselSpan.game_data);
                    break;
            }
   
            BiteSpan.cash_group_real = new MultiGroup[BiteSpan.cash_group.Length];
            for (int i = 0; i < BiteSpan.cash_group.Length; i++)
            {
                MultiGroup multiGroup = new MultiGroup();
                multiGroup.max = BiteSpan.cash_group[i].max;
                multiGroup.multi = double.Parse(BiteSpan.cash_group[i].multi);
                multiGroup.weight_multi = BiteSpan.cash_group[i].weight_multi;
                BiteSpan.cash_group_real[i] = multiGroup;
            }

            if (!string.IsNullOrEmpty(ChiselSpan.Exchange))
                Hardware = JsonMapper.ToObject<double[]>(ChiselSpan.Exchange);

            BisBoonGenu();
            if (!PlayerPrefs.HasKey(CChisel.Gut_LopSH))
            {
                if (ChiselSpan.apple_pie != "apple")
                {
                    Debug.Log("sys_AppSH_______________Pass");
                    PlayerPrefs.SetInt(CChisel.Gut_LopSH, 1);
                }
            }
        }
        // if (ConfigData == null)
        // {
        //     RootData rootData = JsonMapper.ToObject<RootData>(configJson);
        //     ConfigData = rootData.data;
        //     InitData = JsonMapper.ToObject<Init>(ConfigData.init);
        //     GameData = JsonMapper.ToObject<GameData>(ConfigData.game_data);
        //     GetUserInfo();
        // }
    }
    /// <summary>
    /// 进入游戏
    /// </summary>
    void WideNotch()
    {
        //打开admanager
        // adManager.SetActive(true);
        //进度条可以继续
        Harsh = true;
    }



    /// <summary>
    /// 超时处理
    /// </summary>
    /// <param name="finish"></param>
    /// <returns></returns>
    IEnumerator TanToilTiltPpm(Action finish)
    {
        yield return new WaitForSeconds(TIMEOUT);
        finish();
    }

    /// <summary>
    /// 向后台发送adjustId
    /// </summary>
    public void CastVagaryBath()
    {
        string serverId = AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe);
        string adjustId = VagaryBiteThinker.Instance.BisVagaryBath();
        if (string.IsNullOrEmpty(serverId) || string.IsNullOrEmpty(adjustId))
        {
            return;
        }

        string url = VagaryCry + "&serverId=" + serverId + "&adid=" + adjustId;
        TanToilThinker.BisFeedback().EmitBis(url,
            (data) => {
                Debug.Log("服务器更新adjust adid 成功" + data.downloadHandler.text);
            },
            () => {
                Debug.Log("服务器更新adjust adid 失败");
            });
        CashOutManager.BisFeedback().ReportAdjustID();
    }
    //轮询检查Adjust归因信息
    int TasteTrove= 0;
    [HideInInspector] [UnityEngine.Serialization.FormerlySerializedAs("Event_TrackerName")][UnityEngine.Serialization.FormerlySerializedAs("Bulge_SurpassClaw")]public string Sheer_WorshipBard; //打点用参数
    bool _TasteAx= false;
    [HideInInspector]
    public bool VagaryWorship_Notch{
        get
        {
            if (Application.isEditor) //编译器跳过检查
                return true;
            return _TasteAx;
        }
    }
    public void TasteVagaryBattery() //检查Adjust归因信息
    {
        if (Application.isEditor) //编译器跳过检查
            return;
        if (!string.IsNullOrEmpty(Sheer_WorshipBard)) //已经拿到归因信息
            return;

        CancelInvoke(nameof(TasteVagaryBattery));
        if (!string.IsNullOrEmpty(ChiselSpan.fall_down) && ChiselSpan.fall_down == "fall")
        {
            print("Adjust 无归因相关配置或未联网 跳过检查");
            _TasteAx = true;
        }
        try
        {
            AdjustAttribution Genu= Adjust.getAttribution();
            print("Adjust 获取信息成功 归因渠道：" + Genu.trackerName);
            Sheer_WorshipBard = "TrackerName: " + Genu.trackerName;
            BurrowLift.Vagary_WorshipBard = Genu.trackerName;
            _TasteAx = true;
        }
        catch (System.Exception e)
        {
            TasteTrove++;
            Debug.Log("Adjust 获取信息失败：" + e.Message + " 重试次数：" + TasteTrove);
            if (TasteTrove >= 10)
                _TasteAx = true;
            Invoke(nameof(TasteVagaryBattery), 1);
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("UserDataStr")]
[UnityEngine.Serialization.FormerlySerializedAs("TiltHallLap")]    //获取用户信息
    public string BoonSpanLap= "";
[UnityEngine.Serialization.FormerlySerializedAs("UserData")]    [UnityEngine.Serialization.FormerlySerializedAs("TiltHall")]public UserInfoData BoonSpan;
    int BisBoonGenuTrove= 0;
    void BisBoonGenu()
    {
        //还有进入正常模式的可能
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "YES")
            PlayerPrefs.DeleteKey("Save_AP");
        //已经记录过用户信息 跳过检查
        if (PlayerPrefs.HasKey("OtherChance") && PlayerPrefs.GetString("OtherChance") == "NO")
        {
            WideNotch();
            return;
        }

        //检查归因渠道信息
        TasteVagaryBattery();
        //获取用户信息
        string CheckUrl = FirmCry + "/api/client/user/checkUser";
        TanToilThinker.BisFeedback().EmitBis(CheckUrl,
        (data) =>
        {
            BoonSpanLap = data.downloadHandler.text;
            print("+++++ 获取用户数据 成功" + BoonSpanLap);
            UserRootData rootData = JsonMapper.ToObject<UserRootData>(BoonSpanLap);
            BoonSpan = JsonMapper.ToObject<UserInfoData>(rootData.data);
            if (BoonSpanLap.Contains("apple")
            || BoonSpanLap.Contains("Apple")
            || BoonSpanLap.Contains("APPLE"))
                BoonSpan.IsHaveApple = true;
            WideNotch();
        }, () => { });
        Invoke(nameof(MyBisBoonGenu), 1);
    }
    void MyBisBoonGenu()
    {
        if (!Harsh)
        {
            BisBoonGenuTrove++;
            if (BisBoonGenuTrove < 10)
            {
                print("+++++ 获取用户数据失败 重试： " + BisBoonGenuTrove);
                BisBoonGenu();
            }
            else
            {
                print("+++++ 获取用户数据 失败次数过多，放弃");
                WideNotch();
            }
        }
    }

}
