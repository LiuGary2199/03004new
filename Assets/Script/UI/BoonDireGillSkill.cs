// Project: Plinko
// FileName: BoonFecundSkill.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 10:00
// Description:

using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class BoonDireGillSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraSunlitFew")]public Button RoeFecundWhy;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("CuspidorFew")]public Button AmenableWhy;
[UnityEngine.Serialization.FormerlySerializedAs("NoExchangeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("NoCuspidorFew")]public GameObject UpAmenableWhy;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]
[UnityEngine.Serialization.FormerlySerializedAs("adRed")]    public GameObject AnCod;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]
[UnityEngine.Serialization.FormerlySerializedAs("EraFewCent")]    public GameObject RoeWhyLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
[UnityEngine.Serialization.FormerlySerializedAs("LuceBed")]    public Text JulyElk;
[UnityEngine.Serialization.FormerlySerializedAs("NeedNum")]    [UnityEngine.Serialization.FormerlySerializedAs("SiteBed")]public Text SpanElk;
[UnityEngine.Serialization.FormerlySerializedAs("needNum")]    [UnityEngine.Serialization.FormerlySerializedAs("CornBed")]public int BergElk;
    private string RoyalCity;


    private void Start()
    {
        SpanElk.text = BergElk.ToString();
        SlushWhy.onClick.AddListener(() =>
        {
            RoyalCity = "0";
            ADThinker.Feedback.ToMutualBisTrove();
            HappySoloSkill();
        });

        AmenableWhy.onClick.AddListener(() =>
        {
            double coincount = WideSpanThinker.BisFeedback().BisChop();
            if (coincount >= BergElk)
            {
                WideSpanThinker.BisFeedback().BisChop(-BergElk);
                CubanRiceThinker.Instance.BisCubanRice();
                //WideSkill.Instance.goldNumText.text = WideSpanThinker.GetInstance().GetGold() + "";
                WideSkill.Instance.RatChopElkLoss.text = WideSpanThinker.BisFeedback().BisChop() + "";
                HappySoloSkill();
            }
        });

        RoeFecundWhy.onClick.AddListener(() =>
        {
            if (!AkinSpanThinker.BisLuck(CChisel.Ox_Wartime_Wok_July))
            {
                AkinSpanThinker.GapLuck(CChisel.Ox_Wartime_Wok_July, true);
                BisFecund();
            }
            else
            {
                ADThinker.Feedback.DeepFecundAward((success) => {
                    if (success)
                    {
                        BisFecund();
                    }
                }, "8");
            }
        });

        JulyElk.text = "" + TanGenuUSA.instance.WideSpan.base_config.ball_limit;
    }


    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        double coincount = WideSpanThinker.BisFeedback().BisChop();
        AmenableWhy.gameObject.SetActive(coincount >= BergElk);
        UpAmenableWhy.SetActive(coincount < BergElk);
        // if (BurrowLift.IsApple())
        // {
        //     adImg.gameObject.SetActive(false);
        //     getBtnText.transform.localPosition = new Vector3(37f, 0f, 0f);
        //     closeBtn.gameObject.SetActive(true);
        // }
        // else
        // {
        if (!AkinSpanThinker.BisLuck(CChisel.Ox_Wartime_Wok_July))
        {
            AnCod.gameObject.SetActive(false);
            //closeBtn.gameObject.SetActive(false);
            RoeWhyLoss.transform.localPosition = new Vector3(0f, 0f, 0f);

        }
        else
        {
            RoeWhyLoss.transform.localPosition = new Vector3(37f, 0f, 0f);
            AnCod.gameObject.SetActive(true);
            SlushWhy.gameObject.SetActive(true);
           // closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // closeBtn.enabled = false;


            //closeBtn.GetComponent<CanvasGroup>().alpha = 0f;
           // DOTween.To(x => closeBtn.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f).OnComplete(() => { closeBtn.enabled = true; });
        }
        // }
    }

    private void BisFecund()
    {
        RoyalCity = "1";
        CubanRiceThinker.Instance.BisCubanRice();
        HappySoloSkill();
    }


    private void HappySoloSkill()
    {
        SelfSheerRibbon.BisFeedback().CastSheer("1015", RoyalCity);
        VerbThinker.Instance.WidePassage();
        HappyUIMust(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
}
