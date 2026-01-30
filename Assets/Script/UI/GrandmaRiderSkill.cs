// Project: Pusher
// FileName: GrandmaRiderSkill.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:20
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandmaRiderSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("objList")]
[UnityEngine.Serialization.FormerlySerializedAs("RimGerm")]    public List<GameObject> DonThen;

    private List<GemsDataItem> DrySpanThen;
    private void Start()
    {
        SlushWhy.onClick.AddListener(() =>
        {
            HappySkill();
        });
        
        
        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Slush_Aphid_Sap_Alter,
            (messageData) => {HappySkill(); });

    }


    protected override void Awake()
    {
        base.Awake();
        DrySpanThen = TanGenuUSA.instance.WideSpan.Gem_Reward_list;
    }

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        BiteSpan();
    }

    private void BiteSpan()
    {
        for (int i = 0; i < DonThen.Count; i++)
        {
            GameObject objItem = DonThen[i];
            objItem.GetComponent<GrandmaWokCongestion>().LawnSpanGate = DrySpanThen[i];
            objItem.GetComponent<GrandmaWokCongestion>().BiteSpan();
        }
    }


    private void HappySkill()
    {
        BiteSpan();
        VerbThinker.Instance.WidePassage();
        HappyUIMust(GetType().Name);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
}