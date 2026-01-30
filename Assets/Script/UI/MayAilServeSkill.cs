// Project: Plinko
// FileName: MayAilServeSkill.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 16:00
// Description:

using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class MayAilServeSkill : FirmUICharm
{
    public static MayAilServeSkill Instance;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinBGAnim")]
[UnityEngine.Serialization.FormerlySerializedAs("LysVasBGFair")]    public SkeletonGraphic TanAilBGPloy;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinWordAnim")]    [UnityEngine.Serialization.FormerlySerializedAs("LysVasDoomFair")]public SkeletonGraphic TanAilClayPloy;
[UnityEngine.Serialization.FormerlySerializedAs("getMoreBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("EraTiltFew")]    public Button RoeBoonWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFew")]public Button RoeWhy;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
[UnityEngine.Serialization.FormerlySerializedAs("adRed")]    public GameObject AnCod;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFewCent")]public GameObject RoeWhyLoss;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
[UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]    public GameObject DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraCent")]    public Text TurtleLoss;
[UnityEngine.Serialization.FormerlySerializedAs("bigWinType")]
[UnityEngine.Serialization.FormerlySerializedAs("LysVasFist")]    public BigWinType TanAilCity;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraBed")]    public double TurtleElk;

    private string RoyalCity;

    public override void Display()
    {
        base.Display();
        //GooseUSA.GetInstance().PlayEffect(GooseCity.UIMusic.sound_bigwin2_open);
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
        RoeBoonWhy.onClick.AddListener(() =>
        {
            if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Late_Tap_Turtle) == "new")
            {
                AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Late_Tap_Turtle, "done");
                AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Ice_Ant, "done");

             //   ShrubbyRejoinFleet.YewVocation().Pool(CChisel.Ask_Hero_Flap_Fair);
                BisFecund();
            }
            else
            {
                ADThinker.Feedback.DeepFecundAward((success) =>
                {
                    if (success)
                    {
                        RoyalCity = "1";
                        BisFecund();
                    }
                }, "2");
            }
        });

        RoeWhy.onClick.AddListener(() =>
        {
            RoyalCity = "0";
            ADThinker.Feedback.ToMutualBisTrove();
            HappySkill();
        });
    }

    public void BiteSpan(double num)
    {
        ADThinker.Feedback.OfferTiltTavernkeeper();
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_bigwin2_open);
        TurtleElk = num;
        TurtleLoss.text = "" + TurtleElk;
        BitePloy();

        if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Late_Tap_Turtle) == "new")
        {
            RoeWhy.gameObject.SetActive(false);
            AnCod.gameObject.SetActive(false);
            RoeWhyLoss.transform.localPosition = new Vector3(0f, 0f, 0f);
            AkinSpanThinker.GapFew(CChisel.Ox_To_Buggy_Tie, AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie) + 1);
        }
        else
        {
            RoeWhyLoss.transform.localPosition = new Vector3(37f, 0f, 0f);
            AnCod.gameObject.SetActive(true);
            RoeWhy.gameObject.SetActive(true);
            RoeWhy.GetComponent<CanvasGroup>().alpha = 0f;
            RoeWhy.enabled = false;

            DOTween.To(x => RoeWhy.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() =>
            {
                RoeWhy.enabled = true;
            });
        }
    }


    private void BitePloy()
    {
        TanAilBGPloy.AnimationState.SetAnimation(0, "chuxian", false);
        TanAilBGPloy.AnimationState.AddAnimation(0, "daiji", true, 0f);
        switch (TanAilCity)
        {
            case BigWinType.BigWin:
                TanAilClayPloy.AnimationState.SetAnimation(0, "Big_chuxian", false);
                TanAilClayPloy.AnimationState.AddAnimation(0, "Big_daiji", true, 0f);

                break;
            case BigWinType.HugeWin:
                TanAilClayPloy.AnimationState.SetAnimation(0, "Huge_chuxian", false);
                TanAilClayPloy.AnimationState.AddAnimation(0, "Huge_daiji", true, 0f);
                break;
            default:
                TanAilClayPloy.AnimationState.SetAnimation(0, "Mega_chuxian", false);
                TanAilClayPloy.AnimationState.AddAnimation(0, "Mega_daiji", true, 0f);
                break;
        }
    }


    private void BisFecund()
    {
        RoyalCity = "1";

        WideSkill.Instance.BisBill(TurtleElk, transform);

        // ExemplifyCongestion.CollectAni(WideSkill.Instance.cashImg.transform.position,
        //     Resources.Load<GameObject>("Art/FX/RewardImage"), new Vector3(0, 0, 0), WideSkill.Instance.transform,
        //     () => { });
        HappySkill();
    }

    private void HappySkill()
    {
        if (AkinSpanThinker.BisAttest(CChisel.Son_Yale_Line_us) == "new")
        {
            AkinSpanThinker.GapAttest(CChisel.Son_Yale_Line_us, "done");
            ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.Son_Yale_Line_us);
        }

        ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.Son_Slush_Aphid_Sap_Alter);

        SelfSheerRibbon.BisFeedback().CastSheer("1007", RoyalCity,TurtleElk.ToString());
        HappyUIMust(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
}