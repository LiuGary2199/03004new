// Project: Plinko
// FileName: PatentAilServeSkill.cs
// Author: AX
// CreateDate: 20230515
// CreateTime: 16:01
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using Spine.Unity;

public class PatentAilServeSkill : FirmUICharm
{
    public static PatentAilServeSkill Instance;
[UnityEngine.Serialization.FormerlySerializedAs("normalSlot")]
[UnityEngine.Serialization.FormerlySerializedAs("PromptCrab")]    public PatentPlugCongestion UntruePlug;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("EraTiltFew")]    public Button RoeBoonWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFew")]public Button RoeWhy;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop01")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraPay01")]    public GameObject TurtleCud01;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop02")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraPay02")]public GameObject TurtleCud02;
[UnityEngine.Serialization.FormerlySerializedAs("rewardPop03")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraPay03")]public GameObject TurtleCud03;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]
[UnityEngine.Serialization.FormerlySerializedAs("SpaceFair")]    public SkeletonGraphic BylawPloy;


    private Dictionary<NormalRewardType, double> TurtleOil;


    private string RoyalCity;

    private string Pique2;
    private string Pique3;

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        //GooseUSA.GetInstance().PlayEffect(GooseCity.UIMusic.sound_bigwin1_open);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
    private void Start()
    {
        RoeBoonWhy.onClick.AddListener(() =>
        {
            ADThinker.Feedback.DeepFecundAward((success) =>
            {
                if (success)
                {
                    RoyalCity = "1";
                    RoeBoonWhy.gameObject.SetActive(false);
                    RoeWhy.gameObject.SetActive(false);
                    LionPlug();
                }
            },    AkinSpanThinker.BisAttest(CChisel.Ox_Untrue_Tap_No_No));
        });

        RoeWhy.onClick.AddListener(() =>
        {
            ADThinker.Feedback.ToMutualBisTrove();
            RoyalCity = "0";
            BisFecund();
        });
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        TurtleOil = new Dictionary<NormalRewardType, double>();
    }

    public void BiteSpan(Dictionary<NormalRewardType, double> map)
    {
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_bigwin1_open);

        BylawPloy.AnimationState.SetAnimation(0, "chuxian", false);
        BylawPloy.AnimationState.AddAnimation(0, "daiji", true, 0f);

        UntruePlug.BiteAffix();
        RoeBoonWhy.gameObject.SetActive(true);
        RoeWhy.gameObject.SetActive(true);
        RoeWhy.GetComponent<CanvasGroup>().alpha = 0f;
        RoeWhy.enabled = false;

        DOTween.To(x => RoeWhy.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
        {
            RoeWhy.enabled = true;
        });
        TurtleOil = map;

        TurtleCud02.gameObject.SetActive(false);
        TurtleCud02.gameObject.SetActive(false);
        TurtleCud03.gameObject.SetActive(false);
        TurtleCud01.transform.localScale = new Vector3(1f, 1f, 1f);
        TurtleCud02.transform.localScale = new Vector3(1f, 1f, 1f);
        TurtleCud03.transform.localScale = new Vector3(1f, 1f, 1f);

        List<NormalRewardType> keyList = new List<NormalRewardType>();
        List<double> valueList = new List<double>();

        foreach (var item in TurtleOil)
        {
            keyList.Add(item.Key);
            valueList.Add(item.Value);
        }

        if (TurtleOil.Count == 1)
        {
            TurtleCud01.transform.localPosition = new Vector3(0f, 380f, 0f);
            TurtleCud01.transform.localScale *= 1.2f;
            TurtleCud01.gameObject.SetActive(true);
            TurtleCud01.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[0], valueList[0]);
            Pique2 = valueList[0].ToString();
            Pique3 = BisPenal3(keyList[0]);
        }

        if (TurtleOil.Count == 2)
        {
            TurtleCud01.transform.localPosition = new Vector3(-220f, 350f, 0f);
            TurtleCud02.transform.localPosition = new Vector3(220f, 350f, 0f);

            TurtleCud01.gameObject.SetActive(true);
            TurtleCud02.gameObject.SetActive(true);
            TurtleCud01.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[0], valueList[0]);
            TurtleCud02.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[1], valueList[1]);
            Pique2 = "0";
            Pique3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Pique2 = valueList[i].ToString();
                    Pique3 = "1";
                }
            }
        }

        if (TurtleOil.Count == 3)
        {
            TurtleCud01.transform.localPosition = new Vector3(0f, 500f, 0f);
            TurtleCud02.transform.localPosition = new Vector3(-240f, 250f, 0f);
            TurtleCud03.transform.localPosition = new Vector3(240f, 250f, 0f);

            TurtleCud01.transform.localScale *= 0.8f;
            TurtleCud02.transform.localScale *= 0.8f;
            TurtleCud03.transform.localScale *= 0.8f;

            TurtleCud01.gameObject.SetActive(true);
            TurtleCud02.gameObject.SetActive(true);
            TurtleCud03.gameObject.SetActive(true);

            TurtleCud01.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[0], valueList[0]);
            TurtleCud02.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[1], valueList[1]);
            TurtleCud03.gameObject.GetComponent<PatentFecundCudCongestion>().BiteSpan(keyList[2], valueList[2]);

            Pique2 = "0";
            Pique3 = "0";
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i] == NormalRewardType.Cash)
                {
                    Pique2 = valueList[i].ToString();
                    Pique3 = "1";
                }
            }
        }
    }

    private int BisPlugAngry()
    {
        int sumWeight = 0;
        foreach (RewardMultiItem wg in TanGenuUSA.instance.BiteSpan.RewardMultiList)
        {
            sumWeight += wg.weight;
        }

        int r = Random.Range(0, sumWeight);
        int nowWeight = 0;
        int Aphid= 0;
        foreach (RewardMultiItem wg in TanGenuUSA.instance.BiteSpan.RewardMultiList)
        {
            nowWeight += wg.weight;
            if (nowWeight > r)
            {
                return Aphid;
            }

            Aphid++;
        }

        return 0;
    }


    private string BisPenal3(NormalRewardType type)
    {
        switch (type)
        {
            case NormalRewardType.Cash:
                return "1";
            case NormalRewardType.Gold:
                return "2";
            default:
                return "3";
        }
    }


    private void LionPlug()
    {
        int Aphid= BisPlugAngry();
        UntruePlug.AmidPlug(Aphid, (multi) =>
        {
            if (TurtleCud01.activeInHierarchy)
            {
                TurtleCud01.gameObject.GetComponent<PatentFecundCudCongestion>().SteppeElkPloy(multi);
            }

            if (TurtleCud02.activeInHierarchy)
            {
                TurtleCud02.gameObject.GetComponent<PatentFecundCudCongestion>().SteppeElkPloy(multi);
            }

            if (TurtleCud03.activeInHierarchy)
            {
                TurtleCud03.gameObject.GetComponent<PatentFecundCudCongestion>().SteppeElkPloy(multi);
            }

            Invoke(nameof(BisFecund), 1f);
        });
    }

    private void HappyPatentSkill()
    {
        if (AkinSpanThinker.BisAttest(CChisel.Ox_Untrue_Tap_News) == "1014")
        {
            Pique3 = "1";
            String gemType = AkinSpanThinker.BisAttest(CChisel.Ox_Lawn_News);
            switch (gemType)
            {
                case "Yellow":
                    Pique3 = "1";
                    break;
                case "Blue":
                    Pique3 = "2";
                    break;
                case "Silver":
                    Pique3 = "3";
                    break;
                default:
                    Pique3 = "4";
                    break;
            }

            SelfSheerRibbon.BisFeedback()
                .CastSheer(AkinSpanThinker.BisAttest(CChisel.Ox_Untrue_Tap_News), RoyalCity, Pique2, Pique3);
        }
        else
        {
            SelfSheerRibbon.BisFeedback()
                .CastSheer(AkinSpanThinker.BisAttest(CChisel.Ox_Untrue_Tap_News), RoyalCity, Pique2, Pique3);
        }

        ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.Son_Slush_Aphid_Sap_Alter);
        // ShrubbyRejoinFleet.GetInstance().Send(CChisel.msg_show_cash_mask);

        HappyUIMust(GetType().Name);
    }

    private void BisFecund()
    {
        if (TurtleCud01.activeInHierarchy)
        {
            TurtleCud01.gameObject.GetComponent<PatentFecundCudCongestion>().BisPatentAilFecund();
        }

        if (TurtleCud02.activeInHierarchy)
        {
            TurtleCud02.gameObject.GetComponent<PatentFecundCudCongestion>().BisPatentAilFecund();
        }

        if (TurtleCud03.activeInHierarchy)
        {
            TurtleCud03.gameObject.GetComponent<PatentFecundCudCongestion>().BisPatentAilFecund();
        }

        HappyPatentSkill();
    }
}