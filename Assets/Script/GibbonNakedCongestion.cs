using System;
using DG.Tweening;
using UnityEngine;

public class GibbonNakedCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("posY")]    [UnityEngine.Serialization.FormerlySerializedAs("FarY")]public float FadY;
[UnityEngine.Serialization.FormerlySerializedAs("stoneRadius")]    [UnityEngine.Serialization.FormerlySerializedAs("RadarAttack")]public float ThingFreeze;
[UnityEngine.Serialization.FormerlySerializedAs("delayTime")]    [UnityEngine.Serialization.FormerlySerializedAs("TingeFast")]public float StaveTilt;
[UnityEngine.Serialization.FormerlySerializedAs("moveTime")]    [UnityEngine.Serialization.FormerlySerializedAs("TintFast")]public float DeckTilt;
[UnityEngine.Serialization.FormerlySerializedAs("movingFlog")]
[UnityEngine.Serialization.FormerlySerializedAs("IncomeRuin")]    public bool WithinRead;

    private Sequence WithinTax;

    private void Awake()
    {
        //delayTime = 2f;
    }

    private void Start()
    {
        transform.localPosition = new Vector3(-ThingFreeze, FadY, -1.314f);
        GibbonEnd();
    }

    public void RimeGibbon()
    {
        WithinRead = false;
        WithinTax.Pause();
    }

    public void OfReuseGibbon()
    {
        WithinRead = true;
        WithinTax.Play();
    }

    private void GibbonEnd()
    {
        WithinTax = DOTween.Sequence();
        WithinTax.Append(transform.DOLocalMoveX(ThingFreeze, DeckTilt).SetEase(Ease.InOutCubic));
        WithinTax.AppendInterval(StaveTilt);
        WithinTax.Append(transform.DOLocalMoveX(-ThingFreeze, DeckTilt).SetEase(Ease.InOutCubic));
        WithinTax.AppendInterval(StaveTilt);
        WithinTax.SetLoops(-1);
        WithinTax.Play();
    }



}