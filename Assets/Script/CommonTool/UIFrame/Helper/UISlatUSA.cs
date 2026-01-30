/*
        主题： UI遮罩管理器  

        “弹出窗体”往往因为需要玩家优先处理弹出小窗体，则要求玩家不能(无法)点击“父窗体”，这种窗体就是典型的“模态窗体”
  5  *    Description: 
  6  *           功能： 负责“弹出窗体”模态显示实现
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UISlatUSA : MonoBehaviour
{
    private static UISlatUSA _Feedback= null;
    //ui根节点对象
    private GameObject _AtUsableFlee= null;
    //ui脚本节点对象
    private Transform _CopUIDoorwayLike= null;
    //顶层面板
    private GameObject _UpMeSkill;
    //遮罩面板
    private GameObject _UpSlatSkill;
    //ui摄像机
    private Camera _UIClient;
    //ui摄像机原始的层深
    private float _DominantUIClientRobin;
    //获取实例
    public static UISlatUSA BisFeedback()
    {
        if (_Feedback == null)
        {
            _Feedback = new GameObject("_UIMaskMgr").AddComponent<UISlatUSA>();
        }
        return _Feedback;
    }
    private void Awake()
    {
        _AtUsableFlee = GameObject.FindGameObjectWithTag(SumModest.SYS_TAG_CANVAS);
        _CopUIDoorwayLike = SnakeCanyon.PickSodGuessLike(_AtUsableFlee, SumModest.SYS_SCRIPTMANAGER_NODE);
        //把脚本实例，座位脚本节点对象的子节点
        SnakeCanyon.BisSmellLikeMyAutumnLike(_CopUIDoorwayLike, this.gameObject.transform);
        //获取顶层面板，遮罩面板
        _UpMeSkill = _AtUsableFlee;
        _UpSlatSkill = SnakeCanyon.PickSodGuessLike(_AtUsableFlee, "_UIMaskPanel").gameObject;
        //得到uicamera摄像机原始的层深
        _UIClient = GameObject.FindGameObjectWithTag("UICamera").GetComponent<Camera>();
        if (_UIClient != null)
        {
            //得到ui相机原始的层深
            _DominantUIClientRobin = _UIClient.depth;
        }
        else
        {
            Debug.Log("UI_Camera is Null!,Please Check!");
        }
    }

    /// <summary>
    /// 设置遮罩状态
    /// </summary>
    /// <param name="goDisplayUIForms">需要显示的ui窗体</param>
    /// <param name="lucenyType">显示透明度属性</param>
    public void GapSlatIndoor(GameObject goDisplayUIForms,UIFormLucenyType lucenyType = UIFormLucenyType.Lucency)
    {
        //顶层窗体下移
        _UpMeSkill.transform.SetAsLastSibling();
        switch (lucenyType)
        {
               //完全透明 不能穿透
            case UIFormLucenyType.Lucency:
                _UpSlatSkill.SetActive(true);
                Color newColor = new Color(255 / 255F, 255 / 255F, 255 / 255F, 0F / 255F);
                _UpSlatSkill.GetComponent<Image>().color = newColor;
                break;
                //半透明，不能穿透
            case UIFormLucenyType.Translucence:
                _UpSlatSkill.SetActive(true);
                Color newColor2 = new Color(0 / 255F, 0 / 255F, 0 / 255F, 220 / 255F);
                _UpSlatSkill.GetComponent<Image>().color = newColor2;
                ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.mg_IndoorFeat);
                break;
                //低透明，不能穿透
            case UIFormLucenyType.ImPenetrable:
                _UpSlatSkill.SetActive(true);
                Color newColor3 = new Color(50 / 255F, 50 / 255F, 50 / 255F, 240F / 255F);
                _UpSlatSkill.GetComponent<Image>().color = newColor3;
                break;
                //可以穿透
            case UIFormLucenyType.Penetrable:
                if (_UpSlatSkill.activeInHierarchy)
                {
                    _UpSlatSkill.SetActive(false);
                }
                break;
            default:
                break;
        }
        //遮罩窗体下移
        _UpSlatSkill.transform.SetAsLastSibling();
        //显示的窗体下移
        goDisplayUIForms.transform.SetAsLastSibling();
        //增加当前ui摄像机的层深（保证当前摄像机为最前显示）
        if (_UIClient != null)
        {
            _UIClient.depth = _UIClient.depth + 100;
        }
    }
    public void SafeSlatIndoor()
    {
        if (UIManager.BisFeedback().RollUICharm.Count > 0 || UIManager.BisFeedback().BisBequestMustScrub().Count > 0)
        {
            return;
        }
        Color newColor3 = new Color(_UpSlatSkill.GetComponent<Image>().color.r, _UpSlatSkill.GetComponent<Image>().color.g, _UpSlatSkill.GetComponent<Image>().color.b,0);
        _UpSlatSkill.GetComponent<Image>().color = newColor3;
    }
    /// <summary>
    /// 取消遮罩状态
    /// </summary>
    public void InsertSlatIndoor()
    {
        if (UIManager.BisFeedback().RollUICharm.Count > 0 || UIManager.BisFeedback().BisBequestMustScrub().Count > 0)
        {
            return;
        }
        //顶层窗体上移
        _UpMeSkill.transform.SetAsFirstSibling();
        //禁用遮罩窗体
        if (_UpSlatSkill.activeInHierarchy)
        {
            _UpSlatSkill.SetActive(false);
            ShrubbyRejoinFleet.BisFeedback().Cast(CChisel.On_IndoorHappy);
        }
        //恢复当前ui摄像机的层深
        if (_UIClient != null)
        {
            _UIClient.depth = _DominantUIClientRobin;
        }
    }
}
