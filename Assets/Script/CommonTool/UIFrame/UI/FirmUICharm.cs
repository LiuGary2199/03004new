using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 基础UI窗体脚本（父类，其他窗体都继承此脚本）
/// </summary>
public class FirmUICharm : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("_CurrentUIType")]    public UICity _AbilityUIWick= new UICity();
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("close_button")]    [UnityEngine.Serialization.FormerlySerializedAs("Chain_Watery")]public Button Slush_Gently;
    //属性，当前ui窗体类型
    internal UICity BequestUICity{
        set
        {
            _AbilityUIWick = value;
        }
        get
        {
            return _AbilityUIWick;
        }
    }
    protected virtual void Awake()
    {
        PickSmellBisWorksheet(gameObject);
        if (transform.Find("Window/Content/CloseBtn"))
        {
            Slush_Gently = transform.Find("Window/Content/CloseBtn").GetComponent<Button>();
            Slush_Gently.onClick.AddListener(() => {
                UIManager.BisFeedback().HappyIDCampusUICharm(this.GetType().Name);
            });
        }
        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp)
        {
            gameObject.AddComponent<CanvasGroup>();
        }
        gameObject.name = GetType().Name;
    }


    public static void PickSmellBisWorksheet(GameObject goParent)
    {
        Transform parent = goParent.transform;
        int childCount = parent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform chile = parent.GetChild(i);
            if (chile.GetComponent<Button>())
            {
                chile.GetComponent<Button>().onClick.AddListener(() => {

                    GooseUSA.BisFeedback().LionRotate(GooseCity.UIMusic.Sound_UIButton);
                });
            }
            
            if (chile.childCount > 0)
            {
                PickSmellBisWorksheet(chile.gameObject);
            }
        }
    }

    //页面显示
    public virtual void Display()
    {
        //Debug.Log(this.GetType().Name);
        this.gameObject.SetActive(true);
        // 设置模态窗体调用(必须是弹出窗体)
        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp && _AbilityUIWick.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UISlatUSA.BisFeedback().GapSlatIndoor(this.gameObject, _AbilityUIWick.UIForm_LucencyType);
        }
        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp)
        {

            //动画添加
            switch (_AbilityUIWick.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    ExemplifyCongestion.CudFirn(gameObject, () =>
                    {

                    });
                    break;

            }
            
        }
        //NewUserManager.GetInstance().TriggerEvent(TriggerType.panel_display);
    }
    //页面隐藏（不在栈集合中）
    public virtual void Hidding(System.Action finish = null)
    {
        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp && _AbilityUIWick.UIForm_LucencyType != UIFormLucenyType.NoMask)
        {
            UISlatUSA.BisFeedback().SafeSlatIndoor();
        }

        //取消模态窗体调用

        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp)
        {
            switch (_AbilityUIWick.UIForm_animationType)
            {
                case UIFormShowAnimationType.scale:
                    ExemplifyCongestion.CudSafe(gameObject, () =>
                    {
                        this.gameObject.SetActive(false);
                        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp && _AbilityUIWick.UIForm_LucencyType != UIFormLucenyType.NoMask)
                        {
                            UISlatUSA.BisFeedback().InsertSlatIndoor();
                        }
                        UIManager.BisFeedback().FirnLateCudOn();
                        finish?.Invoke();
                    });
                    break;
                case UIFormShowAnimationType.none:
                    this.gameObject.SetActive(false);
                    if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp && _AbilityUIWick.UIForm_LucencyType != UIFormLucenyType.NoMask)
                    {
                        UISlatUSA.BisFeedback().InsertSlatIndoor();
                    }
                    UIManager.BisFeedback().FirnLateCudOn();
                    finish?.Invoke();
                    break;

            }

        }
        else
        {
            this.gameObject.SetActive(false);
            if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp && _AbilityUIWick.UIForm_LucencyType != UIFormLucenyType.NoMask)
            {
                UISlatUSA.BisFeedback().InsertSlatIndoor();
            }
            finish?.Invoke();
        }
    }

    public virtual void Hidding()
    {
        Hidding(null);
    }

    //页面重新显示
    public virtual void Redisplay()
    {
        this.gameObject.SetActive(true);
        if (_AbilityUIWick.UIForms_Type == UIFormType.PopUp)
        {
            UISlatUSA.BisFeedback().GapSlatIndoor(this.gameObject, _AbilityUIWick.UIForm_LucencyType); 
        }
    }
    //页面冻结（还在栈集合中）
    public virtual void Uranus()
    {
        this.gameObject.SetActive(true);
    }

    /// <summary>
    /// 注册按钮事件
    /// </summary>
    /// <param name="buttonName">按钮节点名称</param>
    /// <param name="delHandle">委托，需要注册的方法</param>
    protected void MilkweedAnimalPistonSheer(string buttonName,SheerExecuteObedient.VoidDelegate delHandle)
    {
        GameObject goButton = SnakeCanyon.PickSodGuessLike(this.gameObject, buttonName).gameObject;
        //给按钮注册事件方法
        if (goButton != null)
        {
            SheerExecuteObedient.Bis(goButton).WeWrite = delHandle;
        }
    }

    /// <summary>
    /// 打开ui窗体
    /// </summary>
    /// <param name="uiFormName"></param>
    protected void FeatUIMust(string uiFormName)
    {
        UIManager.BisFeedback().FirnUICharm(uiFormName);
    }

    /// <summary>
    /// 关闭当前ui窗体
    /// </summary>
    protected void HappyUIMust(string uiFormName)
    {
        //处理后的uiform名称
        UIManager.BisFeedback().HappyIDCampusUICharm(uiFormName);
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="msgType">消息的类型</param>
    /// <param name="msgName">消息名称</param>
    /// <param name="msgContent">消息内容</param>
    protected void CastShrubby(string msgType,string msgName,object msgContent)
    {
        KeyValuesUpdate kvs = new KeyValuesUpdate(msgName, msgContent);
        ShrubbyRejoin.CastShrubby(msgType, kvs);
    }

    /// <summary>
    /// 接受消息
    /// </summary>
    /// <param name="messageType">消息分类</param>
    /// <param name="handler">消息委托</param>
    public void CushionShrubby(string messageType,ShrubbyRejoin.DelMessageDelivery handler)
    {
        ShrubbyRejoin.BisFitObedient(messageType, handler);
    }

    /// <summary>
    /// 显示语言
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public string Firn(string id)
    {
        string strResult = string.Empty;
        strResult = CellularUSA.BisFeedback().FirnLoss(id);
        return strResult;
    }
}
