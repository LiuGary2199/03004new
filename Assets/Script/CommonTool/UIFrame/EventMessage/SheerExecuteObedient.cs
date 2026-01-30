/*
 *     主题： 事件触发监听      
 *    Description: 
 *           功能： 实现对于任何对象的监听处理。
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SheerExecuteObedient : UnityEngine.EventSystems.EventTrigger
{
    public delegate void VoidDelegate(GameObject go);
    public VoidDelegate WeWrite;
    public VoidDelegate WeAnew;
    public VoidDelegate WeCrack;
    public VoidDelegate WeMule;
    public VoidDelegate WeOn;
    public VoidDelegate WeTimber;
    public VoidDelegate WeSnuglyTimber;

    /// <summary>
    /// 得到监听器组件
    /// </summary>
    /// <param name="go">监听的游戏对象</param>
    /// <returns></returns>
    public static SheerExecuteObedient Bis(GameObject go)
    {
        SheerExecuteObedient listener = go.GetComponent<SheerExecuteObedient>();
        if (listener == null)
        {
            listener = go.AddComponent<SheerExecuteObedient>();
        }
        return listener;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (WeWrite != null)
        {
            WeWrite(gameObject);
        }
    }
    public override void OnPointerDown(PointerEventData eventData)
    {
        if (WeAnew != null)
        {
            WeAnew(gameObject);
        }
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        if (WeCrack != null)
        {
            WeCrack(gameObject);
        }
    }
    public override void OnPointerExit(PointerEventData eventData)
    {
        if (WeMule != null)
        {
            WeMule(gameObject);
        }
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        if (WeOn != null)
        {
            WeOn(gameObject);
        }
    }
    public override void OnSelect(BaseEventData eventData)
    {
        if (WeTimber != null)
        {
            WeTimber(gameObject);
        }
    }
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        if (WeSnuglyTimber != null)
        {
            WeSnuglyTimber(gameObject);
        }
    }
}
