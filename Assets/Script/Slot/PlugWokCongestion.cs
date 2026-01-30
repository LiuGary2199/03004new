// Project: Plinko
// FileName: PlugWokCongestion.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 14:21
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class PlugWokCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("BigWin")]    [UnityEngine.Serialization.FormerlySerializedAs("TinVas")]public GameObject MayAil;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_1")]    [UnityEngine.Serialization.FormerlySerializedAs("Such_1")]public GameObject Bill_1;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_2")]    [UnityEngine.Serialization.FormerlySerializedAs("Such_2")]public GameObject Bill_2;
[UnityEngine.Serialization.FormerlySerializedAs("Cash_3")]    [UnityEngine.Serialization.FormerlySerializedAs("Such_3")]public GameObject Bill_3;
[UnityEngine.Serialization.FormerlySerializedAs("SkillWall")]    [UnityEngine.Serialization.FormerlySerializedAs("CourtLake")]public GameObject ButteAcid;
[UnityEngine.Serialization.FormerlySerializedAs("SkillBigCoin")]    [UnityEngine.Serialization.FormerlySerializedAs("CourtTinKind")]public GameObject ButteMayGill;
[UnityEngine.Serialization.FormerlySerializedAs("SkillLong")]    [UnityEngine.Serialization.FormerlySerializedAs("CourtFall")]public GameObject ButteEase;
[UnityEngine.Serialization.FormerlySerializedAs("GemBlue")]    [UnityEngine.Serialization.FormerlySerializedAs("TieEven")]public GameObject PegHigh;
[UnityEngine.Serialization.FormerlySerializedAs("GemRed")]    [UnityEngine.Serialization.FormerlySerializedAs("TieZoo")]public GameObject PegEnd;
[UnityEngine.Serialization.FormerlySerializedAs("GemDiamond")]    [UnityEngine.Serialization.FormerlySerializedAs("TieHeroism")]public GameObject PegPerplex;
[UnityEngine.Serialization.FormerlySerializedAs("Golden")]    [UnityEngine.Serialization.FormerlySerializedAs("Concur")]public GameObject Emboss;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjData")]
[UnityEngine.Serialization.FormerlySerializedAs("PestGelHall")]    //public Text numText;

    public SlotRewardType SaltWokHall;


    public void BiteSpanMoment()
    {
        SaltWokHall = GameUtil.GetSlotObjDataWithOutThanks();
        BiteSpanAnSpan(SaltWokHall);
    }

    public void BiteSpanAnSpan(SlotRewardType targetObj)
    {
        //if (BurrowLift.IsApple())
        //{
        //    if (targetObj.SlotObjType == SlotObjType.Cash)
        //    {
        //        targetObj.SlotObjType = SlotObjType.Ball;
        //    }
        //}

        SaltWokHall = targetObj;
        HappyCod();
        FirnCod();
    }


    private void HappyCod()
    {
        MayAil.gameObject.SetActive(false);
        Bill_1.gameObject.SetActive(false);
        Bill_2.gameObject.SetActive(false);
        Bill_3.gameObject.SetActive(false);
        ButteAcid.gameObject.SetActive(false);
        ButteMayGill.gameObject.SetActive(false);
        ButteEase.gameObject.SetActive(false);
        PegHigh.gameObject.SetActive(false);
        PegEnd.gameObject.SetActive(false);
        PegPerplex.gameObject.SetActive(false);
        Emboss.gameObject.SetActive(false);
    }


    private void FirnCod()
    {
        switch (SaltWokHall)
        {
            case SlotRewardType.BigWin:
                MayAil.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash1:
                Bill_1.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash2:
                Bill_2.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.Cash3:
                Bill_3.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillWall:
                ButteAcid.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillBigCoin:
                ButteMayGill.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.SkillLong:
                ButteEase.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemBlue:
                PegHigh.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemRed:
                PegEnd.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            case SlotRewardType.GemDiamond:
                PegPerplex.gameObject.SetActive(true);
                //numText.text = slotObjData.RewardNum + "";
                break;
            default:
                Emboss.gameObject.SetActive(true);
                //numText.text = "";
                break;
        }
    }
}