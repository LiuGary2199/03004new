// Project: Plinko
// FileName: PlugThinker.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 11:26
// Description:

using System;
using System.Collections;
using System.IO;
using DG.Tweening;
using DG.Tweening.Plugins.Options;
using Lofelt.NiceVibrations;
using UnityEngine;

public class PlugThinker : MonoBehaviour
{
    public static PlugThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup01")]
[UnityEngine.Serialization.FormerlySerializedAs("PestCreep01")]    public GameObject SaltPhase01;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup02")]    [UnityEngine.Serialization.FormerlySerializedAs("PestCreep02")]public GameObject SaltPhase02;
[UnityEngine.Serialization.FormerlySerializedAs("slotGroup03")]    [UnityEngine.Serialization.FormerlySerializedAs("PestCreep03")]public GameObject SaltPhase03;
[UnityEngine.Serialization.FormerlySerializedAs("inLittleGame")]
[UnityEngine.Serialization.FormerlySerializedAs("NoLocaleUtah")]    public bool UpRatifyWide;

    private SlotRewardType SaltWokHall;

    private bool TulipSpew;
    private bool ToLash;

    private Sequence SaltTax;

    private void Awake()
    {
        Instance = this;
        TulipSpew = false;
        ToLash = false;
    }

    public void TrolleyPlugPhase()
    {
        SaltPhase01.transform.localPosition = new Vector3(-0.88f, 0, 0);
        SaltPhase02.transform.localPosition = new Vector3(0, 0, 0);
        SaltPhase03.transform.localPosition = new Vector3(0.88f, 0, 0);

        SaltPhase01.GetComponent<PlugWokPhaseCongestion>().TrolleySpan();
        SaltPhase02.GetComponent<PlugWokPhaseCongestion>().TrolleySpan();
        SaltPhase03.GetComponent<PlugWokPhaseCongestion>().TrolleySpan();
    }

    public void PlugRime()
    {
        ToLash = true;
        SaltPhase01.transform.DOPause();
        SaltPhase02.transform.DOPause();
        SaltPhase03.transform.DOPause();
    }

    public void PlugMyReuse()
    {
        ToLash = false;
        SaltPhase01.transform.DOPlay();
        SaltPhase02.transform.DOPlay();
        SaltPhase03.transform.DOPlay();
    }

    public void ReusePlug()
    {
        
        if (SaltWokHall == SlotRewardType.Null)
        {
            SlotRewardType slotObjData1 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            SlotRewardType slotObjData3 = GameUtil.GetSlotObjDataWithOutThanks();
            while (slotObjData1 == slotObjData2)
            {
                slotObjData2 = GameUtil.GetSlotObjDataWithOutThanks();
            }

            SaltPhase01.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(slotObjData1);
            SaltPhase02.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(slotObjData2);
            SaltPhase03.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(slotObjData3);
        }
        else
        {
            SaltPhase01.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(SaltWokHall);
            SaltPhase02.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(SaltWokHall);
            SaltPhase03.GetComponent<PlugWokPhaseCongestion>().WinnerFecundWok(SaltWokHall);
        }
        
    }

    private void GazeEnd(Action finish)
    {
        TulipSpew = true;
        StartCoroutine(nameof(LionPlugGoose));
        SaltPhase01.transform.DOLocalMoveY(-1f * 28,3f).OnComplete(() =>
        {
            //音效
            GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slotwheel_stop);
        });
        SaltPhase02.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.3f).OnComplete(() =>
        {
            //音效
            GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slotwheel_stop);
        });
        SaltPhase03.transform.DOLocalMoveY(-1f * 28, 3f).SetDelay(0.6f).OnComplete(() =>
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slotwheel_stop);

            StopCoroutine(nameof(LionPlugGoose));
            SaltPhase03.transform.DOScale(1f, 0f).SetDelay(1f).OnComplete(() =>
            {
                UpwardPlugKeyAstonish.Instance.ToPlugSpew = false;
                //音效
            
                TulipSpew = false;

                finish();
                TrolleyPlugPhase();
                if (SaltWokHall == SlotRewardType.Null)
                {
                    Invoke(nameof(FirnMutualSkill), 0.5f);
                }
                else
                {
                    VerbThinker.Instance.TastePlug();
                }
            });
        });
    }


    public void BisFlashyElk(SlotRewardType targetType)
    {

        // PlaySlot();
    }


    public void LionPlug(SlotRewardType targetType ,Action finish)
    {
        SaltWokHall = targetType;
        SelfSheerRibbon.BisFeedback().CastSheer("1003",SaltWokHall.ToString());
        TulipSpew = false;
        ReusePlug();
        GazeEnd(finish);
    }

    private void FirnMutualSkill()
    {
        if (!UpRatifyWide)
        {
            PatentBraceThinker.Instance.FirnBoonPlugSkill();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            // PlaySlot();
        }
    }


    IEnumerator LionPlugGoose()
    {
        while (TulipSpew)
        {
            if (!ToLash)
            {
                GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_slotwheel_rotate, 0.1f);
            }

            yield return new WaitForSeconds(0.1f);
        }
    }
    public void Start()
    {
        //根据分辨率不同修改slot位置
        //float x = -0.616f* Screen.height - 159;
        //gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, x);
    }
    public void HappyPlugBG()
    {
     this.gameObject.SetActive(false);
    }
}