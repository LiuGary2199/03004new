// Project: Pusher
// FileName: GrandmaWokCongestion.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 10:42
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandmaWokCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("getBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("EraFew")]public Button RoeWhy;
[UnityEngine.Serialization.FormerlySerializedAs("btnBgY")]    [UnityEngine.Serialization.FormerlySerializedAs("EggByY")]public Image FenOxY;
[UnityEngine.Serialization.FormerlySerializedAs("silverImg")]
[UnityEngine.Serialization.FormerlySerializedAs("PeopleRed")]    public GameObject RecentCod;
[UnityEngine.Serialization.FormerlySerializedAs("blueImg")]    [UnityEngine.Serialization.FormerlySerializedAs("SlabRed")]public GameObject LordCod;
[UnityEngine.Serialization.FormerlySerializedAs("yellowImg")]    [UnityEngine.Serialization.FormerlySerializedAs("SliderRed")]public GameObject SliderCod;
[UnityEngine.Serialization.FormerlySerializedAs("goldBarImg")]    [UnityEngine.Serialization.FormerlySerializedAs("SlowRodRed")]public GameObject BearHisCod;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]
[UnityEngine.Serialization.FormerlySerializedAs("SlowRed")]    public Image BearCod;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]public Image DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRed")]public Image LegumeCod;
[UnityEngine.Serialization.FormerlySerializedAs("sliderProgress")]
[UnityEngine.Serialization.FormerlySerializedAs("UnwellSquirrel")]    public Image PotatoNearness;
[UnityEngine.Serialization.FormerlySerializedAs("gemsNum")]    [UnityEngine.Serialization.FormerlySerializedAs("TwigBed")]public Text LawnElk;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    [UnityEngine.Serialization.FormerlySerializedAs("DirectorCent")]public Text RegionalLoss;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraBedCent")]public Text TurtleElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("maxNum")]
[UnityEngine.Serialization.FormerlySerializedAs("AlpBed")]    public int EggElk;
[UnityEngine.Serialization.FormerlySerializedAs("currentNum")]    [UnityEngine.Serialization.FormerlySerializedAs("SurmiseBed")]public int PolluteElk;
[UnityEngine.Serialization.FormerlySerializedAs("gemsDataItem")]
[UnityEngine.Serialization.FormerlySerializedAs("TwigHallGate")]    public GemsDataItem LawnSpanGate;
    private GemsType RotePegCity;
    private RewardType TurtleCity;

    
    private Dictionary<NormalRewardType, double> TurtleOil;

    private void Start()
    {
        RoeWhy.onClick.AddListener(() =>
        {
            if (!FenOxY.gameObject.activeInHierarchy)
            {
                return;
            }

            BisFecund();
        });
    }

    private void HappyHolmCod()
    {
        RecentCod.gameObject.SetActive(false);
        LordCod.gameObject.SetActive(false);
        SliderCod.gameObject.SetActive(false);
        BearHisCod.gameObject.SetActive(false);
    }

    private void FirnHolmCod()
    {
        switch (RotePegCity)
        {
            case GemsType.Silver:
                RecentCod.gameObject.SetActive(true);
                break;
            case GemsType.Blue:
                LordCod.gameObject.SetActive(true);
                break;
            case GemsType.Yellow:
                SliderCod.gameObject.SetActive(true);
                break;
            default:
                BearHisCod.gameObject.SetActive(true);
                break;
        }
    }

    private void HappyFecundCod()
    {
        BearCod.gameObject.SetActive(false);
        DeedCod.gameObject.SetActive(false);
        LegumeCod.gameObject.SetActive(false);
    }

    private void FirnFecundCod()
    {
        switch (TurtleCity)
        {
            case RewardType.Gold:
                BearCod.gameObject.SetActive(true);
                break;
            case RewardType.Cash:
                DeedCod.gameObject.SetActive(true);
                break;
            default:
                LegumeCod.gameObject.SetActive(true);
                break;
        }
    }

    public void BiteSpan()
    {
        RotePegCity = (GemsType) Enum.Parse(typeof(GemsType), LawnSpanGate.gem_type);
        TurtleCity = (RewardType) Enum.Parse(typeof(RewardType), LawnSpanGate.reward_type);
        TurtleElkLoss.text = LawnSpanGate.reward_num + "";

        if (BurrowLift.ItChair())
        {
            TurtleCity = RewardType.Gold;
        }

        HappyHolmCod();
        FirnHolmCod();
        HappyFecundCod();
        FirnFecundCod();

        PolluteElk = AkinSpanThinker.BisFew(RotePegCity.ToString());
        EggElk = LawnSpanGate.gem_limit;

        RegionalLoss.text = (PolluteElk < EggElk ? PolluteElk : EggElk) + "/" + EggElk;
        LawnElk.text = "x " + EggElk;
        PotatoNearness.fillAmount = (PolluteElk < EggElk ? PolluteElk : EggElk) * 1.0f / EggElk;
        FenOxY.gameObject.SetActive(PolluteElk >= EggElk);
    }


    public void BisFecund()
    {
        
        TurtleOil = new Dictionary<NormalRewardType, double>();
        NormalRewardType TurtleCity= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), LawnSpanGate.reward_type);
        TurtleOil.Add(TurtleCity, LawnSpanGate.reward_num);
        
        PolluteElk = 0;
        AkinSpanThinker.GapFew(RotePegCity.ToString(),0);
        // InitData();
        // UILatter.GetInstance().CloseOrReturnUIForms(GetType().Name);
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_No_No,"7");
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_News, "1014");
        AkinSpanThinker.GapAttest(CChisel.Ox_Lawn_News, RotePegCity.ToString());
        FecundSkillThinker.Instance.FirnPatentFecundSkill(TurtleOil);
        
    }
}