// Project: Plinko
// FileName: PlumDiscCongestion.cs
// Author: AX
// CreateDate: 20230526
// CreateTime: 15:19
// Description:

using System;
using DG.Tweening;
using UnityEngine;

    public class PlumDiscCongestion : MonoBehaviour
    {
[UnityEngine.Serialization.FormerlySerializedAs("handImg")]        [UnityEngine.Serialization.FormerlySerializedAs("HeelRed")]public GameObject ShopCod;

        private void Start()
        {
            ReusePloy();
        }

        private void ReusePloy()
        {
           Sequence  handSeq = DOTween.Sequence();
           handSeq.Append(ShopCod.transform.DOLocalMoveY(25f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.Append(ShopCod.transform.DOLocalMoveY(0f, 0.3f)).SetEase(Ease.InSine);;
           handSeq.SetLoops(-1);
           handSeq.Play();
        }

    }
