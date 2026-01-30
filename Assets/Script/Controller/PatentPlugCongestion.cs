// Project: Plinko
// FileName: PatentPlugCongestion.cs
// Author: AX
// CreateDate: 20230515
// CreateTime: 16:03
// Description:

using UnityEngine;
using System;
using UnityEngine.UI;


public class PatentPlugCongestion : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    [UnityEngine.Serialization.FormerlySerializedAs("TireCreep")]public GameObject BitePhase;

    private GameObject AncestorAffixPiston;
    private float EarnAuger= 130f; // 两个item的position.x之差

    void Start()
    {
        AncestorAffixPiston = BitePhase.transform.Find("SlotCard_1").gameObject;
        float x= EarnAuger * 3;
        int multiCount = TanGenuUSA.instance.BiteSpan.RewardMultiList.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(AncestorAffixPiston, BitePhase.transform);
                fangkuai.transform.localPosition = new Vector3(x + EarnAuger * multiCount * i + EarnAuger * j,
                    AncestorAffixPiston.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text =
                    "×" + TanGenuUSA.instance.BiteSpan.RewardMultiList[j].multi;
            }
        }
    }

    public void BiteAffix()
    {
        BitePhase.GetComponent<RectTransform>().localPosition = new Vector3(0, 6.6f, 0);
    }

    public void AmidPlug(int index, Action<int> finish)
    {
        GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.sound_bigwin1_wheel);
        ExemplifyCongestion.UnforeseenExpose(BitePhase,
            -(EarnAuger * 2 + EarnAuger * TanGenuUSA.instance.BiteSpan.RewardMultiList.Count * 3 + EarnAuger * (index + 1)),
            () => { finish?.Invoke(TanGenuUSA.instance.BiteSpan.RewardMultiList[index].multi); });
    }

}