using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using com.adjust.sdk;
using LitJson;

public class ADThinker : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]    [UnityEngine.Serialization.FormerlySerializedAs("MAX_SDK_KEY")]public string MAX_SDK_KEY= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]    [UnityEngine.Serialization.FormerlySerializedAs("MAX_REWARD_ID")]public string MAX_REWARD_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]    [UnityEngine.Serialization.FormerlySerializedAs("MAX_INTER_ID")]public string MAX_INTER_ID= "";
[UnityEngine.Serialization.FormerlySerializedAs("isTest")]
[UnityEngine.Serialization.FormerlySerializedAs("WeCoil")]    public bool ToRend= false;
    public static ADThinker Feedback{ get; private set; }

    private int FaultExplode;   // 广告加载失败后，重新加载广告次数
    private bool ToTextureMy;     // 是否正在播放广告，用于判断切换前后台时是否增加计数

    public int BoatLionTiltGaseous{ get; private set; }   // 距离上次广告的时间间隔
    public int Liberty101{ get; private set; }     // 定时插屏(101)计数器
    public int Toehold102{ get; private set; }     // NoThanks插屏(102)计数器
    public int Toehold103{ get; private set; }     // 后台回前台插屏(103)计数器

    private string TurtleBatteryBard;
    private Action<bool> TurtleNormDungBreath;    // 激励视频回调
    private bool TurtleProduce;     // 激励视频是否成功收到奖励
    private string TurtleAngry;     // 激励视频的打点

    private string ContemporaryBatteryBard;
    private int ContemporaryCity;      // 当前播放的插屏类型，101/102/103
    private string ContemporaryAngry;     // 插屏广告的的打点
    public bool TheftTiltTavernkeeper{ get; private set; } // 定时插屏暂停播放

    private List<Action<ADType>> ToExpanseProfiteer;    // 广告播放完成回调列表，用于其他系统广告计数（例如商店看广告任务）

    private long EvaporationOfferLogically;     // 切后台时的时间戳
    private Ad_CustomData FecundAtWalnutSpan; //激励视频自定义数据
    private Ad_CustomData TavernkeeperAtWalnutSpan; //插屏自定义数据

    private void Awake()
    {
        Feedback = this;
    }

    private void OnEnable()
    {
        TheftTiltTavernkeeper = false;
        ToTextureMy = false;
        BoatLionTiltGaseous = 999;  // 初始时设置一个较大的值，不阻塞插屏广告
        TurtleProduce = false;

        // Android平台将Adjust的adid传给Max；iOS将randomKey传给Max
#if UNITY_ANDROID
        MaxSdk.SetSdkKey(BisIndigoSpan.DecryptDES(MAX_SDK_KEY));
        // 将adjust id 传给Max
        string adjustId = AkinSpanThinker.GetString(CChisel.sv_AdjustAdid);
        if (string.IsNullOrEmpty(adjustId))
        {
            adjustId = Adjust.getAdid();
        }
        if (!string.IsNullOrEmpty(adjustId))
        {
            MaxSdk.SetUserId(adjustId);
            MaxSdk.InitializeSdk();
            AkinSpanThinker.SetString(CChisel.sv_AdjustAdid, adjustId);
        }
        else
        {
            StartCoroutine(setAdjustAdid());
        }
#else
        MaxSdk.SetSdkKey(BisIndigoSpan.ObscureDES(MAX_SDK_KEY));
        MaxSdk.SetUserId(AkinSpanThinker.BisAttest(CChisel.Ox_EmptyThinMe));
        MaxSdk.InitializeSdk();
#endif

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {
            // 打开调试模式
            //MaxSdk.ShowMediationDebugger();

            UnhinderedInformalRoe();
            MaxSdk.SetCreativeDebuggerEnabled(true);

            // 每秒执行一次计数
            InvokeRepeating(nameof(SeldomBoomer), 1, 1);
        };
    }

    IEnumerator AgeVagaryBath()
    {
        int i = 0;
        while (i < 5)
        {
            yield return new WaitForSeconds(1);
            if (BurrowLift.ItCounty())
            {
                MaxSdk.SetUserId(AkinSpanThinker.BisAttest(CChisel.Ox_EmptyThinMe));
                MaxSdk.InitializeSdk();
                yield break;
            }
            else
            {
                string adjustId = Adjust.getAdid();
                if (!string.IsNullOrEmpty(adjustId))
                {
                    MaxSdk.SetUserId(adjustId);
                    MaxSdk.InitializeSdk();
                    AkinSpanThinker.GapAttest(CChisel.Ox_VagaryBath, adjustId);
                    yield break;
                }
            }
            i++;
        }
        if (i == 5)
        {
            MaxSdk.SetUserId(AkinSpanThinker.BisAttest(CChisel.Ox_EmptyThinMe));
            MaxSdk.InitializeSdk();
        }
    }

    public void UnhinderedInformalRoe()
    {
        // Attach callback
        MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += OnRewardedAdLoadedEvent;
        MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += OnRewardedAdLoadFailedEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += OnRewardedAdDisplayedEvent;
        MaxSdkCallbacks.Rewarded.OnAdClickedEvent += OnRewardedAdClickedEvent;
        MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += OnRewardedAdRevenuePaidEvent;
        MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += OnRewardedAdHiddenEvent;
        MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += OnRewardedAdFailedToDisplayEvent;
        MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += OnRewardedAdReceivedRewardEvent;

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += OnInterstitialRevenuePaidEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;

        // Load the first rewarded ad
        WantInformalAt();

        // Load the first interstitial
        WantTavernkeeper();
    }

    private void WantInformalAt()
    {
        MaxSdk.LoadRewardedAd(MAX_REWARD_ID);
    }

    private void WantTavernkeeper()
    {
        MaxSdk.LoadInterstitial(MAX_INTER_ID);
    }

    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is ready for you to show. MaxSdk.IsRewardedAdReady(adUnitId) now returns 'true'.

        // Reset retry attempt
        FaultExplode = 0;
        TurtleBatteryBard = adInfo.NetworkName;

        FecundAtWalnutSpan = new Ad_CustomData();
        FecundAtWalnutSpan.user_id = CashOutManager.BisFeedback().Data.UserID;
        FecundAtWalnutSpan.version = Application.version;
        FecundAtWalnutSpan.request_id = CashOutManager.BisFeedback().EcpmRequestID();
        FecundAtWalnutSpan.vendor = adInfo.NetworkName;
    }

    private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Rewarded ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds).

        FaultExplode++;
        double retryDelay = Math.Pow(2, Math.Min(6, FaultExplode));

        Invoke(nameof(WantInformalAt), (float)retryDelay);
    }

    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        GooseUSA.BisFeedback().OxGooseIndian = !GooseUSA.BisFeedback().OxGooseIndian;
        Time.timeScale = 0;
#endif
    }

    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad failed to display. AppLovin recommends that you load the next ad.
        WantInformalAt();
        ToTextureMy = false;
    }

    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {

    }

    private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Rewarded ad is hidden. Pre-load the next ad
#if UNITY_IOS
        Time.timeScale = 1;
        GooseUSA.BisFeedback().OxGooseIndian = !GooseUSA.BisFeedback().OxGooseIndian;
#endif

        ToTextureMy = false;
        WantInformalAt();
        if (TurtleProduce)
        {
            TurtleProduce = false;
            TurtleNormDungBreath?.Invoke(true);

            WristAtLionProduce(ADType.Rewarded);
            SelfSheerRibbon.BisFeedback().CastSheer("9007", TurtleAngry);
        }
        else
        {
            TurtleNormDungBreath?.Invoke(false);
        }

        // 上报ecpm
        CashOutManager.BisFeedback().ReportEcpm(adInfo, FecundAtWalnutSpan.request_id, "REWARD");
    }

    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdk.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        // The rewarded ad displayed and the user should receive the reward.
        TurtleProduce = true;
    }

    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        // Ad revenue paid. Use this callback to track user revenue.
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        SelfSheerRibbon.BisFeedback().CastSheer("9008", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        //VagaryBiteThinker.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        string adjustAdid = VagaryBiteThinker.Instance.BisVagaryBath();
        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(adjustAdid))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (rewarded), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Rewarded revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is ready for you to show. MaxSdk.IsInterstitialReady(adUnitId) now returns 'true'

        // Reset retry attempt
        FaultExplode = 0;
        ContemporaryBatteryBard = adInfo.NetworkName;

        TavernkeeperAtWalnutSpan = new Ad_CustomData();
        TavernkeeperAtWalnutSpan.user_id = CashOutManager.BisFeedback().Data.UserID;
        TavernkeeperAtWalnutSpan.version = Application.version;
        TavernkeeperAtWalnutSpan.request_id = CashOutManager.BisFeedback().EcpmRequestID();
        TavernkeeperAtWalnutSpan.vendor = adInfo.NetworkName;
    }

    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        // Interstitial ad failed to load 
        // AppLovin recommends that you retry with exponentially higher delays, up to a maximum delay (in this case 64 seconds)

        FaultExplode++;
        double retryDelay = Math.Pow(2, Math.Min(6, FaultExplode));

        Invoke(nameof(WantTavernkeeper), (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
#if UNITY_IOS
        GooseUSA.BisFeedback().OxGooseIndian = !GooseUSA.BisFeedback().OxGooseIndian;
        Time.timeScale = 0;
#endif
    }

    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad failed to display. AppLovin recommends that you load the next ad.
        WantTavernkeeper();
        ToTextureMy = false;
    }

    private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo info)
    {
        //从MAX获取收入数据
        var adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
        adRevenue.setRevenue(info.Revenue, "USD");
        adRevenue.setAdRevenueNetwork(info.NetworkName);
        adRevenue.setAdRevenueUnit(info.AdUnitIdentifier);
        adRevenue.setAdRevenuePlacement(info.Placement);

        //发回收入数据给自己后台
        string countryCodeByMAX = MaxSdk.GetSdkConfiguration().CountryCode; // "US" for the United States, etc - Note: Do not confuse this with currency code which is "USD"
        SelfSheerRibbon.BisFeedback().CastSheer("9108", info.Revenue.ToString(), countryCodeByMAX);

        //带广告收入的漏传策略
        //VagaryBiteThinker.Instance.AddAdCount(countryCodeByMAX, info.Revenue);

        //发回收入数据给Adjust
        if (!string.IsNullOrEmpty(VagaryBiteThinker.Instance.BisVagaryBath()))
        {
            Adjust.trackAdRevenue(adRevenue);
            UnityEngine.Debug.Log("Max to Adjust (interstitial), adUnitId:" + adUnitId + ", revenue:" + info.Revenue + ", network:" + info.NetworkName + ", unit:" + info.AdUnitIdentifier + ", placement:" + info.Placement);
        }

        // 发回收入数据给Mintegral
        string adjustAdid = VagaryBiteThinker.Instance.BisVagaryBath();
        if (!string.IsNullOrEmpty(adjustAdid))
        {
#if UNITY_ANDROID || UNITY_IOS
            MBridgeRevenueParamsEntity mBridgeRevenueParamsEntity = new MBridgeRevenueParamsEntity(MBridgeRevenueParamsEntity.ATTRIBUTION_PLATFORM_ADJUST, adjustAdid);
            ///MaxSdkBase.AdInfo类型的adInfo
            mBridgeRevenueParamsEntity.SetMaxAdInfo(info);
            MBridgeRevenueManager.Track(mBridgeRevenueParamsEntity);
            UnityEngine.Debug.Log(nameof(MBridgeRevenueManager) + "~Interstitial revenue:" + info.Revenue);
#endif
        }
    }

    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        // Interstitial ad is hidden. Pre-load the next ad.
#if UNITY_IOS
        Time.timeScale = 1;
        GooseUSA.BisFeedback().OxGooseIndian = !GooseUSA.BisFeedback().OxGooseIndian;
#endif
        WantTavernkeeper();

        WristAtLionProduce(ADType.Interstitial);
        SelfSheerRibbon.BisFeedback().CastSheer("9107", ContemporaryAngry);
        // 上报ecpm
        CashOutManager.BisFeedback().ReportEcpm(adInfo, TavernkeeperAtWalnutSpan.request_id, "INTER");
    }


    /// <summary>
    /// 播放激励视频广告
    /// </summary>
    /// <param name="callBack"></param>
    /// <param name="index"></param>
    public void DeepFecundAward(Action<bool> callBack, string index)
    {
        if (ToRend)
        {
            callBack(true);
            WristAtLionProduce(ADType.Rewarded);
            return;
        }

        bool rewardVideoReady = MaxSdk.IsRewardedAdReady(MAX_REWARD_ID);
        TurtleNormDungBreath = callBack;
        if (rewardVideoReady)
        {
            // 打点
            TurtleAngry = index;
            SelfSheerRibbon.BisFeedback().CastSheer("9002", index);
            ToTextureMy = true;
            TurtleProduce = false;
            string placement = index + "_" + TurtleBatteryBard;
            FecundAtWalnutSpan.placement_id = placement;
            MaxSdk.ShowRewardedAd(MAX_REWARD_ID, placement, JsonMapper.ToJson(FecundAtWalnutSpan));
        }
        else
        {
            CheerThinker.BisFeedback().FirnCheer("No ads right now, please try it later.");
            TurtleNormDungBreath(false);
        }
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index"></param>
    public void SkinTavernkeeperAt(int index)
    {
        if (index == 101 || index == 102 || index == 103)
        {
            UnityEngine.Debug.LogError("广告点位不允许为101、102、103");
            return;
        }

        SkinTavernkeeper(index);
    }

    /// <summary>
    /// 播放插屏广告
    /// </summary>
    /// <param name="index">101/102/103</param>
    /// <param name="customIndex">用户自定义点位</param>
    private void SkinTavernkeeper(int index, int customIndex = 0)
    {
        ContemporaryCity = index;

        if (ToTextureMy)
        {
            return;
        }

        //这个参数很少有游戏会用 需要的时候自己再打开
        // 当用户过关数 < trial_MaxNum时，不弹插屏广告
        // int sv_trialNum = AkinSpanThinker.GetInt(CChisel.sv_ad_trial_num);
        // int trial_MaxNum = int.Parse(TanGenuUSA.instance.ConfigData.trial_MaxNum);
        // if (sv_trialNum < trial_MaxNum)
        // {
        //     return;
        // }

        // 时间间隔低于阈值，不播放广告
        if (BoatLionTiltGaseous < int.Parse(TanGenuUSA.instance.ChiselSpan.inter_freq))
        {
            return;
        }

        if (ToRend)
        {
            WristAtLionProduce(ADType.Interstitial);
            return;
        }

        bool interstitialVideoReady = MaxSdk.IsInterstitialReady(MAX_INTER_ID);
        if (interstitialVideoReady)
        {
            ToTextureMy = true;
            // 打点
            string point = index.ToString();
            if (customIndex > 0)
            {
                point += customIndex.ToString().PadLeft(2, '0');
            }
            ContemporaryAngry = point;
            SelfSheerRibbon.BisFeedback().CastSheer("9102", point);
            string placement = point + "_" + ContemporaryBatteryBard;
            TavernkeeperAtWalnutSpan.placement_id = placement;
            MaxSdk.ShowInterstitial(MAX_INTER_ID, placement, JsonMapper.ToJson(TavernkeeperAtWalnutSpan));
        }
    }

    /// <summary>
    /// 每秒更新一次计数器 - 101计数器 和 时间间隔计数器
    /// </summary>
    private void SeldomBoomer()
    {
        BoatLionTiltGaseous++;

        int relax_interval = int.Parse(TanGenuUSA.instance.ChiselSpan.relax_interval);
        // 计时器阈值设置为0或负数时，关闭广告101；
        // 播放广告期间不计数；
        if (relax_interval <= 0 || ToTextureMy)
        {
            return;
        }
        else
        {
            Liberty101++;
            if (Liberty101 >= relax_interval && !TheftTiltTavernkeeper)
            {
                SkinTavernkeeper(101);
            }
        }
    }

    /// <summary>
    /// NoThanks插屏 - 102
    /// </summary>
    public void ToMutualBisTrove(int customIndex = 0)
    {
        // 用户行为累计次数计数器阈值设置为0或负数时，关闭广告102
        int nextlevel_interval = int.Parse(TanGenuUSA.instance.ChiselSpan.nextlevel_interval);
        if (nextlevel_interval <= 0)
        {
            return;
        }
        else
        {
            Toehold102 = AkinSpanThinker.BisFew("NoThanksCount") + 1;
            AkinSpanThinker.GapFew("NoThanksCount", Toehold102);
            if (Toehold102 >= nextlevel_interval)
            {
                SkinTavernkeeper(102, customIndex);
            }
        }
    }

    /// <summary>
    /// 前后台切换计数器 - 103
    /// </summary>
    /// <param name="pause"></param>
    private void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            // 切回前台
            if (!ToTextureMy)
            {
                // 前后台切换时，播放间隔计数器需要累加切到后台的时间
                if (EvaporationOfferLogically > 0)
                {
                    BoatLionTiltGaseous += (int)(DrawLift.Bequest() - EvaporationOfferLogically);
                    EvaporationOfferLogically = 0;
                }
                // 后台切回前台累计次数，后台配置为0或负数，关闭该广告
                int inter_b2f_count = int.Parse(TanGenuUSA.instance.ChiselSpan.inter_b2f_count);
                if (inter_b2f_count <= 0)
                {
                    return;
                }
                else
                {
                    Toehold103++;
                    if (Toehold103 >= inter_b2f_count)
                    {
                        SkinTavernkeeper(103);
                    }
                }
            }
        }
        else
        {
            // 切到后台
            EvaporationOfferLogically = DrawLift.Bequest();
        }
    }

    /// <summary>
    /// 暂停定时插屏播放 - 101
    /// </summary>
    public void OfferTiltTavernkeeper()
    {
        TheftTiltTavernkeeper = true;
    }

    /// <summary>
    /// 恢复定时插屏播放 - 101
    /// </summary>
    public void EncaseTiltTavernkeeper()
    {
        TheftTiltTavernkeeper = false;
    }

    /// <summary>
    /// 更新游戏的TrialNum
    /// </summary>
    /// <param name="num"></param>
    public void SnuglyBladeElk(int num)
    {
        AkinSpanThinker.GapFew(CChisel.Ox_To_Buggy_Tie, num);
    }

    /// <summary>
    /// 注册看广告的回调事件
    /// </summary>
    /// <param name="callback"></param>
    public void RetrieveLionTotemism(Action<ADType> callback)
    {
        if (ToExpanseProfiteer == null)
        {
            ToExpanseProfiteer = new List<Action<ADType>>();
        }

        if (!ToExpanseProfiteer.Contains(callback))
        {
            ToExpanseProfiteer.Add(callback);
        }
    }

    /// <summary>
    /// 广告播放成功后，执行看广告回调事件
    /// </summary>
    private void WristAtLionProduce(ADType adType)
    {
        ToTextureMy = false;
        // 播放间隔计数器清零
        BoatLionTiltGaseous = 0;
        // 插屏计数器清零
        if (adType == ADType.Interstitial)
        {
            // 计数器清零
            if (ContemporaryCity == 101)
            {
                Liberty101 = 0;
            }
            else if (ContemporaryCity == 102)
            {
                Toehold102 = 0;
                AkinSpanThinker.GapFew("NoThanksCount", 0);
            }
            else if (ContemporaryCity == 103)
            {
                Toehold103 = 0;
            }
        }

        // 看广告总数+1
        AkinSpanThinker.GapFew(CChisel.Ox_Shale_To_Tie + adType.ToString(), AkinSpanThinker.BisFew(CChisel.Ox_Shale_To_Tie + adType.ToString()) + 1);
        // 真提现任务 
        if (adType == ADType.Rewarded)
            CashOutManager.BisFeedback().AddTaskValue("Ad",1);

        // 回调
        if (ToExpanseProfiteer != null && ToExpanseProfiteer.Count > 0)
        {
            foreach (Action<ADType> callback in ToExpanseProfiteer)
            {
                callback?.Invoke(adType);
            }
        }
    }

    /// <summary>
    /// 获取总的看广告次数
    /// </summary>
    /// <returns></returns>
    public int BisEruptAtElk(ADType adType)
    {
        return AkinSpanThinker.BisFew(CChisel.Ox_Shale_To_Tie + adType.ToString());
    }
}

public enum ADType { Interstitial, Rewarded }

[System.Serializable]
public class Ad_CustomData //广告自定义数据
{
    public string user_id; //用户id
    public string version; //版本号
    public string request_id; //请求id
    public string vendor; //渠道
    public string placement_id; //广告位id
}