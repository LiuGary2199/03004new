/*
*
*   功能：整个UI框架的核心，用户程序通过调用本类，来调用本框架的大多数功能。  
*           功能1：关于入“栈”与出“栈”的UI窗体4个状态的定义逻辑
*                 入栈状态：
*                     Freeze();   （上一个UI窗体）冻结
*                     Display();  （本UI窗体）显示
*                 出栈状态： 
*                     Hiding();    (本UI窗体) 隐藏
*                     Redisplay(); (上一个UI窗体) 重新显示
*          功能2：增加“非栈”缓存集合。 
* 
* 
* ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// UI窗体管理器脚本（框架核心脚本）
/// 主要负责UI窗体的加载、缓存、以及对于“UI窗体基类”的各种生命周期的操作（显示、隐藏、重新显示、冻结）。
/// </summary>
public class UIManager : MonoBehaviour
{
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("MainCanvas")]    [UnityEngine.Serialization.FormerlySerializedAs("BeauChurch")]public Canvas VerbUsable;
    private static UIManager _Feedback= null;
    //ui窗体预设路径（参数1，窗体预设名称，2，表示窗体预设路径）
    private Dictionary<string, string> _HueCharmSpore;
    //缓存所有的ui窗体
    private Dictionary<string, FirmUICharm> _HueALLUICharm;
    //栈结构标识当前ui窗体的集合
    private Stack<FirmUICharm> _DigBequestUICharm;
    //当前显示的ui窗体
    private Dictionary<string, FirmUICharm> _HueBequestFirnUICharm;
    //临时关闭窗口
    private List<string> _RollUICharm;
    //ui根节点
    private Transform _CopUsableCognitive= null;
    //全屏幕显示的节点
    private Transform _CopPatent= null;
    //固定显示的节点
    private Transform _CopWaist= null;
    //弹出节点
    private Transform _CopCudOn= null;
    //ui特效节点
    private Transform _Fog= null;
    //ui管理脚本的节点
    private Transform _CopUIDoorway= null;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PanelName")]    [UnityEngine.Serialization.FormerlySerializedAs("ScoreClaw")]public string SkillBard;
    List<string> SkillBardThen;
    public List<string> RollUICharm{
        get
        {
            return _RollUICharm;
        }
    }
    //得到实例
    public static UIManager BisFeedback()
    {
        if (_Feedback == null)
        {
            _Feedback = new GameObject("_UIManager").AddComponent<UIManager>();
            
        }
        return _Feedback;
    }
    //初始化核心数据，加载ui窗体路径到集合中
    public void Awake()
    {
        SkillBardThen = new List<string>();
        //字段初始化
        _HueALLUICharm = new Dictionary<string, FirmUICharm>();
        _HueBequestFirnUICharm = new Dictionary<string, FirmUICharm>();
        _RollUICharm = new List<string>();
        _HueCharmSpore = new Dictionary<string, string>();
        _DigBequestUICharm = new Stack<FirmUICharm>();
        //初始化加载（根ui窗体）canvas预设
        BiteFleeUsableReaumur();
        //得到UI根节点，全屏节点，固定节点，弹出节点
        //Debug.Log("this.gameobject" + this.gameObject.name);
        _CopUsableCognitive = GameObject.FindGameObjectWithTag(SumModest.SYS_TAG_CANVAS).transform;
        _CopPatent = SnakeCanyon.PickSodGuessLike(_CopUsableCognitive.gameObject,SumModest.SYS_NORMAL_NODE);
        _CopWaist = SnakeCanyon.PickSodGuessLike(_CopUsableCognitive.gameObject, SumModest.SYS_FIXED_NODE);
        _CopCudOn = SnakeCanyon.PickSodGuessLike(_CopUsableCognitive.gameObject,SumModest.SYS_POPUP_NODE);
        _Fog = SnakeCanyon.PickSodGuessLike(_CopUsableCognitive.gameObject, SumModest.SYS_TOP_NODE);
        _CopUIDoorway = SnakeCanyon.PickSodGuessLike(_CopUsableCognitive.gameObject,SumModest.SYS_SCRIPTMANAGER_NODE);
        //把本脚本作为“根ui窗体”的子节点
        SnakeCanyon.BisSmellLikeMyAutumnLike(_CopUIDoorway, this.gameObject.transform);
        //根UI窗体在场景转换的时候，不允许销毁
        DontDestroyOnLoad(_CopUsableCognitive);
        //初始化ui窗体预设路径数据
        BiteUICharmSporeSpan();
    }
    private void BisSkill(string name)
    {
        if (!SkillBardThen.Contains(name))
        {
            SkillBardThen.Add(name);
            SkillBard = name;
        }
    }
    private void NutSkill(string name)
    {
        if (SkillBardThen.Contains(name))
        {
            SkillBardThen.Remove(name);
        }
        if (SkillBardThen.Count == 0)
        {
            SkillBard = "";
        }
        else
        {
            SkillBard = SkillBardThen[0];
        }
    }
    //初始化加载（根ui窗体）canvas预设
    private void BiteFleeUsableReaumur()
    {
        VerbUsable = EuphratesUSA.BisFeedback().WantQuiet(SumModest.SYS_PATH_CANVAS, false).GetComponent<Canvas>();
    }
    /// <summary>
    /// 显示ui窗体
    /// 功能：1根据ui窗体的名称，加载到所有ui窗体缓存集合中
    /// 2,根据不同的ui窗体的显示模式，分别做不同的加载处理
    /// </summary>
    /// <param name="uiFormName">ui窗体预设的名称</param>
    public GameObject FirnUICharm(string uiFormName)
    {
        //参数的检查
        if (string.IsNullOrEmpty(uiFormName)) return null;
        //根据ui窗体的名称，把加载到所有ui窗体缓存集合中
        //ui窗体的基类
        FirmUICharm baseUIForms = WantCharmMyALLUICharmWoody(uiFormName);
        if (baseUIForms == null) return null;

        BisSkill(uiFormName);
        
        //判断是否清空“栈”结构体集合
        if (baseUIForms.BequestUICity.ItRomanDepressSteppe)
        {
            StaveScrubReign();
        }
        //根据不同的ui窗体的显示模式，分别做不同的加载处理
        switch (baseUIForms.BequestUICity.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                CrackUICharmOcher(uiFormName);
                break;
            case UIFormShowMode.ReverseChange:
                PoleUICharm(uiFormName);
                break;
            case UIFormShowMode.HideOther:
                CrackUIFervorMyOcherSafeTooth(uiFormName);
                break;
            case UIFormShowMode.Wait:
                CrackUICharmOcherRollHappy(uiFormName);
                break;
            default:
                break;
        }
        return baseUIForms.gameObject;
    }

    /// <summary>
    /// 关闭或返回上一个ui窗体（关闭当前ui窗体）
    /// </summary>
    /// <param name="strUIFormsName"></param>
    public void HappyIDCampusUICharm(string strUIFormsName)
    {
        NutSkill(strUIFormsName);
        //Debug.Log("关闭窗体的名字是" + strUIFormsName);
        //ui窗体的基类
        FirmUICharm baseUIForms = null;
        if (string.IsNullOrEmpty(strUIFormsName)) return;
        _HueALLUICharm.TryGetValue(strUIFormsName,out baseUIForms);
        //所有窗体缓存中没有记录，则直接返回
        if (baseUIForms == null) return;
        //判断不同的窗体显示模式，分别处理
        switch (baseUIForms.BequestUICity.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                HoleUICharmOcher(strUIFormsName);
                break;
            
            case UIFormShowMode.ReverseChange:
                CudUICharm();
                break;
            case UIFormShowMode.HideOther:
                HoleUICharmWavyOcherDonFirnAward(strUIFormsName);
                break;
            case UIFormShowMode.Wait:
                HoleUICharmOcher(strUIFormsName);
                break;
            default:
                break;
        }
        
    }
    /// <summary>
    /// 显示下一个弹窗如果有的话
    /// </summary>
    public void FirnLateCudOn()
    {
        if (_RollUICharm.Count > 0)
        {
            FirnUICharm(_RollUICharm[0]);
            _RollUICharm.RemoveAt(0);
        }
    }

    /// <summary>
    /// 清空当前等待中的UI
    /// </summary>
    public void StaveRollUICharm()
    {
        if (_RollUICharm.Count > 0)
        {
            _RollUICharm = new List<string>();
        }
    }
     /// <summary>
     /// 根据UI窗体的名称，加载到“所有UI窗体”缓存集合中
      /// 功能： 检查“所有UI窗体”集合中，是否已经加载过，否则才加载。
      /// </summary>
      /// <param name="uiFormsName">UI窗体（预设）的名称</param>
      /// <returns></returns>
    private FirmUICharm WantCharmMyALLUICharmWoody(string uiFormName)
    {
        //加载的返回ui窗体基类
        FirmUICharm baseUIResult = null;
        _HueALLUICharm.TryGetValue(uiFormName, out baseUIResult);
        if (baseUIResult == null)
        {
            //加载指定名称ui窗体
            baseUIResult = WantUIMust(uiFormName);

        }
        return baseUIResult;
    }
    /// <summary>
    /// 加载指定名称的“UI窗体”
    /// 功能：
    ///    1：根据“UI窗体名称”，加载预设克隆体。
    ///    2：根据不同预设克隆体中带的脚本中不同的“位置信息”，加载到“根窗体”下不同的节点。
    ///    3：隐藏刚创建的UI克隆体。
    ///    4：把克隆体，加入到“所有UI窗体”（缓存）集合中。
    /// 
    /// </summary>
    /// <param name="uiFormName">UI窗体名称</param>
    private FirmUICharm WantUIMust(string uiFormName)
    {
        string strUIFormPaths = null;
        GameObject goCloneUIPrefabs = null;
        FirmUICharm baseUIForm = null;
        //根据ui窗体名称，得到对应的加载路径
        _HueCharmSpore.TryGetValue(uiFormName, out strUIFormPaths);
        if (!string.IsNullOrEmpty(strUIFormPaths))
        {
            //加载预制体
           goCloneUIPrefabs= EuphratesUSA.BisFeedback().WantQuiet(strUIFormPaths, false);
        }
        //设置ui克隆体的父节点（根据克隆体中带的脚本中不同的信息位置信息）
        if(_CopUsableCognitive!=null && goCloneUIPrefabs != null)
        {
            baseUIForm = goCloneUIPrefabs.GetComponent<FirmUICharm>();
            if (baseUIForm == null)
            {
                Debug.Log("baseUiForm==null! ,请先确认窗体预设对象上是否加载了baseUIForm的子类脚本！ 参数 uiFormName="+uiFormName);
                return null;
            }
            switch (baseUIForm.BequestUICity.UIForms_Type)
            {
                case UIFormType.Normal:
                    goCloneUIPrefabs.transform.SetParent(_CopPatent, false);
                    break;
                case UIFormType.Fixed:
                    goCloneUIPrefabs.transform.SetParent(_CopWaist, false);
                    break;
                case UIFormType.PopUp:
                    goCloneUIPrefabs.transform.SetParent(_CopCudOn, false);
                    break;
                case UIFormType.Top:
                    goCloneUIPrefabs.transform.SetParent(_Fog, false);
                    break;
                default:
                    break;
            }
            //设置隐藏
            goCloneUIPrefabs.SetActive(false);
            //把克隆体，加入到所有ui窗体缓存集合中
            _HueALLUICharm.Add(uiFormName, baseUIForm);
            return baseUIForm;
        }
        else
        {
            Debug.Log("_TraCanvasTransfrom==null Or goCloneUIPrefabs==null!! ,Plese Check!, 参数uiFormName=" + uiFormName);
        }
        Debug.Log("出现不可以预估的错误，请检查，参数 uiFormName=" + uiFormName);
        return null;
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void CrackUICharmOcher(string uiFormName)
    {
        //ui窗体基类
        FirmUICharm baseUIForm;
        //从所有窗体集合中得到的窗体
        FirmUICharm baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _HueBequestFirnUICharm.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        //把当前窗体，加载到正在显示集合中
        _HueALLUICharm.TryGetValue(uiFormName, out baseUIFormFromAllCache);
        if (baseUIFormFromAllCache != null)
        {
            _HueBequestFirnUICharm.Add(uiFormName, baseUIFormFromAllCache);
            //显示当前窗体
            baseUIFormFromAllCache.Display();
            
        }
    }

    /// <summary>
    /// 卸载ui窗体从当前显示的集合缓存中
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void HoleUICharmOcher(string strUIFormsName)
    {
        //ui窗体基类
        FirmUICharm baseUIForms;
        //正在显示ui窗体缓存集合没有记录，则直接返回
        _HueBequestFirnUICharm.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体，运行隐藏，且从正在显示ui窗体缓存集合中移除
        baseUIForms.Hidding();
        _HueBequestFirnUICharm.Remove(strUIFormsName);
    }

    /// <summary>
    /// 加载ui窗体到当前显示窗体集合，且，隐藏其他正在显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void CrackUIFervorMyOcherSafeTooth(string strUIFormsName)
    {
        //窗体基类
        FirmUICharm baseUIForms;
        //所有窗体集合中的窗体基类
        FirmUICharm baseUIFormsFromAllCache;
        _HueBequestFirnUICharm.TryGetValue(strUIFormsName, out baseUIForms);
        //正在显示ui窗体缓存集合里有记录，直接返回
        if (baseUIForms != null) return;
        Debug.Log("关闭其他窗体");
        //正在显示ui窗体缓存 与栈缓存集合里所有的窗体进行隐藏处理
        List<FirmUICharm> ShowUIFormsList = new List<FirmUICharm>(_HueBequestFirnUICharm.Values);
        foreach (FirmUICharm baseUIFormsItem in ShowUIFormsList)
        {
            //Debug.Log("_DicCurrentShowUIForms---------" + baseUIFormsItem.transform.name);
            if (baseUIFormsItem.BequestUICity.UIForms_Type == UIFormType.PopUp)
            {
                //baseUIFormsItem.Hidding();
                HoleUICharmWavyOcherDonFirnAward(baseUIFormsItem.GetType().Name);
            }
        }
        List<FirmUICharm> CurrentUIFormsList = new List<FirmUICharm>(_DigBequestUICharm);
        foreach (FirmUICharm baseUIFormsItem in CurrentUIFormsList)
        {
            //Debug.Log("_StaCurrentUIForms---------"+baseUIFormsItem.transform.name);
            //baseUIFormsItem.Hidding();
            HoleUICharmWavyOcherDonFirnAward(baseUIFormsItem.GetType().Name);
        }
        //把当前窗体，加载到正在显示ui窗体缓存集合中 
        _HueALLUICharm.TryGetValue(strUIFormsName, out baseUIFormsFromAllCache);
        if (baseUIFormsFromAllCache != null)
        {
            _HueBequestFirnUICharm.Add(strUIFormsName, baseUIFormsFromAllCache);
            baseUIFormsFromAllCache.Display();
        }
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void CrackUICharmOcherRollHappy(string uiFormName)
    {
        //ui窗体基类
        FirmUICharm baseUIForm;
        //从所有窗体集合中得到的窗体
        FirmUICharm baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _HueBequestFirnUICharm.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        bool havePopUp = false;
        foreach (FirmUICharm uiforms in _HueBequestFirnUICharm.Values)
        {
            if (uiforms.BequestUICity.UIForms_Type == UIFormType.PopUp)
            {
                havePopUp = true;
                break;
            }
        }
        if (!havePopUp)
        {
            //把当前窗体，加载到正在显示集合中
            _HueALLUICharm.TryGetValue(uiFormName, out baseUIFormFromAllCache);
            if (baseUIFormFromAllCache != null)
            {
                _HueBequestFirnUICharm.Add(uiFormName, baseUIFormFromAllCache);
                //显示当前窗体
                baseUIFormFromAllCache.Display();

            }
        }
        else
        {
            _RollUICharm.Add(uiFormName);
        }
        
    }
    /// <summary>
    /// 卸载ui窗体从当前显示窗体集合缓存中，且显示其他原本需要显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void HoleUICharmWavyOcherDonFirnAward(string strUIFormsName)
    {
        //ui窗体基类
        FirmUICharm baseUIForms;
        _HueBequestFirnUICharm.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体 ，运行隐藏状态，且从正在显示ui窗体缓存集合中删除
        baseUIForms.Hidding();
        _HueBequestFirnUICharm.Remove(strUIFormsName);
        //正在显示ui窗体缓存与栈缓存集合里素有窗体进行再次显示
        //foreach (FirmUICharm baseUIFormsItem in _DicCurrentShowUIForms.Values)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
        //foreach (FirmUICharm baseUIFormsItem in _StaCurrentUIForms)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
    }
    /// <summary>
    /// ui窗体入栈
    /// 功能：1判断栈里是否已经有窗体，有则冻结
    ///   2先判断ui预设缓存集合是否有指定的ui窗体，有则处理
    ///   3指定ui窗体入栈
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void PoleUICharm(string strUIFormsName)
    {
        //ui预设窗体
        FirmUICharm baseUI;
        //判断栈里是否已经有窗体,有则冻结
        if (_DigBequestUICharm.Count > 0)
        {
            FirmUICharm topUIForms = _DigBequestUICharm.Peek();
            topUIForms.Uranus();
            //Debug.Log("topUIForms是" + topUIForms.name);
        }
        //先判断ui预设缓存集合是否有指定ui窗体，有则处理
        _HueALLUICharm.TryGetValue(strUIFormsName, out baseUI);
        if (baseUI != null)
        {
            baseUI.Display();
        }
        else
        {
            Debug.Log(string.Format("/PushUIForms()/ baseUI==null! 核心错误，请检查 strUIFormsName={0} ", strUIFormsName));
        }
        //指定ui窗体入栈
        _DigBequestUICharm.Push(baseUI);
       
    }

    /// <summary>
    /// ui窗体出栈逻辑
    /// </summary>
    private void CudUICharm()
    {

        if (_DigBequestUICharm.Count >= 2)
        {
            //出栈逻辑
            FirmUICharm topUIForms = _DigBequestUICharm.Pop();
            //出栈的窗体进行隐藏
            topUIForms.Hidding(() => {
                //出栈窗体的下一个窗体逻辑
                FirmUICharm nextUIForms = _DigBequestUICharm.Peek();
                //下一个窗体重新显示处理
                nextUIForms.Redisplay();
            });
        }
        else if (_DigBequestUICharm.Count == 1)
        {
            FirmUICharm topUIForms = _DigBequestUICharm.Pop();
            //出栈的窗体进行隐藏处理
            topUIForms.Hidding();
        }
    }


    /// <summary>
    /// 初始化ui窗体预设路径数据
    /// </summary>
    private void BiteUICharmSporeSpan()
    {
        IChiselThinker configMgr = new ChiselThinkerAnRote(SumModest.SYS_PATH_UIFORMS_CONFIG_INFO);
        if (_HueCharmSpore != null)
        {
            _HueCharmSpore = configMgr.LopAttempt;
        }
    }

    /// <summary>
    /// 清空栈结构体集合
    /// </summary>
    /// <returns></returns>
    private bool StaveScrubReign()
    {
        if(_DigBequestUICharm!=null && _DigBequestUICharm.Count >= 1)
        {
            _DigBequestUICharm.Clear();
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取当前弹框ui的栈
    /// </summary>
    /// <returns></returns>
    public Stack<FirmUICharm> BisBequestMustScrub()
    {
        return _DigBequestUICharm;
    }


    /// <summary>
    /// 根据panel名称获取panel gameObject
    /// </summary>
    /// <param name="uiFormName"></param>
    /// <returns></returns>
    public GameObject BisSkillAnBard(string uiFormName)
    {
        //ui窗体基类
        FirmUICharm baseUIForm;
        //如果正在显示的集合中存在该窗体，直接返回
        _HueALLUICharm.TryGetValue(uiFormName, out baseUIForm);
        return baseUIForm?.gameObject;
    }

    /// <summary>
    /// 获取所有打开的panel（不包括Normal）
    /// </summary>
    /// <returns></returns>
    public List<GameObject> BisCapitalMisery(bool containNormal = false)
    {
        List<GameObject> openingPanels = new List<GameObject>();
        List<FirmUICharm> allUIFormsList = new List<FirmUICharm>(_HueALLUICharm.Values);
        foreach(FirmUICharm panel in allUIFormsList)
        {
            if (panel.gameObject.activeInHierarchy)
            {
                if (containNormal || panel._AbilityUIWick.UIForms_Type != UIFormType.Normal)
                {
                    openingPanels.Add(panel.gameObject);
                }
            }
        }

        return openingPanels;
    }
}
