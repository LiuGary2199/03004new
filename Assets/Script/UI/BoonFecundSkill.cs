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

public class BoonFecundSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getRewardBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraSunlitFew")]public Button RoeFecundWhy;
[UnityEngine.Serialization.FormerlySerializedAs("GoldBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("NeonFew")]public Button ChopWhy;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    [UnityEngine.Serialization.FormerlySerializedAs("adRed")]public GameObject AnCod;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFewCent")]public GameObject RoeWhyLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ballNum")]
[UnityEngine.Serialization.FormerlySerializedAs("LuceBed")]    public Text JulyElk;
[UnityEngine.Serialization.FormerlySerializedAs("needGoldNum")]    [UnityEngine.Serialization.FormerlySerializedAs("CornNeonBed")]public Text BergChopElk;


    private string RoyalCity;


    private void Start()
    {
        SlushWhy.onClick.AddListener(() =>
        {
            RoyalCity = "0";
            ADThinker.Feedback.ToMutualBisTrove();
            HappySoloSkill();
        });

        ChopWhy.onClick.AddListener(() =>
        {
            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = WideSpanThinker.BisFeedback().BisChop();
            double BergElk= buyCount * 50000;
            if (BergElk >= 300000)
            {
                BergElk = 300000;
            }
            if (coincount >= BergElk)
            {
                BisFecund();
                WideSpanThinker.BisFeedback().BisChop(-BergElk);
                PlayerPrefs.SetInt("MoneyBuyBall", buyCount + 1);
            }
            else 
            {
                RoeFecundWhy.gameObject.SetActive(true);
                ChopWhy.gameObject.SetActive(false);
            }
        });

        RoeFecundWhy.onClick.AddListener(() =>
        {
            if (!AkinSpanThinker.BisLuck(CChisel.Ox_Wartime_Wok_July)) {
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
            SlushWhy.gameObject.SetActive(false);
            RoeWhyLoss.transform.localPosition = new Vector3(0f, 0f, 0f);
            
        }
        else
        {
            RoeWhyLoss.transform.localPosition = new Vector3(37f, 0f, 0f);
            AnCod.gameObject.SetActive(true);
            SlushWhy.gameObject.SetActive(true);
            SlushWhy.GetComponent<CanvasGroup>().alpha = 0f;
            SlushWhy.enabled = false;


            SlushWhy.GetComponent<CanvasGroup>().alpha = 0f;
            DOTween.To(x => SlushWhy.GetComponent<CanvasGroup>().alpha = x, 0, 1, 0.3f).SetDelay(2f)
                .OnComplete(() => { SlushWhy.enabled = true; });

            int buyCount = PlayerPrefs.GetInt("MoneyBuyBall", 1);
            double coincount = WideSpanThinker.BisFeedback().BisChop();
            double BergElk= buyCount * 50000;
            BergChopElk.text = BergElk.ToString();
            if (BergElk >= 300000)
            {
                BergElk = 300000;
            }
            if (coincount >= BergElk)
            {
                RoeFecundWhy.gameObject.SetActive(false);
                ChopWhy.gameObject.SetActive(true);
            }
            else
            {
                RoeFecundWhy.gameObject.SetActive(true);
                ChopWhy.gameObject.SetActive(false);
            }
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