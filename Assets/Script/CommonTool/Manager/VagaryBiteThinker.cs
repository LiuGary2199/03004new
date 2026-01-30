using System;
using System.Collections;
using com.adjust.sdk;
using UnityEngine;
using Random = UnityEngine.Random;

public class VagaryBiteThinker : MonoBehaviour
{
    public static VagaryBiteThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("adjustID")]
[UnityEngine.Serialization.FormerlySerializedAs("VoyageID")]    public string UniqueID;     // 由遇总的打包工具统一修改，无需手动配置

    //用户adjust 状态KEY
    private string If_ADGoalBiteCity= "sv_ADJustInitType";

    //adjust 时间戳
    private string Ox_ADFromTilt= "sv_ADJustTime";

    //adjust行为计数器
    public int _PolluteTrove{ get; private set; }


    private void Awake()
    {
        Instance = this;
        AkinSpanThinker.GapAttest(Ox_ADFromTilt, DrawLift.Bequest().ToString());

#if UNITY_IOS
        AkinSpanThinker.GapAttest(If_ADGoalBiteCity, AdjustStatus.OpenAsAct.ToString());
        VagaryBite();
#endif
    }

    private void Start()
    {
        _PolluteTrove = 0;
    }


    void VagaryBite()
    {
        AdjustConfig adjustConfig = new AdjustConfig(UniqueID, AdjustEnvironment.Production, false);
        adjustConfig.setLogLevel(AdjustLogLevel.Verbose);
        adjustConfig.setSendInBackground(false);
        adjustConfig.setEventBufferingEnabled(false);
        adjustConfig.setLaunchDeferredDeeplink(true);
        Adjust.start(adjustConfig);

        StartCoroutine(AkinVagaryBath());
    }

    private IEnumerator AkinVagaryBath()
    {
        while (true)
        {
            string adjustAdid = Adjust.getAdid();
            if (string.IsNullOrEmpty(adjustAdid))
            {
                yield return new WaitForSeconds(5);
            }
            else
            {
                AkinSpanThinker.GapAttest(CChisel.Ox_VagaryBath, adjustAdid);
                TanGenuUSA.instance.CastVagaryBath();
                yield break;
            }
        }
    }

    public string BisVagaryBath()
    {
        return AkinSpanThinker.BisAttest(CChisel.Ox_VagaryBath);
    }

    /// <summary>
    /// 获取adjust初始化状态
    /// </summary>
    /// <returns></returns>
    public string BisVagaryRadius()
    {
        return AkinSpanThinker.BisAttest(If_ADGoalBiteCity);
    }

    /*
     *  API
     *  标记老用户
     */
    public void TanBoonGap()
    {
        
        print("old user add adjust status");
        AkinSpanThinker.GapAttest(If_ADGoalBiteCity, AdjustStatus.OldUser.ToString());
        SelfSheerRibbon.BisFeedback().CastSheer("1093", BisVagaryTilt());
    }


    /*
     *  API
     *  Adjust 初始化
     */
    public void BiteVagarySpan(bool isOldUser = false)
    {
        #if UNITY_IOS
            return;
        #endif
        if (AkinSpanThinker.BisAttest(If_ADGoalBiteCity) == "" && isOldUser)
        {
            TanBoonGap();
        }
        // 如果后台配置的adjust_init_act_position <= 0，直接初始化
        if (string.IsNullOrEmpty(TanGenuUSA.instance.ChiselSpan.adjust_init_act_position) || int.Parse(TanGenuUSA.instance.ChiselSpan.adjust_init_act_position) <= 0)
        {
            AkinSpanThinker.GapAttest(If_ADGoalBiteCity, AdjustStatus.OpenAsAct.ToString());
        }
        print(" user init adjust by status :" + AkinSpanThinker.BisAttest(If_ADGoalBiteCity));
        //用户二次登录 根据标签初始化
        if (AkinSpanThinker.BisAttest(If_ADGoalBiteCity) == AdjustStatus.OldUser.ToString() || AkinSpanThinker.BisAttest(If_ADGoalBiteCity) == AdjustStatus.OpenAsAct.ToString())
        {
            print("second login  and  init adjust");
            VagaryBite();
        }
    }



    /*
     * API
     *  记录行为累计次数
     *  @param2 打点参数
     */
    public void BisEndTrove(string param2 = "")
    {
#if UNITY_IOS
            return;
#endif
        if (AkinSpanThinker.BisAttest(If_ADGoalBiteCity) != "") return;
        _PolluteTrove++;
        print(" add up to :" + _PolluteTrove);
        if (string.IsNullOrEmpty(TanGenuUSA.instance.ChiselSpan.adjust_init_act_position) || _PolluteTrove == int.Parse(TanGenuUSA.instance.ChiselSpan.adjust_init_act_position))
        {
            WantVagaryItEnd(param2);
        }
    }

    /*
     * API
     * 根据行为 初始化 adjust
     *  @param2 打点参数 
     */
    public void WantVagaryItEnd(string param2 = "")
    {
        if (AkinSpanThinker.BisAttest(If_ADGoalBiteCity) != "") return;

        // 根据比例分流   adjust_init_rate_act  行为比例
        if (string.IsNullOrEmpty(TanGenuUSA.instance.ChiselSpan.adjust_init_rate_act) || int.Parse(TanGenuUSA.instance.ChiselSpan.adjust_init_rate_act) > Random.Range(0, 100))
        {
            print("user finish  act  and  init adjust");
            AkinSpanThinker.GapAttest(If_ADGoalBiteCity, AdjustStatus.OpenAsAct.ToString());
            VagaryBite();

            // 上报点位 新用户达成 且 初始化
            SelfSheerRibbon.BisFeedback().CastSheer("1091", BisVagaryTilt(), param2);
        }
        else
        {
            print("user finish  act  and  not init adjust");
            AkinSpanThinker.GapAttest(If_ADGoalBiteCity, AdjustStatus.CloseAsAct.ToString());
            // 上报点位 新用户达成 且  不初始化
            SelfSheerRibbon.BisFeedback().CastSheer("1092", BisVagaryTilt(), param2);
        }
    }

    
    /*
     * API
     *  重置当前次数
     */
    public void LoderEndTrove()
    {
        print("clear current ");
        _PolluteTrove = 0;
    }


    // 获取启动时间
    private string BisVagaryTilt()
    {
        return DrawLift.Bequest() - long.Parse(AkinSpanThinker.BisAttest(Ox_ADFromTilt)) + "";
    }
}


/*
 *@param
 *  OldUser     老用户
 *  OpenAsAct   行为触发且初始化
 *  CloseAsAct  行为触发不初始化
 */
public enum AdjustStatus
{
    OldUser,
    OpenAsAct,
    CloseAsAct
}