using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using LitJson;
using Lofelt.NiceVibrations;
public class BurdenImagist : MonoBehaviour
{
    static public BurdenImagist Instance;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool")]
    public GameObject At_Cast;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Pool_1")]    public GameObject At_Cast_1;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Pool")]    public GameObject Glow_Cast;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfab")]    public GameObject rewardTellOpaque;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemGroup")]    public Transform RussiaTellBoard;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool")]    public GameThinker AtCast;
[UnityEngine.Serialization.FormerlySerializedAs("fxPool_1")]    public GameThinker AtCast_1;
[UnityEngine.Serialization.FormerlySerializedAs("TextPool")]    public GameThinker GlowCast;
    private int VanBustlePet;
[UnityEngine.Serialization.FormerlySerializedAs("currentBucketNum")]    public int PostwarBustlePet;
[UnityEngine.Serialization.FormerlySerializedAs("ColumnGroup")]    public GameObject CenterBoard;
[UnityEngine.Serialization.FormerlySerializedAs("centerDoor")]    public GameObject IgniteDeny;
[UnityEngine.Serialization.FormerlySerializedAs("coinPagodaPerfab")]    public GameObject RailThriveOpaque;
[UnityEngine.Serialization.FormerlySerializedAs("fX_Fever")]    public GameObject fX_Adorn;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BigWin")]    public GameObject fX_GasLog;
[UnityEngine.Serialization.FormerlySerializedAs("fX_BoxGroup")]    public GameObject fX_RubBoard;
[UnityEngine.Serialization.FormerlySerializedAs("haveLittleGame")]    public bool LimeEnergyDawn= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPause")]    public bool GoVivid= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushFever")]    /// <summary>
    /// 是否进入fever
    /// </summary>
    public bool GoBusyAdorn= false;
[UnityEngine.Serialization.FormerlySerializedAs("isPushBigWin")]    /// <summary>
    /// 是否正在777
    /// </summary>
    public bool GoBusyGasLog= false;
    int JewelryLoreCoinNurse;
[UnityEngine.Serialization.FormerlySerializedAs("FeatIDHappyWok")]
    public FeatIDHappyWok FeatIDHappyWok;

    private void OnApplicationPause(bool focus)
    {
        if (focus)
        {
            Debug.Log("进入后台");
            ForeGemRegimeTell();
        }
        else
        {
            Debug.Log("进入前台");
        }
    }


    private void Awake()
    {
        Instance = this;
        
    }

    private void Start()
    {
        FeatIDHappyWok.TasteWokBound();
        VanBustlePet = 26;
        PostwarBustlePet = AkinSpanThinker.BisFew(CChisel.Ox_Tenth_Bind_Pollute);
        RussiaTellBoard.gameObject.AddComponent<GameThinker>().BiteGameThinker(rewardTellOpaque,RussiaTellBoard,300,"RewardItem");
        AtCast.BiteGameThinker(At_Cast, AtCast.transform, 50, "fxPool");
        AtCast_1.BiteGameThinker(At_Cast_1, AtCast_1.transform, 20, "fxPool_1");
        GlowCast.BiteGameThinker(Glow_Cast, GlowCast.transform, 50, "TextPool");
        ParkGemRegimeTell();
        KrillBurden();
        if (BurrowLift.ItChair())
        {
            PlugThinker.Instance.HappyPlugBG();
        }
    }


    /// <summary>
    /// 推币机启动
    /// </summary>
    public void KrillBurden()
    {
        UpwardExemplifyThinker.Instance.TourReuseGaze();
        if (BurrowLift.ItChair())//新报更改该 审核期间去掉slot显示
        {
            UpwardExemplifyThinker.Instance.HappyPlugKey();
        }
        else
        {
            UpwardExemplifyThinker.Instance.RagReuseGaze();
        }
        WareLoreAdRegime();
    }


    /// <summary>
    /// 推币机暂停
    /// </summary>
    public void IssueBurden()
    {
        if(!GoVivid)
        {
            GoVivid = true;
            //推板移动
            UpwardExemplifyThinker.Instance.TourOfferGaze();
            //小球停止运动
            ShaperThinker.Instance.TheftRidRice();
            //rewarditem停止运动
            IssueRegimeTell();
            //slot暂停
            PlugThinker.Instance.PlugRime();
            //暂停自动掉落物品
            IssueDikeLoreGoRegime();
            //fever暂停
            if (GoBusyAdorn)
            {
                if (BurrowLift.ItChair())
                {
                    RatCruelTiltThinker.Instance.RimeCruel();
                }
                else
                {
                    CruelTiltThinker.Instance.RimeCruel();
                }
                StopCoroutine(nameof(AlterHueDukeGrid));
            }
            if (GoBusyGasLog && LieLogHueGrid > 0)
            {
                StopCoroutine(nameof(LieLogHueDukeGrid));
            }
            if (JewelryLoreCoinNurse > 0)
            {
                StopCoroutine(nameof(VeinJoltHandIfDukeGrid));
            }
        }
    }
    /// <summary>
    /// 推币机恢复
    /// </summary>
    public void ChurchBurden()
    {
        if (GoVivid)
        {
            GoVivid = false;
            //推板恢复
            UpwardExemplifyThinker.Instance.TourEncaseGaze();
            //小球恢复
            ShaperThinker.Instance.QuiverRidRice();
            //rewarditem恢复
            ChurchRegimeTell();
            //slot恢复
            PlugThinker.Instance.PlugMyReuse();
            //恢复自动掉落物品
            ChurchDikeLoreGoRegime();
            //fever恢复
            if (GoBusyAdorn)
            {
                if (BurrowLift.ItChair())
                {
                    RatCruelTiltThinker.Instance.MyReuseCruelTilt();
                }
                else
                {
                    CruelTiltThinker.Instance.MyReuseCruelTilt();
                }
                StartCoroutine(nameof(AlterHueDukeGrid));
            }
            if (GoBusyGasLog && LieLogHueGrid > 0)
            {
                StartCoroutine(nameof(LieLogHueDukeGrid));
            }
            if (JewelryLoreCoinNurse > 0)
            {
                StartCoroutine(nameof(VeinJoltHandIfDukeGrid));
            }
        }
    }
    /// <summary>
    /// 暂停奖励物体
    /// </summary>
    void IssueRegimeTell()
    {
        if (RussiaTellBoard.GetComponent<GameThinker>() != null)
        {
            List<GameObject> list = RussiaTellBoard.GetComponent<GameThinker>().Spin;
            foreach (GameObject rewardItem in list)
            {
                rewardItem.GetComponent<PersevereOffer>().TheftPersevere();
            }
        }
    }
    /// <summary>
    /// 恢复奖励物体
    /// </summary>
    void ChurchRegimeTell()
    {
        List<GameObject> list = RussiaTellBoard.GetComponent<GameThinker>().Spin;
        foreach (GameObject rewardItem in list)
        {
            rewardItem.GetComponent<PersevereOffer>().QuiverPersevere();
        }
    }


    /// <summary>
    /// pusher奖励掉落台下
    /// </summary>
    public void BigLoreRegime(PusherRewardType type, double RussiaPet)
    {
        if (GoBusyAdorn)
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_getReward,0.1f);
        }
        else
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_getReward,0.1f);
        }
        PenBustlePet();
        SpanLayoutThinker.BisFeedback().WokUpwardFecund(type,RussiaPet);
        if (type == PusherRewardType.RollCash || type == PusherRewardType.ScratchCard || type == PusherRewardType.LuckyCard)
        {
            LimeEnergyDawn = false;
        }
    }


    /// <summary>
    /// 触发slot
    /// </summary>
    public void KrillFrog()
    {
        if (GoVivid)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
        SpanLayoutThinker.BisFeedback().RoePlugFecundSpan((slotRewardType)=> {
            PlugThinker.Instance.LionPlug(slotRewardType, () =>
            {
                Debug.Log("finish");
                if (slotRewardType != SlotRewardType.Null)
                {
                    GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slot_reward);
                    HapticPatterns.PlayPreset(HapticPatterns.PresetType.Success);
                }

                switch (slotRewardType)
                {
                    case SlotRewardType.BigWin:
                      //  SOHOShopManager.instance.AddTaskValue("777", 1);
                        GasLog();
                        break;
                    case SlotRewardType.Cash1:
                        VeinJoltDireHandIf(25);
                        break;
                    case SlotRewardType.Cash2:
                        VeinJoltDireHandIf(50);
                        break;
                    case SlotRewardType.Cash3:
                        VeinJoltDireHandIf(100);
                        break;
                    case SlotRewardType.SkillWall:
                        LeoWallIf();
                        break;
                    case SlotRewardType.SkillBigCoin:
                        LieAcidLore();
                        break;
                    case SlotRewardType.SkillLong:
                        KilnPenWeek();
                        break;
                    case SlotRewardType.GemBlue:
                        VeinHandIf(PusherRewardType.GemBlue);
                        break;
                    case SlotRewardType.GemRed:
                        VeinHandIf(PusherRewardType.GemRed);
                        break;
                    case SlotRewardType.GemDiamond:
                        VeinHandIf(PusherRewardType.GemDiamond);
                        break;
                    case SlotRewardType.Golden:
                        VeinHandIf(PusherRewardType.Golden);
                        break;
                    case SlotRewardType.Null:
                        break;
                }
            });
        });
    }


    /// <summary>
    /// 自动掉落间隔时间
    /// </summary>
    float AnRegimeCDTime= 0;
    /// <summary>
    /// 自动掉落广告奖励(现金卷/刮刮卡/翻牌)
    /// </summary>
    public void WareLoreAdRegime()
    {
        AnRegimeCDTime = TanGenuUSA.instance.WideSpan.base_config.little_game_time;
        StartCoroutine(nameof(WareLoreGoRegimeDukeGrid));
    }
    /// <summary>
    /// 暂停自动掉落等时
    /// </summary>
    public void IssueDikeLoreGoRegime()
    {
        StopCoroutine(nameof(WareLoreGoRegimeDukeGrid));
    }
    /// <summary>
    /// 恢复自动掉落等时
    /// </summary>
    public void ChurchDikeLoreGoRegime()
    {
        StartCoroutine(nameof(WareLoreGoRegimeDukeGrid));
    }
    /// <summary>
    /// 自动掉落等时
    /// </summary>
    /// <returns></returns>
    IEnumerator WareLoreGoRegimeDukeGrid()
    {
        while(AnRegimeCDTime > 0 || LimeEnergyDawn || AkinSpanThinker.BisAttest(CChisel.Son_Yale_Line_us) == "new")
        {
            yield return new WaitForSeconds(1);
            AnRegimeCDTime--;
        }
        if (!BurrowLift.ItChair())
        {
            PusherRewardType type = SpanLayoutThinker.BisFeedback().RoeSendDireAtCity();
            VeinHandIf(type);
            LimeEnergyDawn = true;
        }
        WareLoreAdRegime();
    }


    /// <summary>
    /// 技能-大金币-投掷
    /// </summary>
    public void LieAcidLore()
    {
        VeinHandIf(PusherRewardType.BigCoin, () => {
            
            LieAcidSixth();
        });
    }
    /// <summary>
    /// 技能-大金币-震动
    /// </summary>
    public void LieAcidSixth()
    {
        Debug.Log("大金币-震动");
        Vector3 startPos = Camera.main.transform.position;
        GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_column_bomb);
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.HeavyImpact);
        Camera.main.DOShakePosition(0.5f, 0.28f, 30, 2, true).SetEase(Ease.Linear).OnComplete(() =>
        {
            Camera.main.transform.localPosition = startPos;
        });
        for (int i = 0; i < RussiaTellBoard.childCount; i++)
        {
            Transform rewardItem = RussiaTellBoard.GetChild(i);
            if(rewardItem.GetComponent<Rigidbody>())
            {
                rewardItem.GetComponent<Rigidbody>().AddForce(new Vector3(0, 150, -80));
            }
        }
    }


    /// <summary>
    /// 技能-推板加长
    /// </summary>
    public void KilnPenWeek()
    {
        //单次推板加长时间
        float time = 10;
        UpwardExemplifyThinker.Instance.TourBisEase(time);
    }


    /// <summary>
    /// 技能-墙
    /// </summary>
    public void LeoWallIf()
    {
        //单次升墙时间
        float time = 10;
        UpwardExemplifyThinker.Instance.AgeAcidOn(time);
    }


   
    /// <summary>
    /// 并排掉落多个
    /// </summary>
    /// <param name="count"></param>
    /// <param name="delay"></param>
    void VeinJoltDireHandIf(int count)
    {
        JewelryLoreCoinNurse += count;
        if (JewelryLoreCoinNurse == count)
        {
            StartCoroutine(nameof(VeinJoltHandIfDukeGrid));
        }
    }

    
    /// <summary>
    /// 并排掉落延迟
    /// </summary>
    /// <param name="type"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    IEnumerator VeinJoltHandIfDukeGrid()
    {
        SpanLayoutThinker.BisFeedback().YaleDireBillGillTrove(true, JewelryLoreCoinNurse);
        while (JewelryLoreCoinNurse > 0)
        {
            SpanLayoutThinker.BisFeedback().YaleDireBillGillTrove(false,JewelryLoreCoinNurse);
            JewelryLoreCoinNurse--;
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_creat_coin, 0.1f);
            VeinHandIf(PusherRewardType.CoinCash, null, (int)Mathf.PingPong(JewelryLoreCoinNurse, 4) + 1);
            yield return new WaitForSeconds(0.1f);
        }
    }


    /// <summary>
    /// 从上空掉落物体
    /// </summary>
    /// <param name="dropObj"></param>
    void VeinHandIf(PusherRewardType type, Action block = null, int index = 0)
    {
        GameObject rewardItemObj = BigRegimeTell(type);
        switch (type)
        {
            case PusherRewardType.CoinGold:
                rewardItemObj.transform.eulerAngles = BigPolicyModemDerive();
                break;
            case PusherRewardType.CoinCash:
                rewardItemObj.transform.eulerAngles = BigPolicyModemDerive();
                break;
            default:
                
                break;
            
        }
        if (rewardItemObj != null)
        {
            
            if (index == 0)
            {
                rewardItemObj.transform.position = new Vector3(UnityEngine.Random.Range(-1.5f,1.5f), 7, -1.6f);
            }
            else
            {
                float[] targetXArray = new float[] {-1.6f,-0.8f,0,0.8f,1.6f };
                rewardItemObj.transform.position = new Vector3(targetXArray[index - 1], 7, -1.6f);
            }
        }
        if (block != null)
        {
            rewardItemObj.AddComponent<AstonishMetal>().AgeMetalBreath(block);
        }
    }


    /// <summary>
    /// 根据类型获得对应奖励物体
    /// </summary>
    /// <returns></returns>
    public GameObject BigRegimeTell(PusherRewardType type)
    {
        GameObject rewardItem = RussiaTellBoard.GetComponent<GameThinker>().BisPiston();
        rewardItem.GetComponent<BurdenRegimeTell>().MealRegimeTell(type);
        rewardItem.GetComponent<Rigidbody>().velocity = Vector3.zero;
        rewardItem.transform.eulerAngles = Vector3.zero;
        rewardItem.SetActive(true);
        return rewardItem;
    }

    bool GoThriveBeside= false;
    /// <summary>
    /// 777
    /// </summary>
    void GasLog()
    {
        SelfSheerRibbon.BisFeedback().CastSheer("1005");
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slot_777);
        GoBusyGasLog = true;
        fX_GasLog.SetActive(true);
        UpwardExemplifyThinker.Instance.TourRidGaze(()=> {
            IgniteDeny.GetComponent<Rigidbody>().DOMoveY(-3, 0.5f).OnComplete(() => {
                GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_enter_allbox);
                GameObject pagodaGroup = WorryAcidThrive(20);
                IgniteDeny.transform.DOMoveY(0.664f, 0.5f);
                ShaperThinker.Instance.ChiefJeanGill(10);
                GoThriveBeside = false;
                pagodaGroup.transform.DOMoveY(0.74f,2f).OnComplete(()=> {
                    RailThriveActive(pagodaGroup);
                });
            });
        });
        
    }
    /// <summary>
    /// 创建币塔
    /// </summary>
    /// <param name="heightCount">币塔层数</param>
    GameObject WorryAcidThrive(int heightCount, bool isLoad = false)
    {
        bool isUnlock = false;
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> eulerList = new List<Vector3>();
        for (int i = 0; i < RailThriveOpaque.transform.childCount; i++)
        {
            Transform targetTrans = RailThriveOpaque.transform.GetChild(i);
            pointList.Add(targetTrans.localPosition);
            eulerList.Add(targetTrans.eulerAngles);
        }
        GameObject pagodaGroup = new GameObject();
        pagodaGroup.AddComponent<SunsetSphere>().Brown = () =>
        {
            if (!isUnlock)
            {
                isUnlock = true;
                pagodaGroup.GetComponent<SunsetSphere>().enabled = false;
                //Destroy(pagodaGroup.GetComponent<Rigidbody>());
                //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
                //{
                //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
                //    cashCoin.AddComponent<Rigidbody>();
                //    cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
                //    cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
                //}
            }
        };
        pagodaGroup.transform.position = new Vector3(0, IgniteDeny.transform.position.y + 0.076f, -3.671f);
        pagodaGroup.transform.SetParent(BurdenImagist.Instance.RussiaTellBoard);
        for (int i = 0; i < heightCount; i++)
        {
            GameObject tempObject = new GameObject();
            for (int j = 0; j < 7; j++)
            {
                GameObject cashCoin = BurdenImagist.Instance.BigRegimeTell(PusherRewardType.CoinCash);
                cashCoin.transform.SetParent(tempObject.transform);
                cashCoin.transform.localPosition = pointList[j];
                cashCoin.transform.eulerAngles = eulerList[j];
                cashCoin.layer = 0;
                if (!isLoad)
                {
                    Destroy(cashCoin.GetComponent<Rigidbody>());
                }
            }
            tempObject.transform.position = pagodaGroup.transform.position + new Vector3(0, 0.1074f * i, 0);
            tempObject.transform.eulerAngles = new Vector3(0, i * 3, 0);
            for (int k = tempObject.transform.childCount - 1; k >= 0; k--)
            {
                tempObject.transform.GetChild(k).SetParent(pagodaGroup.transform);
            }
            Destroy(tempObject);
        }
        return pagodaGroup;
    }
    
    /// <summary>
    /// 币塔解封
    /// </summary>
    /// <param name="pagodaGroup"></param>
    void RailThriveActive(GameObject pagodaGroup)
    {

        //for (int i = 0; i < pagodaGroup.transform.childCount; i++)
        //{
        //    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
        //    cashCoin.layer = 6;
        //}
        //pagodaGroup.layer = 6;
        //pagodaGroup.AddComponent<Rigidbody>().mass = 30;
        //isUnlock = true;
        //Destroy(pagodaGroup.GetComponent<Rigidbody>());
        GoThriveBeside = true;
        for (int i = pagodaGroup.transform.childCount - 1; i >= 0; i--)
        {
            Debug.Log(i);
            GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
            cashCoin.AddComponent<Rigidbody>();
            cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
            cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
            cashCoin.transform.SetParent(RussiaTellBoard);
            if (GoVivid)
            {
                cashCoin.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        fX_GasLog.SetActive(false);
        LieLogHueGrid = 5f;
        StartCoroutine(nameof(LieLogHueDukeGrid));
    }
    float LieLogHueGrid= 0;
    /// <summary>
    /// 777结算
    /// </summary>
    IEnumerator LieLogHueDukeGrid()
    {
        while(LieLogHueGrid > 0)
        {
            yield return new WaitForSeconds(1);
            LieLogHueGrid--;
        }
        GoBusyGasLog = false;
        SpanLayoutThinker.BisFeedback().TanAilHue();
        if (!GoBusyAdorn)
        {
            //奖励弹窗
            FecundSkillThinker.Instance.FirnMayFecundSkill(GameUtil.GetBigWinCash());
        }
    }


    /// <summary>
    /// 开始fever
    /// </summary>
    public void AlterAlien()
    {
        GooseUSA.BisFeedback().LionOx(GooseCity.UIMusic.sound_fever_bgm);
        BurdenImagist.Instance.GoBusyAdorn = true;
        UpwardExemplifyThinker.Instance.TourReuseGaze(true);
        ShaperThinker.Instance.TenthReuseKeyTrolley(10);
        ShaperThinker.Instance.TenthReuseGameDireRice();
        fX_Adorn.SetActive(true);
        foreach (GameObject fx_Box in fX_RubBoard.GetComponent<KeyPhase>().Cohesive)
        {
            fx_Box.GetComponent<Missouri>().FX_Urban.SetActive(true);
        }
        feverGrid = TanGenuUSA.instance.WideSpan.base_config.fever_time;
        StartCoroutine(nameof(AlterHueDukeGrid));
    }
    /// <summary>
    /// fever剩余时间
    /// </summary>
    float feverGrid= 0;
    /// <summary>
    /// 结束fever等时
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    IEnumerator AlterHueDukeGrid()
    {
        while (feverGrid > 0)
        {
            yield return new WaitForSeconds(1);
            feverGrid--;
        }
        fX_Adorn.SetActive(false);
        foreach (GameObject fx_Box in fX_RubBoard.GetComponent<KeyPhase>().Cohesive)
        {
            fx_Box.GetComponent<Missouri>().FX_Urban.SetActive(false);
        }
        GoBusyAdorn = false;
        UpwardExemplifyThinker.Instance.TourReuseGaze(true);
        ShaperThinker.Instance.TenthFewKeyTrolley();
        ShaperThinker.Instance.TenthFewGameDireRice();
        AlterHue();
    }
    /// <summary>
    /// fever结算
    /// </summary>
    void AlterHue()
    {
        SpanLayoutThinker.BisFeedback().TenthFew();
        GooseUSA.BisFeedback().LionOx(GooseCity.UIMusic.sound_bgm);
        if (!GoBusyGasLog)
        {
            //结算弹窗
            FecundSkillThinker.Instance.FirnMayFecundSkill(GameUtil.GetBigWinCash());
        }
    }


    public void WishAdorn() 
    {
        foreach (SpriteRenderer sr in CenterBoard.GetComponent<MeteorThinker>().MarrowThen) 
        {
            sr.sprite = Resources.Load<Sprite>(CChisel.End_8);
        }
        
    }

    /// <summary>
    /// fever累计次数
    /// </summary>
    public void PenBustlePet()
    {
        if (!GoBusyAdorn)
        {
            // 增加fever 数值
            if (BurrowLift.ItChair())
            {
                RatCruelTiltThinker.Instance.BisCruelRice();
            }
            else
            {
                CruelTiltThinker.Instance.BisCruelRice();
            }
            PostwarBustlePet++;
            if (PostwarBustlePet >= TanGenuUSA.instance.WideSpan.base_config.fever_limit)
            {
                PostwarBustlePet = 0;
                AlterAlien();
            }
        }
        
    }


    

    Vector3 BigPolicyModemDerive()
    {
        Vector3 v3 = new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360));
        return v3;
    }



    /// <summary>
    /// 保存全部物体
    /// </summary>
    public void ForeGemRegimeTell()
    {
        List<RewardItemSaveData> saveList = new List<RewardItemSaveData>();
        if (GoBusyGasLog && !GoThriveBeside)
        {
            foreach (GameObject item in RussiaTellBoard.GetComponent<GameThinker>().Spin)
            {
                if (item.activeSelf && item.transform.parent == RussiaTellBoard && item.GetComponent<BurdenRegimeTell>().RussiaWick != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<BurdenRegimeTell>().RussiaWick;
                    saveData.num = item.GetComponent<BurdenRegimeTell>().RussiaPet;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.It = item.transform.eulerAngles.x;
                    saveData.Dy = item.transform.eulerAngles.y;
                    saveData.He = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            AkinSpanThinker.GapLuck("save_data_inbigwin", true);
        }
        else
        {
            foreach (GameObject item in RussiaTellBoard.GetComponent<GameThinker>().Spin)
            {
                if (item.activeSelf && item.GetComponent<BurdenRegimeTell>().RussiaWick != PusherRewardType.BigCoin)
                {
                    RewardItemSaveData saveData = new RewardItemSaveData();
                    saveData.type = item.GetComponent<BurdenRegimeTell>().RussiaWick;
                    saveData.num = item.GetComponent<BurdenRegimeTell>().RussiaPet;
                    saveData.x = item.transform.position.x;
                    saveData.y = item.transform.position.y;
                    saveData.z = item.transform.position.z;
                    saveData.It = item.transform.eulerAngles.x;
                    saveData.Dy = item.transform.eulerAngles.y;
                    saveData.He = item.transform.eulerAngles.z;
                    saveList.Add(saveData);
                }
            }
            AkinSpanThinker.GapLuck("save_data_inbigwin", false);
        }
        //SaveData savedata = new SaveData();
        //savedata.saveList = saveList;
        string saveJson = JsonMapper.ToJson(saveList);
        AkinSpanThinker.GapAttest("save_data",saveJson);
    }

    /// <summary>
    /// 读取全部物体
    /// </summary>
    public void ParkGemRegimeTell()
    {
        string saveJson = AkinSpanThinker.BisAttest("save_data");
        if (saveJson != null && saveJson.Length > 0)
        {
            foreach (GameObject rewardItem in RussiaTellBoard.GetComponent<GameThinker>().Spin)
            {
                rewardItem.SetActive(false);
            }
            List<RewardItemSaveData> saveList = JsonMapper.ToObject<List<RewardItemSaveData>>(saveJson);
            if (AkinSpanThinker.BisLuck("save_data_inbigwin"))
            {
                WorryAcidThrive(20,true);
            }
            foreach (RewardItemSaveData data in saveList)
            {
                if (data.type == PusherRewardType.ScratchCard || data.type == PusherRewardType.LuckyCard || data.type == PusherRewardType.RollCash)
                {
                    LimeEnergyDawn = true;
                }
                GameObject rewardItem = RussiaTellBoard.GetComponent<GameThinker>().BisPiston();
                rewardItem.transform.position = new Vector3((float)data.x, (float)data.y, (float)data.z);
                rewardItem.transform.eulerAngles = new Vector3((float)data.It, (float)data.Dy, (float)data.He);
                rewardItem.GetComponent<BurdenRegimeTell>().MealRegimeTell(data.type,false);
            }
        } else
        {
            if (BurrowLift.ItChair())
            {
                foreach (GameObject coin in RussiaTellBoard.GetComponent<GameThinker>().Spin)
                {
                    if (coin.activeSelf)
                    {
                        coin.GetComponent<BurdenRegimeTell>().MealRegimeTell(PusherRewardType.CoinGold,false);
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GasLog();
        // RewardPanelManager.Instance.ShowBigRewardPanel(10);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LieAcidLore();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            VeinJoltDireHandIf(25);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            UpwardPlugKeyAstonish.Instance.LionDuePlug();

        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            VeinHandIf(PusherRewardType.GemRed);
            VeinHandIf(PusherRewardType.GemBlue);
            VeinHandIf(PusherRewardType.GemDiamond);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!GoVivid)
            {
                IssueBurden();
            }
            else
            {
                ChurchBurden();
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            AlterAlien();
        }
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    SOHOShopManager.instance.AddTaskValue("777", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    SOHOShopManager.instance.AddTaskValue("golden", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    SOHOShopManager.instance.AddTaskValue("AD", 1);
        //}
    }


    

}
//public class SaveData
//{
//    public List<RewardItemSaveData> saveList;
//}
public class RewardItemSaveData
{
    public PusherRewardType type;
    public double num;
    public double x;
    public double y;
    public double z;
    public double It;
    public double Dy;
    public double He;
}