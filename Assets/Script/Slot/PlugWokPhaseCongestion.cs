// Project: Plinko
// FileName: PlugWokPhaseCongestion.cs
// Author: AX
// CreateDate: 20230512
// CreateTime: 15:50
// Description:

using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

public class PlugWokPhaseCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("baseSlotObj")]    [UnityEngine.Serialization.FormerlySerializedAs("MayaCrabGel")]public GameObject HeroPlugWok;
[UnityEngine.Serialization.FormerlySerializedAs("slotObjList")]    [UnityEngine.Serialization.FormerlySerializedAs("PestGelGerm")]public List<GameObject> SaltWokThen;
[UnityEngine.Serialization.FormerlySerializedAs("rewardObjList")]
[UnityEngine.Serialization.FormerlySerializedAs("SierraGelGerm")]
    public List<SlotRewardType> TurtleWokThen;
    
    private int AlpAngry;
    private int TurtleAngry;


    private void Awake()
    {
        AlpAngry = 33;
        TurtleAngry = 30;
    }

    private void Start()
    {
        BiteSpan();
    }

    public void BiteSpan()
    {
        for (int i = 0; i < AlpAngry; i++)
        {
            GameObject objItem = Instantiate(HeroPlugWok, transform);
            Vector3 pos = new Vector3();
            pos.y = i - 2;
            objItem.transform.localPosition = pos;
            objItem.GetComponent<PlugWokCongestion>().BiteSpanMoment();
            SaltWokThen.Add(objItem);
        }
    }

    public void WinnerFecundWok(SlotRewardType rewardData)
    {

        
        for (int i = TurtleAngry; i < AlpAngry; i++)
        {
            GameObject objItem = SaltWokThen[i];

            if (i == TurtleAngry)
            {
                objItem.GetComponent<PlugWokCongestion>().BiteSpanAnSpan(rewardData);
            }
            else
            {
                objItem.GetComponent<PlugWokCongestion>().BiteSpanMoment();
            }
        }
        
        TurtleWokThen = new List<SlotRewardType>();
        for (int i = TurtleAngry-2; i < AlpAngry; i++)
        {
            GameObject objItem = SaltWokThen[i];
            SlotRewardType tempData = objItem.GetComponent<PlugWokCongestion>().SaltWokHall;
            TurtleWokThen.Add(tempData);
        }
        
    }

    public void TrolleySpan()
    {
        // ClearData();
        MyBite();
    }

    private void MyBite()
    {
        for (int i = 0; i < AlpAngry; i++)
        {
            GameObject objItem = SaltWokThen[i];
            if (i < 5)
            {
                SlotRewardType tarItem = TurtleWokThen[i];
                objItem.GetComponent<PlugWokCongestion>().BiteSpanAnSpan(tarItem);
            }
            else
            {
                objItem.GetComponent<PlugWokCongestion>().BiteSpanMoment();
            }
        }
    }

}