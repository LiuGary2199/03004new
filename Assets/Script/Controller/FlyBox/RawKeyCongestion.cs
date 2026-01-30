// Project: HappyBingo
// FileName: RawKeyCongestion.cs
// Author: AX
// CreateDate: 20221124
// CreateTime: 11:39
// Description:

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawKeyCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("flyBox")]    [UnityEngine.Serialization.FormerlySerializedAs("AllPeg")]public GameObject GemKey;

    private int _BindImperial;

    private int _PolluteTilt;
[UnityEngine.Serialization.FormerlySerializedAs("isOnFlag")]
[UnityEngine.Serialization.FormerlySerializedAs("WeHeMust")]    public bool ToItSpew;

    private Dictionary<NormalRewardType, double> TurtleOil;

    public static RawKeyCongestion Instance;


    private void Awake()
    {
        Instance = this;
        _BindImperial = TanGenuUSA.instance.WideSpan.base_config.bubble_time;
    }

    IEnumerator KeyTiltImperial()
    {
        while (ToItSpew)
        {
            if (_PolluteTilt >= _BindImperial)
            {
                _PolluteTilt = 0;
                WinnerRawKey();
            }

            _PolluteTilt++;
            //print(_currentTime);
            yield return new WaitForSeconds(1);
        }
    }


    public void LoderAndReuseKey()
    {
        ToItSpew = true;
        _PolluteTilt = 0;
        StartCoroutine(KeyTiltImperial());
        WinnerRawKey();
    }

    public void RimeKey()
    {
        if (!gameObject.activeInHierarchy) return;
        ToItSpew = false;
        StopCoroutine(KeyTiltImperial());
        if (transform.childCount > 0)
        {
            transform.gameObject.SetActive(false);
        }
    }

    public void GapKeyWhyChorus()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<RawElliot>().GapWhyChorus();
        }
    }

    public void GapKeyWhyNucleic()
    {
        if (transform.childCount > 0)
        {
            transform.GetChild(0).GetComponent<RawElliot>().GapWhyNucleic();
        }
    }

    public void ImpulseKey()
    {
        gameObject.SetActive(true);
        if (gameObject.activeInHierarchy)
        {
            ToItSpew = true;
            StartCoroutine(KeyTiltImperial());
            if (transform.childCount > 0)
            {
                transform.GetChild(0).GetComponent<RawElliot>().RawEncase();
                transform.GetChild(0).GetComponent<Canvas>().sortingOrder = 120;
                transform.gameObject.SetActive(true);
            }
        }
    }

    public void WinnerRawKey()
    {
        if (BurrowLift.ItChair()) return;
        if (AkinSpanThinker.BisAttest(CChisel.Ox_Alter_Ice_Ant) == "new") return;
        GameObject obj = Instantiate(GemKey, transform);
        obj.transform.SetParent(gameObject.transform);
        obj.SetActive(true);
    }

    public void StaveSpan()
    {
        ToItSpew = false;
        _PolluteTilt = 0;
        if (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    public void FirnServeSkill()
    {
        VerbThinker.Instance.WideRime();

        TurtleOil = new Dictionary<NormalRewardType, double>();
        BubbleObjData bubbleObjData = GameUtil.GetBubbleObjData();
        
        string type = bubbleObjData.BubbleObjType.ToString();
        NormalRewardType TurtleCity= (NormalRewardType) Enum.Parse(typeof(NormalRewardType), type);
        TurtleOil.Add(TurtleCity, bubbleObjData.RewardNum);
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_No_No,"6");
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_News, "1013");
        FecundSkillThinker.Instance.FirnPatentFecundSkill(TurtleOil);

    }
}