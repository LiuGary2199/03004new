using System;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class LavishUser : FirmUICharm
{
    public static LavishUser Instance;
[UnityEngine.Serialization.FormerlySerializedAs("rewardText")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraCent")]    public Text TurtleLoss;

   
    public override void Display()
    {
        base.Display();
    }

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    private void Start()
    {
    }
    public void IsBiteSpan(double num)
    {
        TurtleLoss.text = num.ToString();
    }
    public void BiteSpan(double num)
    {
        TurtleLoss.text = num.ToString();
    }
    public override void Hidding()
    {
        base.Hidding();
    }
}