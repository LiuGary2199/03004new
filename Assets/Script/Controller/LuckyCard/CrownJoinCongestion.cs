// Project: Pusher
// FileName: CrownJoinCongestion.cs
// Author: AX
// CreateDate: 20230803
// CreateTime: 15:54
// Description:

using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CrownJoinCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("bgGold")]    [UnityEngine.Serialization.FormerlySerializedAs("SoNeon")]public GameObject OnChop;
[UnityEngine.Serialization.FormerlySerializedAs("bgSilver")]    [UnityEngine.Serialization.FormerlySerializedAs("SoScrape")]public GameObject OnMeadow;
[UnityEngine.Serialization.FormerlySerializedAs("bgTop")]    [UnityEngine.Serialization.FormerlySerializedAs("SoMob")]public GameObject OnFog;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
[UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]    public GameObject DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]    [UnityEngine.Serialization.FormerlySerializedAs("GulfRed")]public GameObject SlatCod;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRed")]public GameObject LegumeCod;
[UnityEngine.Serialization.FormerlySerializedAs("overImg")]    [UnityEngine.Serialization.FormerlySerializedAs("RakeRed")]public GameObject RakeCod;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    [UnityEngine.Serialization.FormerlySerializedAs("BG")]public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Open")]    [UnityEngine.Serialization.FormerlySerializedAs("Ox_Down")]public GameObject We_Feat;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraCent")]    public Text TurtleLoss;
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraFist")]    public LuckyObjType TurtleCity;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraBed")]public double TurtleElk;



    public void HappyWok()
    {
        HappyCod();
        //bgTop.gameObject.SetActive(true);
    }


    public void BiteFecundWokSpan(LuckyObjData luckyObjData)
    {
        BG.SetActive(true);
        TurtleCity = luckyObjData.LuckyObjType;
        TurtleElk = luckyObjData.RewardNum;
        HappyCod();
        TurtleLoss.text = TurtleElk+"";

        switch (TurtleCity)
        {
            case LuckyObjType.Cash:
                DeedCod.gameObject.SetActive(true);
                break;
            case LuckyObjType.Gold:
                SlatCod.gameObject.SetActive(true);
                OnMeadow.gameObject.SetActive(true);
                break;
            default:
                LegumeCod.gameObject.SetActive(true);
                OnMeadow.gameObject.SetActive(true);
                break;
        }

    }

    public void BiteMutualWokSpan()
    {
        BG.SetActive(true);
        HappyCod();
        RakeCod.gameObject.SetActive(true);
    }

    private void HappyCod()
    {
        OnFog.gameObject.SetActive(false);
        DeedCod.gameObject.SetActive(false);
        LegumeCod.gameObject.SetActive(false);
        SlatCod.gameObject.SetActive(false);
        OnMeadow.gameObject.SetActive(false);
        RakeCod.gameObject.SetActive(false);
        OnChop.gameObject.SetActive(true);
        
    }


    private void OnMouseOver()
    {
        if (OnFog.activeInHierarchy != true||CrownJoinSkill.Instance.ToBore) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            //bgTop.gameObject.SetActive(false);
            GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.Sound_PopShow);
            CrownJoinSkill.Instance.BisTimberThen(gameObject);
        }
    }

    public void LoopExemplify(GameObject Card, GameObject CardBack, GameObject CardFront,System.Action start, System.Action finish) 
    {
        Card.transform.DOScale(1.3f, 0.3f);
        Card.transform.DORotate(new Vector3(0, 90, 0), 0.3f).OnComplete(() =>
        {
            start();
            CardBack.SetActive(false);
            CardFront.SetActive(true);
            Card.transform.DOScale(1, 0.3f);
            Card.transform.DORotate(new Vector3(0, 0, 0), 0.3f).OnComplete(()=>
            {
                finish();
            });
        });
    }
}