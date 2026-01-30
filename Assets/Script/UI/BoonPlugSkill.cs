// Project: Plinko
// FileName: BoonPlugSkill.cs
// Author: AX
// CreateDate: 20230510
// CreateTime: 9:23
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class BoonPlugSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFew")]public Button RoeWhy;
[UnityEngine.Serialization.FormerlySerializedAs("getBtnText")]
[UnityEngine.Serialization.FormerlySerializedAs("EraFewCent")]
    public GameObject RoeWhyLoss;
[UnityEngine.Serialization.FormerlySerializedAs("adImg")]    [UnityEngine.Serialization.FormerlySerializedAs("adRed")]public GameObject AnCod;


    private string RoyalCity;

    private void Start()
    {
        SlushWhy.onClick.AddListener(() =>
        {
            RoyalCity = "0";
            ADThinker.Feedback.ToMutualBisTrove();
            VerbThinker.Instance.WidePassage();
            HappySoloSkill();
        });

        RoeWhy.onClick.AddListener(() =>
        {
            if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Salt_Chimp) == "new")
            {
                AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Salt_Chimp, "done");
                BisFecund();
            }
            else
            {
                ADThinker.Feedback.DeepFecundAward((success) => {
                    if (success)
                    {
                        BisFecund();
                    }
                }, "1");
            }
        });
    }

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Salt_Chimp) == "new")
        {
            AnCod.gameObject.SetActive(false);
            RoeWhyLoss.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        else
        {
            RoeWhyLoss.transform.localPosition = new Vector3(37f, 0f, 0f);
            AnCod.gameObject.SetActive(true);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }

    private void BisFecund()
    {
        RoyalCity = "1";

        UpwardPlugKeyAstonish.Instance.BisPlugTrove();
        HappySoloSkill();
    }


    private void HappySoloSkill()
    {
        SelfSheerRibbon.BisFeedback().CastSheer("1004", RoyalCity);
        VerbThinker.Instance.WidePassage();
        HappyUIMust(GetType().Name);
    }
}