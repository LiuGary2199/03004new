// Project: Pusher
// FileName: ButteThinker.cs
// Author: AX
// CreateDate: 20230823
// CreateTime: 14:33
// Description:

using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ButteThinker : MonoBehaviour
{
    public static ButteThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("skillWall")]
[UnityEngine.Serialization.FormerlySerializedAs("DraftLake")]    public GameObject PerryAcid;
[UnityEngine.Serialization.FormerlySerializedAs("skillLong")]    [UnityEngine.Serialization.FormerlySerializedAs("DraftFall")]public GameObject PerryEase;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    [UnityEngine.Serialization.FormerlySerializedAs("PestGel")]public GameObject SaltWok;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinObj")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapKindGel")]public GameObject DeedGillWok;
[UnityEngine.Serialization.FormerlySerializedAs("skillLongText")]
[UnityEngine.Serialization.FormerlySerializedAs("DraftFallCent")]    public Text PerryEaseLoss;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallText")]    [UnityEngine.Serialization.FormerlySerializedAs("DraftLakeCent")]public Text PerryAcidLoss;
[UnityEngine.Serialization.FormerlySerializedAs("slotNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("PestBedCent")]public Text SaltElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("cashCoinNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapKindBedCent")]public Text DeedGillElkLoss;


    private int PerryAcidTilt;
    private int PerryEaseTilt;
    private int DeedGillTilt;

    private bool SaltSpew;


    private void Awake()
    {
        Instance = this;
        PerryAcidTilt = 0;
        PerryEaseTilt = 0;
        DeedGillTilt = 0;
        SaltSpew = false;
    }


    private void FirnButteEaseEnd()
    {
        PerryEase.transform.DOLocalMoveX(-450, 0.5f);
    }

    private void HappyButteEaseEnd()
    {
        PerryEase.transform.DOLocalMoveX(-725, 0.5f);
        StopCoroutine(nameof(ButteEaseSmell));
    }

    private void FirnButteAcidEnd()
    {
        PerryAcid.transform.DOLocalMoveX(450, 0.5f);
    }

    private void HappyButteAcidEnd()
    {
        PerryAcid.transform.DOLocalMoveX(725, 0.5f);
        StopCoroutine(nameof(ButteAcidSmell));
    }

    public void ReuseButteEase(bool flag, int time)
    {
        if (flag)
        {
            FirnButteEaseEnd();
            PerryEaseTilt = 0;
        }

        PerryEaseTilt += time;
        StopCoroutine(nameof(ButteEaseSmell));
        StartCoroutine(nameof(ButteEaseSmell));
    }

    public void ReuseButteAcid(bool flag, int time)
    {
        if (flag)
        {
            FirnButteAcidEnd();
            PerryAcidTilt = 0;
        }

        PerryAcidTilt += time;
        StopCoroutine(nameof(ButteAcidSmell));
        StartCoroutine(nameof(ButteAcidSmell));
    }


    public void FirnPlugElk(bool flag,int num)
    {
        SaltElkLoss.text = num + "";
        if (flag)
        {
            if (SaltSpew) return;
            SaltSpew = true;
            SaltWok.transform.DOLocalMoveX(-450, 0.5f);
        }
        else
        {
            SaltSpew = false;
            SaltElkLoss.text = num +"";
            SaltWok.transform.DOLocalMoveX(-725, 0.5f);
        }

    }
    
    

    public void FirnBillGillElk(bool flag, int num)
    {
        DeedGillElkLoss.text = num + "";
        if (flag)
        {
            DeedGillWok.transform.DOLocalMoveX(450, 0.5f);
        }

        if (num == 1)
        {
            DeedGillElkLoss.text = "0";
            DeedGillWok.transform.DOLocalMoveX(725, 0.5f).SetDelay(1f);
        }
        
    }


    IEnumerator ButteEaseSmell()
    {
        while (PerryEaseTilt > 0)
        {
            PerryEaseTilt--;
            PerryEaseLoss.text = PerryEaseTilt + "";

            if (PerryEaseTilt == 0)
            {
                HappyButteEaseEnd();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator ButteAcidSmell()
    {
        while (PerryAcidTilt > 0)
        {
            PerryAcidTilt--;
            PerryAcidLoss.text = PerryAcidTilt + "";
            if (PerryAcidTilt == 0)
            {
                HappyButteAcidEnd();
            }

            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator BillGillSmell()
    {
        while (PerryAcidTilt > 0)
        {
            PerryAcidTilt--;

            if (PerryAcidTilt == 0)
            {
                HappyButteAcidEnd();
            }

            yield return new WaitForSeconds(1);
        }
    }
}