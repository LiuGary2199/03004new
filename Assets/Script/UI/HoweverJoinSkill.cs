// Project: Plinko
// FileName: HoweverJoinSkill.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:28
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using ScratchCardAsset;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class HoweverJoinSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    // public SkeletonGraphic titleAnim;
[UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]
    public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("targetCard")]
[UnityEngine.Serialization.FormerlySerializedAs("RainerDeed")]    public ScratchCardManager CinemaJoin;
[UnityEngine.Serialization.FormerlySerializedAs("mainCard")]    [UnityEngine.Serialization.FormerlySerializedAs("LineDeed")]public ScratchCardManager TalkJoin;
[UnityEngine.Serialization.FormerlySerializedAs("cardLessProgress")]
[UnityEngine.Serialization.FormerlySerializedAs("LungKnowSquirrel")]    public float AiryCultNearness;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum01")]
[UnityEngine.Serialization.FormerlySerializedAs("RainerBed01")]    public Text CinemaElk01;
[UnityEngine.Serialization.FormerlySerializedAs("targetNum02")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerBed02")]public Text CinemaElk02;
[UnityEngine.Serialization.FormerlySerializedAs("mainCardObjList")]
[UnityEngine.Serialization.FormerlySerializedAs("LineDeedGelGerm")]    public List<HoweverWokCongestion> TalkJoinWokThen;

    private bool CinemaJoinSpew;
    private bool TalkJoinSpew;

    private int BequestAilBayTrove;
    private int RoteAilTrove;

    private List<int> CinemaElkThen;

    private Dictionary<NormalRewardType, double> TurtleOil;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    
[UnityEngine.Serialization.FormerlySerializedAs("SpaceFair")]    public SkeletonGraphic BylawPloy;


    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        SelfSheerRibbon.BisFeedback().CastSheer("1008");

        BylawPloy.AnimationState.SetAnimation(0, "chuxian", false);
        BylawPloy.AnimationState.AddAnimation(0, "daiji", true, 0f);

        CinemaJoinSpew = false;
        TalkJoinSpew = false;

        BiteWideSpan();
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
    protected override void Awake()
    {
        base.Awake();
        BequestAilBayTrove = TanGenuUSA.instance.WideSpan.base_config.scratch_win_max_count;
        //scratchWinMaxCount = 3;
        RoteAilTrove = 0;
    }

    private void Start()
    {
        SlushWhy.onClick.AddListener(() => { HappyHoweverJoinSkill(); });

        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Slush_Aphid_Sap_Alter,
            (messageData) => { HappyHoweverJoinSkill(); });
        
        BiteWideSpan();
    }

    private void Update()
    {
        if (!CinemaJoinSpew && CinemaJoin.Progress.GetProgress() > 0.7f)
        {
            CinemaJoinSpew = true;
            CinemaJoin.FillScratchCard();
            if (TalkJoinSpew)
            {
                FirnHoweverServe();
            }
        }

        if (!TalkJoinSpew && TalkJoin.Progress.GetProgress() > AiryCultNearness)
        {
            TalkJoinSpew = true;
            TalkJoin.FillScratchCard();
            if (CinemaJoinSpew)
            {
                FirnHoweverServe();
            }
        }
    }


    private void FirnRatifyServeSkill()
    {
        if (TurtleOil.Count > 0)
        {
            AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_News, "1009");
 
            AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_No_No,"3");
            FecundSkillThinker.Instance.FirnPatentFecundSkill(TurtleOil);
            // PatentAilServeSkill.Instance.InitData(rewardMap, GetType().Name);
        }
        else
        {
            HappyHoweverJoinSkill();
        }
    }

    private void FirnHoweverServe()
    {
        List<HoweverWokCongestion> DonThen= new List<HoweverWokCongestion>();


        foreach (HoweverWokCongestion obj in TalkJoinWokThen)
        {
            if (CinemaElkThen.Contains(obj.TalkElk))
            {
                string type = obj.BequestWokSpan.ScratchObjType.ToString();
                NormalRewardType TurtleCity= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
                if (TurtleOil.ContainsKey(TurtleCity))
                {
                    TurtleOil[TurtleCity] =
                        TurtleOil[TurtleCity] + obj.BequestWokSpan.RewardNum;
                }
                else
                {
                    TurtleOil.Add(TurtleCity, obj.BequestWokSpan.RewardNum);
                }

                DonThen.Add(obj);
            }
        }

        float timeTemp = 0f;

        for (int i = 0; i < DonThen.Count; i++)
        {
            HoweverWokCongestion obj = DonThen[i];
            obj.transform.DOScale(1, 0f).SetDelay(timeTemp).OnComplete(() => { obj.FirnFilter(); });

            timeTemp += 0.15f;
        }

        Invoke(nameof(FirnRatifyServeSkill), 0.6f + timeTemp);
    }


    private int BisMomentWokElk()
    {
        return Random.Range(1, 71);
    }

    private void BiteWideSpan()
    {
        TurtleOil = new Dictionary<NormalRewardType, double>();
        CinemaElkThen = BisFilterThen();
        RoteAilTrove = Random.Range(2, BequestAilBayTrove);

        CinemaJoin.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
        TalkJoin.MainCamera = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();;
 
        List<int> mainNumList = new List<int>();
        for (int i = 0; i < RoteAilTrove; i++)
        {
            int Aphid= Random.Range(0, 2);
            int num = CinemaElkThen[Aphid];
            mainNumList.Add(num);
        }

        while (mainNumList.Count < 9)
        {
            int num = BisMomentWokElk();
            if (!mainNumList.Contains(num))
            {
                mainNumList.Add(num);
            }
        }

        mainNumList = MomentLift.MomentSear(mainNumList);

        for (int i = 0; i < mainNumList.Count; i++)
        {
            TalkJoinWokThen[i].BiteSpan(mainNumList[i], CinemaElkThen.Contains(mainNumList[i]));
        }
    }

    private List<int> BisFilterThen()
    {
        List<int> targetList = new List<int>();
        int num1 = BisMomentWokElk();
        targetList.Add(num1);
        int num2 = BisMomentWokElk();
        while (num1 == num2)
        {
            num2 = BisMomentWokElk();
        }

        targetList.Add(num2);
        CinemaElk01.text = num1.ToString();
        CinemaElk02.text = num2.ToString();

        return targetList;
    }

    private void HappyHoweverJoinSkill()
    {
        if (!gameObject.activeInHierarchy) return;
        CinemaJoin.ClearScratchCard();
        TalkJoin.ClearScratchCard();
        Invoke(nameof(HappySkill), 0.2f);
    }

    private void HappySkill()
    {
        // AkinSpanThinker.SetInt(CChisel.sv_ad_trial_num, AkinSpanThinker.GetInt(CChisel.sv_ad_trial_num) + 1);
        VerbThinker.Instance.WidePassage();
        HappyUIMust(GetType().Name);

        // PillarManager.Instance.StartLittleGameTimeBar();
        // ShaperThinker.Instance.ReStartGame();
        // PlugThinker.Instance.inLittleGame = false;
    }
}