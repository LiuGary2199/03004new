using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersusSlat : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerGel")]public GameObject CinemaWok;
[UnityEngine.Serialization.FormerlySerializedAs("CurrentRadius")]
[UnityEngine.Serialization.FormerlySerializedAs("CurrentAttack")]    public float AbilityFreeze;
[UnityEngine.Serialization.FormerlySerializedAs("TargetRadius")]    [UnityEngine.Serialization.FormerlySerializedAs("RavageAttack")]public float FilterFreeze;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    [UnityEngine.Serialization.FormerlySerializedAs("RubbleFast")]public float InsertTilt= 0f;

    private Material Forecast;


    private UnfairlySheerPrinciple RoyalPrinciple;


    private void Start()
    {
        Vector3 targetPos = CinemaWok.transform.localPosition * 0.7f;
        Vector4 centerMat = new Vector4(targetPos.x, targetPos.y, 0, 0);
        Forecast = GetComponent<Image>().material;
        Forecast.SetVector("_Center", centerMat);


        RoyalPrinciple = GetComponent<UnfairlySheerPrinciple>();
        if (RoyalPrinciple != null)
        {
            RoyalPrinciple.GapFilterSword(CinemaWok.gameObject.GetComponent<Image>());
        }
    }


    /// <summary>
    /// 收缩速度
    /// </summary>
    private float InsertLoyalist= 0f;

    private void Update()
    {
        float value = Mathf.SmoothDamp(AbilityFreeze, FilterFreeze, ref InsertLoyalist, InsertTilt);
        if (!Mathf.Approximately(value, AbilityFreeze))
        {
            AbilityFreeze = value;
            Forecast.SetFloat("_Slider", AbilityFreeze);
        }
    }
}