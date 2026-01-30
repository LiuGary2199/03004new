/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CChisel
{
    #region 常量字段
    //登录url
    public const string IdiomCry= "/api/client/user/getId?gameCode=";
    //配置url
    public const string ChiselCry= "/api/client/config?gameCode=";
    //时间戳url
    public const string TiltCry= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string VagaryCry= "/api/client/user/setAdjustId?gameCode=";
    
    public const string Gut_Botanist= "sys_language";

    public const string Gut_LopSH= "sys_AppSH";
    #endregion

    #region 本地存储的字符串


    public const string Ox_IsBiteSpan= "sv_IsInitData";

    public const string Ox_Tan_Tap_Deed= "sv_big_win_cash";
    
    public const string Son_Slush_Aphid_Sap_Alter= "msg_close_panel_and_start";

    public const string Ox_Tenth_Bind_Pollute= "sv_fever_time_current";

    public const string Ox_Enable_Six_Limy_Pluto= "sv_finish_new_user_guide";

    public const string Ox_France_Dampen_Plank= "sv_bigwin_weight_multi";
    
    
    
    
    
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string Ox_EmptyThinMe= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string Ox_EmptyUnwellMe= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string Ox_ItRatVictim= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string Ox_ShapeSnowyNssTrove= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string Ox_ShapeSnowyDraw= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string Ox_RatBoonWeft= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string Ox_ChopGill= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string Ox_AppreciateChopGill= "sv_CumulativeGoldCoin";
    
    public const string Ox_Bill= "sv_Cash";

    public const string Ox_AppreciateBill= "sv_CumulativeCash";

    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string Ox_Either= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string Ox_AppreciateChisel= "sv_CumulativeAmazon";
    
    public const string Ox_Beach_July_Tie= "sv_steel_ball_num";

    public const string Ox_AppreciateRice= "sv_CumulativeBall";
    
    public const string Ox_Beach_July_Rain= "sv_steel_ball_date";
    
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string Ox_EruptWideTilt= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string Ox_HobbyBisViral= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string Ox_DigFirnWarnSkill= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string Ox_AppreciateUnknown= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string Ox_CuratorSaltShaman= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string Ox_RatBoonWeftFunnel= "sv_NewUserStepFinish";
    public const string Ox_Clam_Adapt_Trash= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string Ox_HobbyPlug= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string Ox_VagaryBath= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string Ox_To_Buggy_Tie= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string Ox_Shale_To_Tie= "sv_total_ad_num";


    public const string Ox_Draft_Roam_Tap_777= "sv_first_bing_win_777";
    
    public const string Ox_Alter_Late_Tap_Turtle= "sv_first_bing_win_reward";
    public const string Son_Yale_Deed_Ploy= "msg_show_cash_mask";
    public const string Ox_Alter_Ice_Ant= "sv_start_fiy_box";
    public const string Ox_Alter_Deed_Eke= "sv_first_cash_out";
    public const string Son_Yale_Line_us= "msg_show_rate_us";
    public const string Ox_Alter_Salt_Chimp= "sv_first_slot_again";
    public const string Ox_Untrue_Tap_No_No= "sv_normal_win_ad_id";
    public const string Ox_Untrue_Tap_News= "sv_normal_win_type";
    public const string Ox_Lawn_News= "sv_gems_type";
    public const string Ox_Wartime_Wok_July= "sv_first_add_ball";


    // 任务系统
    public const string HugeBallStingerSpan_B= "LastTaskRefreshDate_B";
    public const string BallLimner_B= "TaskStatus_B_"; // TaskStatus_B_{taskId}
    public const string BallAtlantic_B= "TaskProgress_B_"; // TaskProgress_B_{taskId}
    public const string PlazaSingletonVacant_B= "TodayCompletedLevels_B"; // 今天完成的关卡数

    // 时间领奖系统
    public const string DeedEssayStingerSpan_A= "LastTimerRefreshDate_A";
    public const string EssayLimner_A= "TimerStatus_A_"; // TimerStatus_A_{timerId}
    public const string EssayLayerFile_A= "TimerStartTime_A_"; // TimerStartTime_A_{timerId} 每个计时器的开始时间（累积在线时长，秒）
    public const string EssayAppreciablyFile_A= "TimerAccumulatedTime_A"; // 累积的在线时长（秒）
    public const string EssayDeedAshcanFile_A= "TimerLastUpdateTime_A"; // 上次更新时间（Time.unscaledTime）   

    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string mg_IndoorFeat= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string On_IndoorHappy= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string On_ui_Compositional= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string On_Ox_Gesture= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string On_Ox_Actively= "mg_ui_addtoken";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string On_Ox_Endowment= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string On_WideRedwing= "mg_GameSuspend";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string Epic_ChopGill_Length= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Join_Viral_Length_Source= "Art/Tex/UI/jiangli4";

    public static string Peg_High= "Prefab/Peg_High";
    public static string Peg_End= "Prefab/Peg_End";
    public static string Peg_Perplex= "Prefab/Peg_Perplex";
    public static string Peg_Emboss= "Prefab/Emboss";
    public static string Ail_10= "Art/Tex/Ail_10";
    public static string End_8= "Art/Tex/End_8";
    public static string KeyTrove= "Art/Tex/BoxCount/x";

    #endregion
}

