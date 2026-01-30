// Project: Pusher
// FileName: FecundSkillThinker.cs
// Author: AX
// CreateDate: 20230809
// CreateTime: 17:33
// Description:

using System;
using System.Collections.Generic;
using UnityEngine;

public class FecundSkillThinker : MonoBehaviour
{
    public static FecundSkillThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    [UnityEngine.Serialization.FormerlySerializedAs("WeOnly")]public bool ToBore;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ToBore = false;

        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Slush_Aphid_Sap_Alter,
            (messageData) => { HappyBore(); });
    }


    private void HappyBore()
    {
        ToBore = false;
    }


    // show big win panel
    public void FirnMayFecundSkill(double num)
    {
        if (ToBore) return;

        ToBore = true;
        if (BurrowLift.ItChair())
        {
            return;
        }
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(MayAilServeSkill));
        MayAilServeSkill.Instance.BiteSpan(num);
    }

    // show normal win panel
    public void FirnPatentFecundSkill(Dictionary<NormalRewardType, double> rewardMap)
    {
        if (ToBore) return;
        ToBore = true;
        UIManager.BisFeedback().FirnUICharm(nameof(PatentAilServeSkill));
        PatentAilServeSkill.Instance.BiteSpan(rewardMap);
    }


    public void FirnBillGibeFecund()
    {
        VerbThinker.Instance.WideRime();
        Dictionary<NormalRewardType, double> TurtleOil= new Dictionary<NormalRewardType, double>();

        double num = GameUtil.GetCashRollReward();
        TurtleOil[NormalRewardType.RollCash] = num;
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_News, "1012");
        AkinSpanThinker.GapAttest(CChisel.Ox_Untrue_Tap_No_No,"5");
        FirnPatentFecundSkill(TurtleOil);
    }

}