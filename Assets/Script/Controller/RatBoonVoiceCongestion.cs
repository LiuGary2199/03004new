// Project: Plinko
// FileName: RatBoonVoiceCongestion.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:28
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class RatBoonVoiceCongestion : MonoBehaviour
{
    public static RatBoonVoiceCongestion Instance;
[UnityEngine.Serialization.FormerlySerializedAs("step1Btn")]
[UnityEngine.Serialization.FormerlySerializedAs("Beam1Few")]    public Button Sled1Why;
[UnityEngine.Serialization.FormerlySerializedAs("step2Btn")]
[UnityEngine.Serialization.FormerlySerializedAs("Beam2Few")]    public Button Sled2Why;
[UnityEngine.Serialization.FormerlySerializedAs("step3Btn")]
[UnityEngine.Serialization.FormerlySerializedAs("Beam3Few")]    public Button Sled3Why;
[UnityEngine.Serialization.FormerlySerializedAs("step4Btn")]
[UnityEngine.Serialization.FormerlySerializedAs("Beam4Few")]    public Button Sled4Why;
[UnityEngine.Serialization.FormerlySerializedAs("cashMaskObj")]
[UnityEngine.Serialization.FormerlySerializedAs("FlapMiteGel")]    public GameObject DeedSlatWok;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Sled1Why.onClick.AddListener(() =>
        {
            Sled1Why.gameObject.SetActive(false);
            Invoke(nameof(FirnWeft2Why), 0.3f);
        });

        Sled2Why.onClick.AddListener(() =>
        {
            Sled2Why.gameObject.SetActive(false);
            Invoke(nameof(FirnWeft3Why), 0.3f);
        });


        Sled3Why.onClick.AddListener(() =>
        {
            Sled3Why.gameObject.SetActive(false);
            Invoke(nameof(FirnWeft4Why), 0.3f);
        });


        Sled4Why.onClick.AddListener(() =>
        {
            Sled4Why.gameObject.SetActive(false);
            ReuseWide();
        });

        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Yale_Deed_Ploy,
            (messageData) =>
            {
                Invoke(nameof(FirnBillSlat),0.5f);
            });


        BiteSpan();
    }


    private void FirnWeft2Why()
    {
        Sled2Why.gameObject.SetActive(true);
    }

    private void FirnWeft3Why()
    {
        Sled3Why.gameObject.SetActive(true);
    }

    private void FirnWeft4Why()
    {
        Sled4Why.gameObject.SetActive(true);
    }

    private void ReuseWide()
    {
        AkinSpanThinker.GapAttest(CChisel.Ox_Enable_Six_Limy_Pluto, "done");
        VerbThinker.Instance.WidePassage();
    }

    public void BiteSpan()
    {
        if (AkinSpanThinker.BisAttest(CChisel.Ox_Enable_Six_Limy_Pluto) == "new" && !BurrowLift.ItChair())
        {
            Sled1Why.gameObject.SetActive(false);
            Invoke(nameof(FirnBillSlat), 0.5f);

        }
        else
        {
            Sled1Why.gameObject.SetActive(false);
            Sled2Why.gameObject.SetActive(false);
            Sled3Why.gameObject.SetActive(false);
            Sled4Why.gameObject.SetActive(false);
            DeedSlatWok.gameObject.SetActive(false);
        }
    }


    public void FirnBillSlat()
    {
        if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Deed_Eke) == "new")
        {
            AkinSpanThinker.GapAttest(CChisel.Ox_Alter_Deed_Eke, "done");

            if (BurrowLift.ItChair())
            {
                return;
            }

            VerbThinker.Instance.WideRime();
            DeedSlatWok.gameObject.SetActive(true);
        }
        else
        {
          
            if (AkinSpanThinker.BisAttest(CChisel.Ox_Enable_Six_Limy_Pluto) == "new" && !BurrowLift.ItChair())
            {
                Sled1Why.gameObject.SetActive(true);
                Sled2Why.gameObject.SetActive(false);
                Sled3Why.gameObject.SetActive(false);
                Sled4Why.gameObject.SetActive(false);
                DeedSlatWok.gameObject.SetActive(false);
                VerbThinker.Instance.WideRime();
            }
            else
            {
                DeedSlatWok.gameObject.SetActive(false);
                Sled1Why.gameObject.SetActive(false);
                Sled2Why.gameObject.SetActive(false);
                Sled3Why.gameObject.SetActive(false);
                Sled4Why.gameObject.SetActive(false);
                DeedSlatWok.gameObject.SetActive(false);
                VerbThinker.Instance.WidePassage();
            } 
        }
    }
}