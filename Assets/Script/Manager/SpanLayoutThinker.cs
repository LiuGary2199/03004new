using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PusherRewardType
{
    CoinGold,
    CoinCash,
    RollCash,
    GemBlue,
    GemRed,
    GemDiamond,
    Golden,
    ScratchCard,
    LuckyCard,
    BigCoin
}

public enum SlotRewardType
{
    BigWin = 0,
    Cash1 = 1,
    Cash2 = 2,
    Cash3 = 3,
    SkillWall = 4,
    SkillBigCoin = 5,
    SkillLong = 6,
    GemBlue = 7,
    GemRed = 8,
    GemDiamond = 9,
    Golden = 10,
    Null = 11
}

public class SpanLayoutThinker : GistThickness<SpanLayoutThinker>
{
    /// <summary>
    /// 获得pusher掉落奖励
    /// </summary>
    /// <param name="item"></param>
    public void WokUpwardFecund(PusherRewardType type, double rewardNum)
    {
        switch (type)
        {
            case PusherRewardType.CoinCash:
                WideSkill.Instance.BisBill(rewardNum);
                break;
            case PusherRewardType.CoinGold:
                WideSkill.Instance.BisChop(rewardNum);
                break;
            case PusherRewardType.RollCash:
                FecundSkillThinker.Instance.FirnBillGibeFecund();
                break;
            case PusherRewardType.GemDiamond:
                WideSpanThinker.BisFeedback().BisPeg(GemsType.Silver);
                break;
            case PusherRewardType.GemBlue:
                WideSpanThinker.BisFeedback().BisPeg(GemsType.Blue);
                break;
            case PusherRewardType.GemRed:
                WideSpanThinker.BisFeedback().BisPeg(GemsType.Yellow);
                break;
            case PusherRewardType.Golden:
                WideSpanThinker.BisFeedback().BisPeg(GemsType.GoldBar);

                break;
            case PusherRewardType.ScratchCard:
                PatentBraceThinker.Instance.FirnHoweverJoinSkill();
                break;
            case PusherRewardType.LuckyCard:
                PatentBraceThinker.Instance.FirnCrownJoinSkill();
                break;
            case PusherRewardType.BigCoin:
                WideSkill.Instance.BisChop(1);
                break;
        }
    }

    /// <summary>
    /// 获取plinko格子创建金币的数量
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public int RoeShaperGillTrove(int index)
    {
        return GameUtil.GetBoxNum();
    }

    /// <summary>
    /// 获取自动掉落物体类型
    /// </summary>
    /// <returns></returns>
    public PusherRewardType RoeSendDireAtCity()
    {
        int typeIndex = Random.Range(0, 3);
        PusherRewardType type = PusherRewardType.RollCash;
        switch (typeIndex)
        {
            case 0:
                type = PusherRewardType.RollCash;
                break;
            case 1:
                type = PusherRewardType.ScratchCard;
                break;
            case 2:
                type = PusherRewardType.LuckyCard;
                break;
        }

        return type;
    }

    /// <summary>
    /// 获取slot中奖项(从此函数中调用slot动画)
    /// </summary>
    public void RoePlugFecundSpan(System.Action<SlotRewardType> rewardAction)
    {
        SlotRewardType slotRewardType = GameUtil.GetSlotObjData();
        if (BurrowLift.ItChair())
        {
            while (slotRewardType == SlotRewardType.Null && RatCruelTiltThinker.Instance.ToCruelTilt)
            {
                slotRewardType = GameUtil.GetSlotObjData();
            }
        }
        else
        {
            while (slotRewardType == SlotRewardType.Null && CruelTiltThinker.Instance.ToCruelTilt)
            {
                slotRewardType = GameUtil.GetSlotObjData();
            }
        }
        rewardAction(slotRewardType);
    }

    /// <summary>
    /// 墙技能触发
    /// </summary>
    /// <param name="needShow">是否需要UI滑出动画,如果为false则只需要增加显示时长</param>
    /// <param name="time">单次增加的时长</param>
    public void YaleButteAcidTilt(bool needShow, int time)
    {
        ButteThinker.Instance.ReuseButteAcid(needShow,time);
    }

    /// <summary>
    /// 加长技能触发
    /// </summary>
    /// <param name="needShow">是否需要UI滑出动画,如果为false则只需要增加显示时长</param>
    /// <param name="time">单次增加的时长</param>
    public void YaleButteEaseTilt(bool needShow, int time)
    {
        ButteThinker.Instance.ReuseButteEase(needShow,time);
    }
    /// <summary>
    /// 刷新剩余未掉落绿币显示个数
    /// </summary>
    public void YaleDireBillGillTrove(bool needShow, int count)
    {
        ButteThinker.Instance.FirnBillGillElk(needShow,count);
    }

    /// <summary>
    /// 777结束
    /// </summary>
    public void TanAilHue()
    {

    }
    /// <summary>
    /// fever结束
    /// </summary>
    public void TenthFew()
    {

    }

    /// <summary>
    /// 获取金币面额
    /// </summary>
    /// <returns></returns>
    public int RoeChopGillElk()
    {
        double coinValues = GameUtil.GetPusherGoldReward();
        return int.Parse(coinValues.ToString());
    }

    /// <summary>
    /// 获取绿币面额
    /// </summary>
    /// <returns></returns>
    public int RoeBillGillElk()
    {
        double coinValues = GameUtil.GetPusherCashReward();
        return int.Parse(coinValues.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}