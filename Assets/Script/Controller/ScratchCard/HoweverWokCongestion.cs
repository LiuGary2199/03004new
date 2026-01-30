// Project: Plinko
// FileName: HoweverWokCongestion.cs
// Author: AX
// CreateDate: 20230522
// CreateTime: 10:13
// Description:

using System;
using UnityEngine;
using UnityEngine.UI;

public class HoweverWokCongestion : MonoBehaviour
{
    public static HoweverWokCongestion Instance;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]
[UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]    public GameObject DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("goldImg")]    [UnityEngine.Serialization.FormerlySerializedAs("SlowRed")]public GameObject BearCod;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRed")]public GameObject LegumeCod;
[UnityEngine.Serialization.FormerlySerializedAs("circleImg")]    [UnityEngine.Serialization.FormerlySerializedAs("WalnutRed")]public GameObject ExhaleCod;
[UnityEngine.Serialization.FormerlySerializedAs("mainNumText")]
[UnityEngine.Serialization.FormerlySerializedAs("LineBedCent")]    public Text TalkElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraBedCent")]public Text TurtleElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("mainNum")]
[UnityEngine.Serialization.FormerlySerializedAs("LineBed")]    public int TalkElk;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    [UnityEngine.Serialization.FormerlySerializedAs("SierraBed")]public double TurtleElk;
[UnityEngine.Serialization.FormerlySerializedAs("scratchObjData")]
[UnityEngine.Serialization.FormerlySerializedAs("GhostlyGelHall")]    public ScratchObjData BequestWokSpan;

    private void Awake()
    {
        Instance = this;
    }


    private void HappyCod()
    {
        BearCod.gameObject.SetActive(false);
        DeedCod.gameObject.SetActive(false);
        LegumeCod.gameObject.SetActive(false);
        ExhaleCod.gameObject.SetActive(false);
    }

    private void FirnCod()
    {
        switch (BequestWokSpan.ScratchObjType)
        {
            case ScratchObjType.Amazon:
                TurtleElk = BequestWokSpan.RewardNum * GameUtil.GetAmazonMulti();
                TurtleElkLoss.text = "" + TurtleElk;
                LegumeCod.gameObject.SetActive(true);
                break;
            case ScratchObjType.Cash:
                double cashNum = BequestWokSpan.RewardNum * GameUtil.GetCashMultiWithOutRandom();
                TurtleElk = Math.Round(cashNum, 2);
                TurtleElkLoss.text = "" + TurtleElk;
                DeedCod.gameObject.SetActive(true);
                break;
            default:
                TurtleElk = BequestWokSpan.RewardNum * GameUtil.GetGoldMulti();
                TurtleElkLoss.text = "" + TurtleElk;
                BearCod.gameObject.SetActive(true);
                break;
        }
        BequestWokSpan.RewardNum = TurtleElk;
    }

    public void FirnFilter()
    {
        // GooseUSA.GetInstance().PlayEffect(GooseCity.UIMusic.sound_scratch_reward);
        ExhaleCod.gameObject.SetActive(true);
        TalkElkLoss.color = new Color(1f, 1f, 0f);
    }

    public void BiteSpan(int num, bool isRewardNumber = false)
    {
        TalkElk = num;
        TalkElkLoss.text = num + "";
        TalkElkLoss.color = new Color(1f, 1f, 1f);
        if (isRewardNumber)
        {
            BequestWokSpan = GameUtil.GetScratchObjData();
        }
        else
        {
            int Trash= TanGenuUSA.instance.WideSpan.scratch_data_list.Count;
            ScratchDataItem item = TanGenuUSA.instance.WideSpan.scratch_data_list[UnityEngine.Random.Range(0, Trash)];
            BequestWokSpan = new ScratchObjData();
            BequestWokSpan.RewardNum = item.reward_num;
            BequestWokSpan.ScratchObjType = (ScratchObjType)Enum.Parse(typeof(ScratchObjType), item.type);
        }

        if (BurrowLift.ItChair())
        {
            BequestWokSpan.ScratchObjType = ScratchObjType.Gold;
        }

        HappyCod();
        FirnCod();
    }
}