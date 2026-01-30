// Project: Pusher
// FileName: CrownJoinSkill.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:55
// Description:

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;
using Spine.Unity;

public class CrownJoinSkill : FirmUICharm
{
    public static CrownJoinSkill Instance;
[UnityEngine.Serialization.FormerlySerializedAs("luckyCardList")]
[UnityEngine.Serialization.FormerlySerializedAs("CoralDeedGerm")]    public List<GameObject> ClothJoinThen;
[UnityEngine.Serialization.FormerlySerializedAs("selectObjList")]    [UnityEngine.Serialization.FormerlySerializedAs("ImpendGelGerm")]public List<GameObject> ImpendWokThen;
[UnityEngine.Serialization.FormerlySerializedAs("rewardMap")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraHay")]    public Dictionary<NormalRewardType, double> TurtleOil;
[UnityEngine.Serialization.FormerlySerializedAs("luckyObjDataList")]
[UnityEngine.Serialization.FormerlySerializedAs("CoralGelHallGerm")]    public List<LuckyObjData> ClothWokSpanThen;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]
[UnityEngine.Serialization.FormerlySerializedAs("WeOnly")]    public bool ToBore;
    private bool ToLoam;
[UnityEngine.Serialization.FormerlySerializedAs("onThanksWeight")]
[UnityEngine.Serialization.FormerlySerializedAs("onLaunchFrench")]    public int MyMutualHarden;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
[UnityEngine.Serialization.FormerlySerializedAs("SpaceFair")]    public SkeletonGraphic BylawPloy;

    private int RoteTrove;
    private int TapBayTrove;

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        TapBayTrove = TanGenuUSA.instance.WideSpan.base_config.lucky_card_win_max_count;
    }

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        BiteCrownJoin();
        BylawPloy.AnimationState.SetAnimation(0, "chuxian", false);
        BylawPloy.AnimationState.AddAnimation(0, "daiji", true, 0f);
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_littlegame_show);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }

    private void Start()
    {
        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Slush_Aphid_Sap_Alter,
            (messageData) => { HappyCrownJoinSkill(); });
    }

    private void HappyCrownJoinSkill()
    {
        if (!gameObject.activeInHierarchy) return;
        HappyUIMust(GetType().Name);
    }

    public void BiteCrownJoin()
    {
        RoteTrove = Random.Range(2, TapBayTrove) + 1;
        ClothWokSpanThen = new List<LuckyObjData>();

        ToBore = true;
        ToLoam = false;
        for (int i = 0; i < ClothJoinThen.Count; i++)
        {
            GameObject obj = ClothJoinThen[i].gameObject;
            if (i == 4)
            {
                obj.GetComponent<CrownJoinCongestion>().BiteMutualWokSpan();
            }
            else
            {
                LuckyObjData objData = GameUtil.GetLuckyCardObjData();
                ClothWokSpanThen.Add(objData);
                obj.GetComponent<CrownJoinCongestion>().BiteFecundWokSpan(objData);
            }

            obj.GetComponent<CrownJoinCongestion>().We_Feat.SetActive(false);
        }

        ImpendWokThen = new List<GameObject>();
        TurtleOil = new Dictionary<NormalRewardType, double>();

        Invoke(nameof(GoEnd), 3f);
    }


    private void GoEnd()
    {
        float StaveTilt= 0.5f;

        for (int i = 0; i < ClothJoinThen.Count; i++)
        {
            GameObject obj = ClothJoinThen[i].gameObject;
            Vector3 objPos = obj.transform.localPosition;

            //obj.GetComponent<CrownJoinCongestion>().CloseObj(); 
            obj.GetComponent<CrownJoinCongestion>().LoopExemplify(obj, obj.GetComponent<CrownJoinCongestion>().BG,
                obj.GetComponent<CrownJoinCongestion>().OnFog, () => { },
                () =>
                {
                    obj.transform.DOLocalMove(new Vector3(0, 0, 0), 0.5f).OnComplete(() =>
                    {
                        obj.transform.DOLocalMove(objPos, 0.5f).SetDelay(StaveTilt);
                    });
                });
            StaveTilt = +0.1f;
        }

        Invoke(nameof(FeatBore), 2f);
    }

    private void FeatBore()
    {
        ToBore = false;
    }

    private void BisFecundOil(LuckyObjData rewardObj)
    {
        string type = rewardObj.LuckyObjType.ToString();
        NormalRewardType TurtleCity= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        if (TurtleOil.ContainsKey(TurtleCity))
        {
            TurtleOil[TurtleCity] =
                TurtleOil[TurtleCity] + rewardObj.RewardNum;
        }
        else
        {
            TurtleOil.Add(TurtleCity, rewardObj.RewardNum);
        }
    }

    private void FirnServeSkill()
    {
        for (int i = 0; i < ClothJoinThen.Count; i++)
        {
            GameObject obj = ClothJoinThen[i].gameObject;
            obj.GetComponent<CrownJoinCongestion>().We_Feat.SetActive(false);
        }
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_News, "1011");
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_No_No,"4");
        FecundSkillThinker.Instance.FirnPatentFecundSkill(TurtleOil);
    }

    public void BisTimberThen(GameObject obj)
    {
        ImpendWokThen.Add(obj);

        if (ImpendWokThen.Count < RoteTrove && !ToLoam)
        {
            int num = Random.Range(0, ClothWokSpanThen.Count);
            LuckyObjData objData = ClothWokSpanThen[num];
            obj.GetComponent<CrownJoinCongestion>().LoopExemplify(obj, obj.GetComponent<CrownJoinCongestion>().OnFog,
                obj.GetComponent<CrownJoinCongestion>().BG, () =>
                {
                    obj.GetComponent<CrownJoinCongestion>().We_Feat.SetActive(true);
                    obj.GetComponent<CrownJoinCongestion>().BiteFecundWokSpan(objData);
                }, () => { });
            BisFecundOil(objData);
            ClothWokSpanThen.Remove(objData);
        }
        else
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_scratch_reward);
            ToLoam = true;
            ToBore = true;
            obj.GetComponent<CrownJoinCongestion>().LoopExemplify(obj, obj.GetComponent<CrownJoinCongestion>().OnFog,
                obj.GetComponent<CrownJoinCongestion>().BG,
                () => { obj.GetComponent<CrownJoinCongestion>().BiteMutualWokSpan(); }, () => { });
            Invoke(nameof(FirnServeSkill), 2f);
        }
    }
}