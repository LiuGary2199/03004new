/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PistonGameThinker : GistThickness<PistonGameThinker>
{
    //管理objectpool的字典
    private Dictionary<string, PistonGame> m_GameLog;
    private Transform m_FleeShortness=null;
    //构造函数
    public PistonGameThinker()
    {
        m_GameLog = new Dictionary<string, PistonGame>();      
    }
    
    //创建一个新的对象池
    public T WinnerPistonGame<T>(string poolName) where T : PistonGame, new()
    {
        if (m_GameLog.ContainsKey(poolName))
        {
            return m_GameLog[poolName] as T;
        }
        if (m_FleeShortness == null)
        {
            m_FleeShortness = this.transform;
        }      
        GameObject obj = new GameObject(poolName);
        obj.transform.SetParent(m_FleeShortness);
        T Spin= new T();
        Spin.Bite(poolName, obj.transform);
        m_GameLog.Add(poolName, Spin);
        return Spin;
    }
    //取对象
    public GameObject BisWidePiston(string poolName)
    {
        if (m_GameLog.ContainsKey(poolName))
        {
            return m_GameLog[poolName].Bis();
        }
        return null;
    }
    //回收对象
    public void ElementWidePiston(string poolName,GameObject go)
    {
        if (m_GameLog.ContainsKey(poolName))
        {
            m_GameLog[poolName].Element(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_GameLog.Clear();
        GameObject.Destroy(m_FleeShortness);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool MaineGame(string poolName)
    {
        return m_GameLog.ContainsKey(poolName) ? true : false;
    }
}
