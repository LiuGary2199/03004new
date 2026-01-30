// Project: Pusher
// FileName: PatentBraceThinker.cs
// Author: AX
// CreateDate: 20230821
// CreateTime: 9:30
// Description:

using System;
using UnityEngine;

public class PatentBraceThinker : MonoBehaviour
{
    public static PatentBraceThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isLock")]    [UnityEngine.Serialization.FormerlySerializedAs("WeOnly")]public bool ToBore;


    protected void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ToBore = false;

        // ShrubbyRejoinFleet.GetInstance().Register(CChisel.msg_close_panel_and_start,
        //     (messageData) => { CloseLock(); });
    }


    /*
     *
     * 各类弹窗
     */
    public void FirnCrownJoinSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        SelfSheerRibbon.BisFeedback().CastSheer("1010");
        AkinSpanThinker.GapFew(CChisel.Ox_To_Buggy_Tie, AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie) + 1);
        UIManager.BisFeedback().FirnUICharm(nameof(CrownJoinSkill));
    }

    public void FirnHoweverJoinSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        SelfSheerRibbon.BisFeedback().CastSheer("1008");
        AkinSpanThinker.GapFew(CChisel.Ox_To_Buggy_Tie, AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie) + 1);
        UIManager.BisFeedback().FirnUICharm(nameof(HoweverJoinSkill));
    }

    public void FirnGrandmaRiderSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;

        if (DrawLift.Bequest() - AkinSpanThinker.BisFew("sv_show_gems_times") < 10)
        {
            return;
        }

        AkinSpanThinker.GapFew("sv_show_gems_times", (int) DrawLift.Bequest());

        ToBore = true;
        VerbThinker.Instance.WideRime();

        UIManager.BisFeedback().FirnUICharm(nameof(GrandmaRiderSkill));
    }

    public void FirnAttemptSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(AttemptSkill));
    }
    public void FirnRatAttemptSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(RatHuntAttemptSkill));
    }
    public void FirnBoonFecundSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(BoonFecundSkill));
    }
    public void FirnBoonCordGillSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(BoonDireGillSkill));
    }

    public void FirnBoonPlugSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(BoonPlugSkill));
    }
    
    public void FirnWarnUsSkill()
    {
        if (ToBore || VerbThinker.Instance.GlenBore) return;

        if (BurrowLift.ItChair())
        {
            return;
        }
        ToBore = true;
        VerbThinker.Instance.WideRime();
        UIManager.BisFeedback().FirnUICharm(nameof(WarnAnSkill));
     
    }

}