// Project: Plinko
// FileName: PatentFecundCudCongestion.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 16:53
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class PatentFecundCudCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    [UnityEngine.Serialization.FormerlySerializedAs("SlowRed")]public GameObject BearCod;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]public GameObject DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRed")]public GameObject LegumeCod;
[UnityEngine.Serialization.FormerlySerializedAs("rollCashImg")]    [UnityEngine.Serialization.FormerlySerializedAs("BossCashRed")]public GameObject HeelDireCod;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraBedCent")]    public Text TurtleElkLoss;

    private NormalRewardType TurtleCity;
    private double TurtleElk;


    public void BiteSpan(NormalRewardType thisType, double num)
    {
        TurtleCity = thisType;
        TurtleElk = num;
        HappyCod();
        FirnCod();
        TurtleElkLoss.text = "+ " + TurtleElk;
    }


    private void HappyCod()
    {
        BearCod.gameObject.SetActive(false);
        DeedCod.gameObject.SetActive(false);
        LegumeCod.gameObject.SetActive(false);
        HeelDireCod.gameObject.SetActive(false);
    }

    private void FirnCod()
    {
        switch (TurtleCity)
        {
            case NormalRewardType.Amazon:
                LegumeCod.gameObject.SetActive(true);
                break;
            case NormalRewardType.Cash:
                DeedCod.gameObject.SetActive(true);
                break;
            case NormalRewardType.RollCash:
                HeelDireCod.gameObject.SetActive(true);
                break;
            default:
                BearCod.gameObject.SetActive(true);
                break;
        }
    }

    public void SteppeElkPloy(int multi)
    {
        ExemplifyCongestion.SteppeCarton(TurtleElk, TurtleElk * multi, 0, TurtleElkLoss, "+", () =>
        {
            TurtleElk = TurtleElk * multi;
            TurtleElkLoss.text = "+" + CartonLift.HeydayMyEke(TurtleElk);
        });
    }


    public void BisPatentAilFecund()
    {
        switch (TurtleCity)
        {
            case NormalRewardType.Amazon:
                WideSkill.Instance.BisChisel(TurtleElk, LegumeCod.transform);
                break;
            case NormalRewardType.Cash:
                WideSkill.Instance.BisBill(TurtleElk, DeedCod.transform);
                break;
            case NormalRewardType.RollCash:
                WideSkill.Instance.BisBill(TurtleElk, DeedCod.transform);
                break;
            default:
                WideSkill.Instance.BisChop(TurtleElk, BearCod.transform);
                break;
        }
    }
}