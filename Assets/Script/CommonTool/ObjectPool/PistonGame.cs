/*
 *   管理对象的池子
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonGame 
{
    private Queue<GameObject> m_GameOcher;
    //池子名称
    private string m_GameBard;
    //父物体
    protected Transform m_Autumn;
    //缓存对象的预制体
    private GameObject Monoid;
    //最大容量
    private int m_BayTrove;
    //默认最大容量
    protected const int m_FinnishBayTrove= 20;
    public GameObject Stable{
        get => Monoid;set { Monoid = value;  }
    }
    //构造函数初始化
    public PistonGame()
    {
        m_BayTrove = m_FinnishBayTrove;
        m_GameOcher = new Queue<GameObject>();
    }
    //初始化
    public virtual void Bite(string poolName,Transform transform)
    {
        m_GameBard = poolName;
        m_Autumn = transform;
    }
    //取对象
    public virtual GameObject Bis()
    {
        GameObject obj;
        if (m_GameOcher.Count > 0)
        {
            obj = m_GameOcher.Dequeue();
        }
        else
        {
            obj = GameObject.Instantiate<GameObject>(Monoid);
            obj.transform.SetParent(m_Autumn);
            obj.SetActive(false);
        }
        obj.SetActive(true);
        return obj;
    }
    //回收对象
    public virtual void Element(GameObject obj)
    {
        if (m_GameOcher.Contains(obj)) return;
        if (m_GameOcher.Count >= m_BayTrove)
        {
            GameObject.Destroy(obj);
        }
        else
        {
            m_GameOcher.Enqueue(obj);
            obj.SetActive(false);
        }
    }
    /// <summary>
    /// 回收所有激活的对象
    /// </summary>
    public virtual void ElementRid()
    {
        Transform[] child = m_Autumn.GetComponentsInChildren<Transform>();
        foreach (Transform item in child)
        {
            if (item == m_Autumn)
            {
                continue;
            }
            
            if (item.gameObject.activeSelf)
            {
                Element(item.gameObject);
            }
        }
    }
    //销毁
    public virtual void Country()
    {
        m_GameOcher.Clear();
    }
}
