using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 消息管理器
/// </summary>
public class ShrubbyRejoinFleet:GistThickness<ShrubbyRejoinFleet>
{
    //保存所有消息事件的字典
    //key使用字符串保存消息的名称
    //value使用一个带自定义参数的事件，用来调用所有注册的消息
    private Dictionary<string, Action<ShrubbySpan>> InevitablyShrubby;

    /// <summary>
    /// 私有构造函数
    /// </summary>
    private ShrubbyRejoinFleet()
    {
        BiteSpan();
    }

    private void BiteSpan()
    {
        //初始化消息字典
        InevitablyShrubby = new Dictionary<string, Action<ShrubbySpan>>();
    }

    /// <summary>

    /// 注册消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Retrieve(string key, Action<ShrubbySpan> action)
    {
        if (!InevitablyShrubby.ContainsKey(key))
        {
            InevitablyShrubby.Add(key, null);
        }
        InevitablyShrubby[key] += action;
    }



    /// <summary>
    /// 注销消息事件
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="action">消息事件</param>
    public void Sudden(string key, Action<ShrubbySpan> action)
    {
        if (InevitablyShrubby.ContainsKey(key) && InevitablyShrubby[key] != null)
        {
            InevitablyShrubby[key] -= action;
        }
    }

    /// <summary>
    /// 发送消息
    /// </summary>
    /// <param name="key">消息名</param>
    /// <param name="data">消息传递数据，可以不传</param>
    public void Cast(string key, ShrubbySpan data = null)
    {
        if (InevitablyShrubby.ContainsKey(key) && InevitablyShrubby[key] != null)
        {
            InevitablyShrubby[key](data);
        }
    }

    /// <summary>
    /// 清空所有消息
    /// </summary>
    public void Stave()
    {
        InevitablyShrubby.Clear();
    }
}
