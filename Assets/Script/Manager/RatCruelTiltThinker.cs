// Project: Plinko
// FileName: CruelTiltThinker.cs
// Author: AX
// CreateDate: 20230508
// CreateTime: 16:04
// Description:

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class
    RatCruelTiltThinker : MonoBehaviour
{
    public static RatCruelTiltThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("progressImg")]
[UnityEngine.Serialization.FormerlySerializedAs("DirectorRed")]    public Image RegionalCod;

    private int TenthThumb;
    private int TenthTilt;

    private int PolluteTilt;
    private int PolluteRice;
[UnityEngine.Serialization.FormerlySerializedAs("isFeverTime")]
[UnityEngine.Serialization.FormerlySerializedAs("WeTenthFast")]    public bool ToCruelTilt;

    private double AlterBill;
    private double RibBill;

    private bool DumpCruelTilt;

    private void Awake()
    {
        Instance = this;
        ToCruelTilt = false;
        DumpCruelTilt = false;
        TenthThumb = TanGenuUSA.instance.WideSpan.base_config.fever_limit;
        TenthTilt = TanGenuUSA.instance.WideSpan.base_config.fever_time;
    }

    private void Start()
    {
        StaveSpan();
    }


    private void Update()
    {
        if (ToCruelTilt)
        {
            if (!DumpCruelTilt)
            {
                RegionalCod.fillAmount -= Time.deltaTime / TenthTilt;
                if (RegionalCod.fillAmount == 0)
                {
                    HappyCruelTilt();
                }
            }
        }
    }

    public void RimeCruel()
    {
        DumpCruelTilt = true;
    }

    public void MyReuseCruelTilt()
    {
        DumpCruelTilt = false;
    }

    public void StaveSpan()
    {
        PolluteRice = AkinSpanThinker.BisFew(CChisel.Ox_Tenth_Bind_Pollute);
        TrolleyNearness();
    }


    public void BisCruelRice()
    {
        if (ToCruelTilt) return;

        PolluteRice++;
        AkinSpanThinker.GapFew(CChisel.Ox_Tenth_Bind_Pollute, PolluteRice);
        TrolleyNearness();
        if (PolluteRice >= TenthThumb)
        {
            ReuseCruelTilt();
        }
    }

    private void ReuseCruelTilt()
    {
        AkinSpanThinker.GapFew(CChisel.Ox_Tenth_Bind_Pollute, 0);
        SelfSheerRibbon.BisFeedback().CastSheer("1006");

        // GooseUSA.GetInstance().PlayBg(GooseCity.UIMusic.sound_fever_bgm);

        // startCash = AkinSpanThinker.GetDouble(CChisel.sv_CumulativeCash);
        ToCruelTilt = true;
        PolluteTilt = TenthTilt;
        // PillarManager.Instance.CloseBigWinPillar();
        // CubanRiceThinker.Instance.StartFeverTimeForSteelBall();
        // PillarManager.Instance.PillarGroupMove();
        // Fx_Group.Instance.FX_Fever.SetActive(true);
    }

    private void HappyCruelTilt()
    {
        // GooseUSA.GetInstance().PlayBg(GooseCity.UIMusic.sound_bgm);

        // Fx_Group.Instance.FX_Fever.SetActive(false);
        ToCruelTilt = false;
        // CubanRiceThinker.Instance.CloseFeverTimeForSteelBall();
        StaveSpan();
        if (BurrowLift.ItChair()) return;

        // endCash = AkinSpanThinker.GetDouble(CChisel.sv_CumulativeCash);
        // double cash = Math.Round((endCash - startCash), 2);
        // AkinSpanThinker.SetDouble(CChisel.sv_big_win_cash, cash);
        // ShaperThinker.Instance.StopGame();

        // AkinSpanThinker.SetString(CChisel.sv_big_win_type, "1007");
        // AkinSpanThinker.SetString(CChisel.sv_big_win_ad_id, "3");

        // UILatter.GetInstance().ShowUIForms(nameof(MayAilServeSkill));
        // double num = 10;
        // FecundSkillThinker.Instance.ShowBigRewardPanel(num);
    }

    private void TrolleyNearness()
    {
        RegionalCod.fillAmount = 1f * PolluteRice / TenthThumb;
    }
}