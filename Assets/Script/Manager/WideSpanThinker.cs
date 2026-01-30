using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideSpanThinker : GistThickness<WideSpanThinker>
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void BiteWideSpan()
    {
        BiteRatSpan();

    }


    private void BiteRatSpan()
    {
        if (AkinSpanThinker.BisAttest(CChisel.Ox_IsBiteSpan) != "done")
        {
            // 新用户 初始化数据
            AkinSpanThinker.GapAttest(CChisel.Ox_IsBiteSpan, "done");
            // 新手引导
            AkinSpanThinker.GapAttest(CChisel.Ox_Enable_Six_Limy_Pluto, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_Draft_Roam_Tap_777, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_HobbyPlug, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Late_Tap_Turtle, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Ice_Ant, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Deed_Eke, "new");
            AkinSpanThinker.GapAttest(CChisel.Son_Yale_Line_us, "new");
            AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Salt_Chimp, "new");
            

            
            //收集物初始化
            AkinSpanThinker.GapFew(GemsType.Blue.ToString(), 0);
            AkinSpanThinker.GapFew(GemsType.Blue + "All", 0);
            AkinSpanThinker.GapFew(GemsType.Yellow.ToString(), 0);
            AkinSpanThinker.GapFew(GemsType.Yellow + "All", 0);
            AkinSpanThinker.GapFew(GemsType.Silver.ToString(), 0);
            AkinSpanThinker.GapFew(GemsType.Silver + "All", 0);
            AkinSpanThinker.GapFew(GemsType.GoldBar.ToString(), 0);
            AkinSpanThinker.GapFew(GemsType.GoldBar + "All", 0);
            
            // 余额初始化
            AkinSpanThinker.GapHeyday(CChisel.Ox_Bill, 0);
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateBill, 0);
            AkinSpanThinker.GapHeyday(CChisel.Ox_ChopGill, 0);
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateChopGill, 0);
            AkinSpanThinker.GapHeyday(CChisel.Ox_Either, 0);
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateChisel, 0);
            AkinSpanThinker.GapFew(CChisel.Ox_Beach_July_Tie, TanGenuUSA.instance.WideSpan.base_config.new_user_ball_count);
            AkinSpanThinker.GapFew(CChisel.Ox_AppreciateRice, 30);
            
            AkinSpanThinker.GapHeyday(CChisel.Ox_France_Dampen_Plank, 1);
            
        }

        // 
        List<GemsDataItem> DrySpanThen= TanGenuUSA.instance.WideSpan.Gem_Reward_list;
        foreach (GemsDataItem item in DrySpanThen)
        {
            string gemType = item.gem_type;
            int gemMax = item.gem_limit;
            AkinSpanThinker.GapFew(gemType + "Max", gemMax);
        }
    }

    // 金币
    public double BisChop()
    {
        return AkinSpanThinker.BisHeyday(CChisel.Ox_ChopGill);
    }

    public double BisAppreciateChopGill()
    {
        return AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateChopGill);
    }

    public void BisChop(double gold)
    {
        BisChop(gold, VerbThinker.Instance.transform);
    }

    public void BisChop(double gold, Transform startTransform)
    {
        double oldGold = AkinSpanThinker.BisHeyday(CChisel.Ox_ChopGill);
        AkinSpanThinker.GapHeyday(CChisel.Ox_ChopGill, oldGold + gold);
        if (gold > 0)
        {
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateChopGill,
                AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateChopGill) + gold);
        }

        // ShrubbySpan md = new ShrubbySpan(oldGold);
        // md.valueTransform = startTransform;
        // ShrubbyRejoinFleet.GetInstance().Send(CChisel.mg_ui_addgold, md);
    }

    // 现金
    public double BisBill()
    {
       // return AkinSpanThinker.GetDouble(CChisel.sv_Cash);
        return CashOutManager.BisFeedback().Money;
    }
    
    public double BisAppreciateBill()
    {
        return AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateBill);
    }

    public void BisBill(double cash)
    {
        //AddCash(cash, VerbThinker.Instance.transform);
        CashOutManager.BisFeedback().AddMoney((float)cash);
    }

    public void BisBill(double cash, Transform startTransform)
    {
        double oldCash = AkinSpanThinker.BisHeyday(CChisel.Ox_Bill);
        double newCash = oldCash + cash;
        AkinSpanThinker.GapHeyday(CChisel.Ox_Bill, newCash);
        if (cash > 0)
        {
            double allCash = AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateBill);
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateBill, allCash + cash);
        }
//#if SOHOShop
//        SOHOShopManager.instance.UpdateCash();
//#endif
        // ShrubbySpan md = new ShrubbySpan(oldCash);
        // md.valueTransform = startTransform;
        // ShrubbyRejoinFleet.GetInstance().Send(CChisel.mg_ui_addtoken, md);
    }

    //Amazon卡
    public double BisChisel()
    {
        return AkinSpanThinker.BisHeyday(CChisel.Ox_Either);
    }
    
    public double BisAppreciateChisel()
    {
        return AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateChisel);
    }

    public void BisChisel(double amazon)
    {
        BisChisel(amazon, VerbThinker.Instance.transform);
    }

    public void BisChisel(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CChisel.Ox_Either)
            ? double.Parse(AkinSpanThinker.BisAttest(CChisel.Ox_Either))
            : 0;
        double newAmazon = oldAmazon + amazon;
        AkinSpanThinker.GapHeyday(CChisel.Ox_Either, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateChisel);
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateChisel, allAmazon + amazon);
        }

        ShrubbySpan md = new ShrubbySpan(oldAmazon);
        md.LomasShortness = startTransform;
        ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.On_Ox_Endowment, md);
    }


    public int BisRice()
    {
        return AkinSpanThinker.BisFew(CChisel.Ox_Beach_July_Tie);
    }

    public void BisRice(int num)
    {
        // AkinSpanThinker.SetInt(CChisel.sv_steel_ball_num, AkinSpanThinker.GetInt(CChisel.sv_steel_ball_num) + num);
        AkinSpanThinker.GapFew(CChisel.Ox_AppreciateRice, AkinSpanThinker.BisFew(CChisel.Ox_AppreciateRice) + num);
    }


    public void BisPeg(GemsType gemsType)
    {
        AkinSpanThinker.GapFew(gemsType.ToString(), AkinSpanThinker.BisFew(gemsType.ToString()) + 1);
        AkinSpanThinker.GapFew(gemsType + "All", AkinSpanThinker.BisFew(gemsType + "All") + 1);
        if (AkinSpanThinker.BisFew(gemsType.ToString()) == AkinSpanThinker.BisFew(gemsType + "Max"))
        {
            PatentBraceThinker.Instance.FirnGrandmaRiderSkill();
        }

    }


    // 四个计时器：5、10、15、20分钟
    private readonly int[] NicheHydraulic= { 1, 10, 15, 20 }; // 每个计时器的分钟数
    private readonly int NicheKorean= 1000; // 每个奖励200金币
    private float _DecoAshcanFile= 0f; // 上次更新时间（Time.unscaledTime）
    private float _MicrofossilFile= 0f; // 累积的在线时长（秒）
    /// <summary>
    /// 检查并刷新每日时间领奖
    /// </summary>
    public void FancyDieStingerValveFigure()
    {
        string lastRefreshDate = PlayerPrefs.GetString(CChisel.DeedEssayStingerSpan_A, "");
        string today = DateTime.Now.ToString("yyyy-MM-dd");

        if (lastRefreshDate != today)
        {
            // 新的一天，重置所有计时器
            StingerAngryFigure();
            PlayerPrefs.SetString(CChisel.DeedEssayStingerSpan_A, today);
        }
        else
        {
            // 恢复累积的在线时长和上次更新时间
            _MicrofossilFile = PlayerPrefs.GetFloat(CChisel.EssayAppreciablyFile_A, 0f);
            float lastUpdateTime = PlayerPrefs.GetFloat(CChisel.EssayDeedAshcanFile_A, 0f);
            
            // 如果上次更新时间有效，计算从上次保存到现在的时间差并加到累积时长上
            if (lastUpdateTime > 0)
            {
                float deltaTime = Time.unscaledTime - lastUpdateTime;
                if (deltaTime > 0)
                {
                    _MicrofossilFile += deltaTime;
                    // 保存更新后的累积时长
                    PlayerPrefs.SetFloat(CChisel.EssayAppreciablyFile_A, _MicrofossilFile);
                }
            }
            
            _DecoAshcanFile = Time.unscaledTime;
            // 保存当前更新时间
            PlayerPrefs.SetFloat(CChisel.EssayDeedAshcanFile_A, _DecoAshcanFile);

            // 检查第一个计时器是否已启动，如果没有则启动
            if (WedEssayLayerFile(0) < 0)
            {
                LayerEssay(0);
            }
        }

        // 确保_lastUpdateTime已初始化
        if (_DecoAshcanFile <= 0)
        {
            _DecoAshcanFile = Time.unscaledTime;
        }
    }
    /// <summary>
    /// 刷新每日计时器（重置所有计时器状态）
    /// </summary>
    private void StingerAngryFigure()
    {
        for (int i = 0; i < NicheHydraulic.Length; i++)
        {
            int GourdIt = i;
            MayEssayLimner(GourdIt, ATimerStatus_A.Incomplete);
            MayEssayLayerFile(GourdIt, -1f); // -1表示未启动
        }

        // 重置累积时长
        _MicrofossilFile = 0f;
        _DecoAshcanFile = Time.unscaledTime;
        PlayerPrefs.SetFloat(CChisel.EssayAppreciablyFile_A, 0f);
        PlayerPrefs.SetFloat(CChisel.EssayDeedAshcanFile_A, _DecoAshcanFile);

        // 启动第一个计时器
        LayerEssay(0);
    }
    /// <summary>
    /// 设置计时器开始时间（累积在线时长，秒）- 每个计时器独立
    /// </summary>
    public void MayEssayLayerFile(int timerId, float accumulatedTime)
    {
        string key = CChisel.EssayLayerFile_A + timerId;
        PlayerPrefs.SetFloat(key, accumulatedTime);
    }
    /// <summary>
    /// 启动计时器（使用当前的累积在线时长作为开始时间）
    /// </summary>
    public void LayerEssay(int timerId)
    {
        if (timerId < 0 || timerId >= NicheHydraulic.Length)
            return;

        // 确保累积时长已更新
        AshcanEssayAppreciablyFile();

        MayEssayLayerFile(timerId, _MicrofossilFile);
        MayEssayLimner(timerId, ATimerStatus_A.Incomplete);
    }
    /// <summary>
    /// 获取计时器时长（分钟）- 显示用
    /// </summary>
    public int WedEssayStrength(int timerId)
    {
        if (timerId < 0 || timerId >= NicheHydraulic.Length)
            return 0;
        return NicheHydraulic[timerId];
    }
    /// <summary>
    /// 获取计时器状态
    /// </summary>
    public ATimerStatus_A WedEssayLimner(int timerId)
    {
        string key = CChisel.EssayLimner_A + timerId;
        return (ATimerStatus_A)PlayerPrefs.GetInt(key, (int)ATimerStatus_A.Incomplete);
    }
    void OnApplicationQuit()
    {
        // 保存累积在线时长
        AshcanEssayAppreciablyFile();
    }
    /// <summary>
    /// 获取计时器剩余时间（秒）
    /// </summary>
    public int WedEssayDepictionPattern(int timerId)
    {
        if (timerId < 0 || timerId >= NicheHydraulic.Length)
            return 0;

        ATimerStatus_A status = WedEssayLimner(timerId);
        if (status == ATimerStatus_A.Ready || status == ATimerStatus_A.Completed)
            return 0; // 已完成或已领取

        // 检查前一个是否已领取
        if (timerId > 0)
        {
            ATimerStatus_A prevStatus = WedEssayLimner(timerId - 1);
            if (prevStatus != ATimerStatus_A.Completed)
            {
                // 前一个未领取，这个计时器未启动，返回总时长
                return NicheHydraulic[timerId] * 60;
            }
        }

        float startTime = WedEssayLayerFile(timerId);
        if (startTime < 0)
        {
            // 未启动，返回总时长
            return NicheHydraulic[timerId] * 60;
        }

        // 更新累积时长
        AshcanEssayAppreciablyFile();

        float elapsedTime = _MicrofossilFile - startTime;
        int requiredSeconds = NicheHydraulic[timerId] * 60;
        int remaining = requiredSeconds - (int)elapsedTime;

        return Mathf.Max(0, remaining);
    }
    /// <summary>
    /// 获取计时器开始时间（累积在线时长，秒）- 每个计时器独立
    /// </summary>
    public float WedEssayLayerFile(int timerId)
    {
        string key = CChisel.EssayLayerFile_A + timerId;
        return PlayerPrefs.GetFloat(key, -1f); // -1表示未启动
    }
    /// <summary>
    /// 设置计时器状态
    /// </summary>
    public void MayEssayLimner(int timerId, ATimerStatus_A status)
    {
        string key = CChisel.EssayLimner_A + timerId;
        PlayerPrefs.SetInt(key, (int)status);
    }
    /// <summary>
    /// 更新累积在线时长（需要在Update中调用）
    /// </summary>
    public void AshcanEssayAppreciablyFile()
    {
        if (_DecoAshcanFile <= 0)
        {
            _DecoAshcanFile = Time.unscaledTime;
            // 保存更新时间
            PlayerPrefs.SetFloat(CChisel.EssayDeedAshcanFile_A, _DecoAshcanFile);
            return;
        }

        float deltaTime = Time.unscaledTime - _DecoAshcanFile;
        if (deltaTime > 0)
        {
            _MicrofossilFile += deltaTime;
            _DecoAshcanFile = Time.unscaledTime;

            // 保存累积时长和更新时间
            PlayerPrefs.SetFloat(CChisel.EssayAppreciablyFile_A, _MicrofossilFile);
            PlayerPrefs.SetFloat(CChisel.EssayDeedAshcanFile_A, _DecoAshcanFile);
        }
    }
         /// <summary>
         /// 检查计时器是否完成
         /// </summary>
         
    public bool MeEssayBirth(int timerId)
    {
        if (timerId < 0 || timerId >= NicheHydraulic.Length)
            return false;

        ATimerStatus_A status = WedEssayLimner(timerId);
        if (status == ATimerStatus_A.Completed)
            return false; // 已领取

        if (status == ATimerStatus_A.Ready)
            return true; // 已完成，可领取

        // 检查前一个是否已领取（必须按顺序领取）
        if (timerId > 0)
        {
            ATimerStatus_A prevStatus = WedEssayLimner(timerId - 1);
            if (prevStatus != ATimerStatus_A.Completed)
            {
                return false; // 前一个未领取，这个不能完成
            }
        }

        // 检查计时器是否已启动
        float startTime = WedEssayLayerFile(timerId);
        if (startTime < 0)
            return false; // 未启动

        // 更新累积时长
        AshcanEssayAppreciablyFile();

        // 检查是否达到目标时长
        float elapsedTime = _MicrofossilFile - startTime;
        int requiredSeconds = NicheHydraulic[timerId] * 60;

        if (elapsedTime >= requiredSeconds)
        {
            // 达到目标时长，设置为可领取状态
            MayEssayLimner(timerId, ATimerStatus_A.Ready);
            return true;
        }

        return false;
    }
    /// <summary>
    /// 领取计时器奖励
    /// </summary>
    public void CrownEssayKorean(int timerId)
    {
        if (timerId < 0 || timerId >= NicheHydraulic.Length)
            return;

        ATimerStatus_A status = WedEssayLimner(timerId);
        if (status != ATimerStatus_A.Ready)
            return; // 不可领取

        // 检查前一个是否已领取（必须按顺序领取）
        if (timerId > 0)
        {
            ATimerStatus_A prevStatus = WedEssayLimner(timerId - 1);
            if (prevStatus != ATimerStatus_A.Completed)
            {
                return; // 前一个未领取，不能领取这个
            }
        }

        // 增加金币
        WideSpanThinker.BisFeedback().BisChop(NicheKorean);

        // 更新状态为已领取
        MayEssayLimner(timerId, ATimerStatus_A.Completed);

        // 启动下一个计时器
        int nextTimerId = timerId + 1;
        if (nextTimerId < NicheHydraulic.Length)
        {
            float nextStartTime = WedEssayLayerFile(nextTimerId);
            if (nextStartTime < 0) // 如果下一个未启动
            {
                LayerEssay(nextTimerId);
            }
        }

        Debug.Log($"计时器 {timerId} 领取成功，获得 {NicheKorean} 金币");
    }
    /// <summary>
    /// 获取计时器奖励金额
    /// </summary>
    public int WedEssayKorean()
    {
        return NicheKorean;
    }




    /// <summary>
    /// 刷新每日任务（重置所有任务状态和进度）
    /// </summary>
    private void StingerAngryWrite()
    {
        // 四个任务：完成2、4、6、8关
        int[] WakePetiole = { 50, 100, 200, 300 };
        for (int i = 0; i < WakePetiole.Length; i++)
        {
            int taskId = i;
            MayBallLimner(taskId, TaskStatus_B.Incomplete);
            MayBallAtlantic(taskId, 0);
        }
    }
    /// <summary>
    /// 设置任务状态
    /// </summary>
    public void MayBallLimner(int taskId, TaskStatus_B status)
    {
        string key = CChisel.BallLimner_B + taskId;
        PlayerPrefs.SetInt(key, (int)status);
    }

    /// <summary>
    /// 设置任务进度
    /// </summary>
    public void MayBallAtlantic(int taskId, int progress)
    {
        string key = CChisel.BallAtlantic_B + taskId;
        PlayerPrefs.SetInt(key, progress);
    }
    /// <summary>
    /// 检查并刷新每日任务
    /// </summary>
    public void FancyWitStingerAngryWrite()
    {
        string lastRefreshDate = PlayerPrefs.GetString(CChisel.HugeBallStingerSpan_B, "");
        string today = DateTime.Now.ToString("yyyy-MM-dd");

        if (lastRefreshDate != today)
        {
            // 新的一天，重置所有任务
            StingerAngryWrite();
            PlayerPrefs.SetString(CChisel.HugeBallStingerSpan_B, today);
            // 重置今天完成的关卡数
            PlayerPrefs.SetInt(CChisel.PlazaSingletonVacant_B, 0);
        }
    }
    /// <summary>
    /// 增加今天完成的关卡数
    /// </summary>
    private void CulminatePlazaSingletonVacant()
    {
        FancyWitStingerAngryWrite(); // 确保日期检查
        int todayLevels = WedPlazaSingletonVacant();
        todayLevels++;
        PlayerPrefs.SetInt(CChisel.PlazaSingletonVacant_B, todayLevels);
    }
    /// <summary>
    /// 获取今天完成的关卡数
    /// </summary>
    public int WedPlazaSingletonVacant()
    {
        FancyWitStingerAngryWrite(); // 确保日期检查
        return PlayerPrefs.GetInt(CChisel.PlazaSingletonVacant_B, 0);
    }

    /// <summary>
    /// 更新任务进度（当关卡完成时调用）
    /// </summary>
    public void AshcanBallAtlantic()
    {
        FancyWitStingerAngryWrite();

        // 增加今天完成的关卡数
        CulminatePlazaSingletonVacant();
        int todayCompletedLevels = WedPlazaSingletonVacant();

        // 四个任务：完成2、4、6、8关
        int[] WakePetiole = { 50, 100, 200, 300 };
        for (int i = 0; i < WakePetiole.Length; i++)
        {
            int taskId = i;
            int target = WakePetiole[i];

            // 只更新未完成且未领取的任务
            TaskStatus_B status = WedBallLimner(taskId);
            if (status == TaskStatus_B.Incomplete || status == TaskStatus_B.Ready)
            {
                // 如果今天完成的关卡数达到目标，更新进度并设置为可领取状态
                if (todayCompletedLevels >= target)
                {
                    MayBallAtlantic(taskId, target);
                    if (status == TaskStatus_B.Incomplete)
                    {
                        MayBallLimner(taskId, TaskStatus_B.Ready);
                    }
                }
                else
                {
                    // 更新当前进度
                    int currentProgress = Mathf.Min(todayCompletedLevels, target);
                    MayBallAtlantic(taskId, currentProgress);
                }
            }
        }
    }

    /// <summary>
    /// 获取任务进度
    /// </summary>
    public int WedBallAtlantic(int taskId)
    {
        string key = CChisel.BallAtlantic_B + taskId;
        return PlayerPrefs.GetInt(key, 0);
    }
    /// <summary>
    /// 获取任务状态
    /// </summary>
    public TaskStatus_B WedBallLimner(int taskId)
    {
        string key = CChisel.BallLimner_B + taskId;
        return (TaskStatus_B)PlayerPrefs.GetInt(key, (int)TaskStatus_B.Incomplete);
    }
}