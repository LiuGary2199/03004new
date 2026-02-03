using UnityEngine;
using UnityEngine.UI;

public class ATimerItem_A : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mCompleted")]    public GameObject mBroadcast;
[UnityEngine.Serialization.FormerlySerializedAs("mReady")]    public GameObject mVital;
[UnityEngine.Serialization.FormerlySerializedAs("mIncomplete")]    public GameObject mMonogamous;
[UnityEngine.Serialization.FormerlySerializedAs("BtnReady")]    public Button DigVital;
[UnityEngine.Serialization.FormerlySerializedAs("TimerText")]    public Text VaguePlow; // 显示倒计时文本（如 "05:00"）
    
    private int _GourdIt= -1;
    private int _Baseball; // 分钟数
    private ATimerStatus_A _Flower;
    
    public ATimerStatus_A Sawyer    {
        get => _Flower;
        set
        {
            if (_Flower == value)
                return;
                
            _Flower = value;
            DefendSawyerUI();
        }
    }
    
    private void Awake()
    {
        if (DigVital != null)
        {
            DigVital.onClick.AddListener(OnClaimReward);
        }

    }
    
    /// <summary>
    /// 更新计时器数据
    /// </summary>
    public void DefendVagueCite(int timerId, int duration, ATimerStatus_A status, int remainingSeconds)
    {
        _GourdIt = timerId;
        _Baseball = duration;
        Sawyer = status;
        
        // 更新倒计时文本
        DefendVaguePlow(remainingSeconds);
        DefendSawyerUI();
    }
    
    /// <summary>
    /// 更新倒计时文本
    /// </summary>
    private void DefendVaguePlow(int remainingSeconds)
    {
        if (VaguePlow == null)
            return;
            
        if (_Flower == ATimerStatus_A.Ready)
        {
            // 可领取状态，显示 "GET" 或类似文本
            VaguePlow.text = "GET";
        }
        else if (_Flower == ATimerStatus_A.Completed)
        {
            // 已领取状态
            VaguePlow.text = "00:00";
        }
        else
        {
            // 倒计时中，显示剩余时间 MM:SS
            int minutes = remainingSeconds / 60;
            int seconds = remainingSeconds % 60;
            VaguePlow.text = $"{minutes:D2}:{seconds:D2}";
        }
    }
    
    /// <summary>
    /// 更新状态UI显示
    /// </summary>
    private void DefendSawyerUI()
    {
        if (mBroadcast != null)
            mBroadcast.SetActive(_Flower == ATimerStatus_A.Completed);
        if (mVital != null)
            mVital.SetActive(_Flower == ATimerStatus_A.Ready);
        if (mMonogamous != null)
            mMonogamous.SetActive(_Flower == ATimerStatus_A.Incomplete);
        
        // 只有Ready状态时按钮可点击
        if (DigVital != null)
            DigVital.interactable = (_Flower == ATimerStatus_A.Ready);
    }
    
    /// <summary>
    /// 领取奖励
    /// </summary>
    private void OnClaimReward()
    {
        if (_GourdIt < 0)
            return;
        
        // 双重检查：先检查本地状态，再检查数据源状态
        if (_Flower != ATimerStatus_A.Ready)
            return;
        
        // 从数据源再次确认状态，防止状态不同步
        ATimerStatus_A serverStatus = WideSpanThinker.BisFeedback().WedEssayLimner(_GourdIt);
        if (serverStatus != ATimerStatus_A.Ready)
        {
            // 状态不一致，更新本地状态
            Sawyer = serverStatus;
            return;
        }
        
        // 领取奖励（调用正确的方法）
        WideSkill.Instance.BisChop(1000);
        
        // 更新状态为已领取
        WideSpanThinker.BisFeedback().MayEssayLimner(_GourdIt, ATimerStatus_A.Completed);
        Sawyer = ATimerStatus_A.Completed;
        
        // 启动下一个计时器（如果还有下一个计时任务）
        int nextTimerId = _GourdIt + 1;
        // 检查是否还有下一个计时器（通过检查下一个计时器的时长是否存在）
        int nextDuration = WideSpanThinker.BisFeedback().WedEssayStrength(nextTimerId);
        if (nextDuration > 0) // 如果下一个计时器存在
        {
            // 检查下一个计时器是否已启动
            float nextStartTime = WideSpanThinker.BisFeedback().WedEssayLayerFile(nextTimerId);
            if (nextStartTime < 0) // 如果下一个未启动
            {
                // 启动下一个计时器
                WideSpanThinker.BisFeedback().LayerEssay(nextTimerId);
            }
        }
        
        Debug.Log($"计时器 {_GourdIt} 领取成功，获得 {WideSpanThinker.BisFeedback().WedEssayKorean()} 金币");
        DefendSawyerUI();
    }
}

public enum ATimerStatus_A
{
    Incomplete,  // 倒计时中
    Ready,       // 可领取
    Completed,   // 已领取
}
