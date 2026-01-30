// Project: Plinko
// FileName: CubanRiceThinker.cs
// Author: AX
// CreateDate: 20230427
// CreateTime: 15:20
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CubanRiceThinker : MonoBehaviour
{
    public static CubanRiceThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("currentBallNum")]
[UnityEngine.Serialization.FormerlySerializedAs("SurmiseLifeBed")]    public int PolluteRiceElk;

    private float JulyThumb;

    private double ViabilityIt;

    private bool DumpSpew;

    private bool ToCruelTilt;

    string AxTilt;

    private bool BeachRiceBore;

    private void Awake()
    {
        Instance = this;
        JulyThumb = TanGenuUSA.instance.WideSpan.base_config.ball_limit;
        ViabilityIt = TanGenuUSA.instance.WideSpan.base_config.multiball_cd;
        PolluteRiceElk = AkinSpanThinker.BisFew(CChisel.Ox_Beach_July_Tie);
    }

    private void Start()
    {
        TrolleySpan();
        StartCoroutine(nameof(OutwashCubanRice));
    }


    public bool DireRice()
    {
        PolluteRiceElk = AkinSpanThinker.BisFew(CChisel.Ox_Beach_July_Tie);
        if (PolluteRiceElk <1)
        {
            PatentBraceThinker.Instance.FirnBoonFecundSkill();
            return false;
        }

        PolluteRiceElk--;
        TrolleySpan();
        return true;
    }

    public bool DireGillMawChair()//审核用的 
    {
        PolluteRiceElk = AkinSpanThinker.BisFew(CChisel.Ox_Beach_July_Tie);
        if (PolluteRiceElk < 1)
        {
            PatentBraceThinker.Instance.FirnBoonCordGillSkill();
            return false;
        }
        PolluteRiceElk--;
        WideSpanThinker.BisFeedback().AshcanBallAtlantic();
        TrolleySpan();
        return true;
    }


    public void BisCubanRice()
    {
        PolluteRiceElk = TanGenuUSA.instance.WideSpan.base_config.ball_limit;
        StopCoroutine(nameof(OutwashCubanRiceTilt));
        AxTilt = "";
        // WideSkill.Instance.cdText.text = cdTime;
        TrolleySpan();
    }


    private void TrolleySpan()
    {
        //Debug.Log("currentBallNum"+ currentBallNum);
        AkinSpanThinker.GapFew(CChisel.Ox_Beach_July_Tie, PolluteRiceElk);
        WideSpanThinker.BisFeedback().BisRice(PolluteRiceElk);
        WideSkill.Instance.JulyElkLoss.text = PolluteRiceElk + "";
        WideSkill.Instance.AmenableElkLoss.text = PolluteRiceElk + "";
        // WideSkill.Instance.cdText.text = cdTime;
    }



    IEnumerator OutwashCubanRice()
    {
        while (PolluteRiceElk > -10)
        {
            if (PolluteRiceElk < JulyThumb)
            {
                string time = AkinSpanThinker.BisAttest(CChisel.Ox_Beach_July_Rain);
                if (time.Length == 0)
                {
                    AkinSpanThinker.GapAttest(CChisel.Ox_Beach_July_Rain, DateTime.Now.ToString());
                    StopCoroutine(nameof(OutwashCubanRiceTilt));
                    StartCoroutine(nameof(OutwashCubanRiceTilt));
                }
                else
                {
                    int timenow = BisIndigoSpan.BisFeedback().AlpDrawReal(time, DateTime.Now);
                    int a = (int) ( timenow / ViabilityIt);
                    if (a >= 1)
                    {
                        PolluteRiceElk += a;
                  
                        AkinSpanThinker.GapAttest(CChisel.Ox_Beach_July_Rain, DateTime.Now.ToString());
                        if (PolluteRiceElk < JulyThumb)
                        {
                            WideSpanThinker.BisFeedback().BisRice(a);
                            StopCoroutine(nameof(OutwashCubanRiceTilt));
                            StartCoroutine(nameof(OutwashCubanRiceTilt));
                        }
                        else
                        {
                            WideSpanThinker.BisFeedback().BisRice((int)(PolluteRiceElk-JulyThumb));
                            PolluteRiceElk = (int) JulyThumb;
                            StopCoroutine(nameof(OutwashCubanRiceTilt));
                            AxTilt = "";
                            // WideSkill.Instance.cdText.text = cdTime;
                        }
                    }
                    else
                    {
                        if (AxTilt == "")
                        {
                            StopCoroutine(nameof(OutwashCubanRiceTilt));
                            StartCoroutine(nameof(OutwashCubanRiceTilt));
                        }
                    }
                }

                TrolleySpan();
            }

            yield return new WaitForSeconds((float) 0.05);
        }
    }

    IEnumerator OutwashCubanRiceTilt()
    {
        for (int i = (int) ViabilityIt; i > 0; i--)
        {
            AxTilt = i + "s";
            // WideSkill.Instance.cdText.text = cdTime;
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator SteppeCubanRiceBore()
    {
        // yield return new WaitForSeconds((float) multiballCd);
        yield return new WaitForSeconds(0.5f);
        BeachRiceBore = false;
    }
}