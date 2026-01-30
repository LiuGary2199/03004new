/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExposePass : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
[UnityEngine.Serialization.FormerlySerializedAs("PickWren")]    public Tell EarnCite;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
[UnityEngine.Serialization.FormerlySerializedAs("ManureDrop")]    public ScrollRect TwelveLore;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
[UnityEngine.Serialization.FormerlySerializedAs("Zoology")]    //content
    public RectTransform Impulse;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
[UnityEngine.Serialization.FormerlySerializedAs("Evident")]    public float Commend= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
[UnityEngine.Serialization.FormerlySerializedAs("DutchLight")]    public float ShaleAuger;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
[UnityEngine.Serialization.FormerlySerializedAs("DutchParent")]    public float ShaleCloudy;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
[UnityEngine.Serialization.FormerlySerializedAs("DepositPupil")]    public int MineralTrove;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
[UnityEngine.Serialization.FormerlySerializedAs("WeClac")]    public bool ToPose= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
[UnityEngine.Serialization.FormerlySerializedAs("LoessPeart")]    public int AlterAngry;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
[UnityEngine.Serialization.FormerlySerializedAs("WindPeart")]    public int BoatAngry;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
[UnityEngine.Serialization.FormerlySerializedAs("PickParent")]    public float EarnCloudy= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
[UnityEngine.Serialization.FormerlySerializedAs("PickGerm")]    //缓存的itemlist
    public List<Tell> EarnThen;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
[UnityEngine.Serialization.FormerlySerializedAs("DepositGerm")]    public List<Tell> MineralThen;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
[UnityEngine.Serialization.FormerlySerializedAs("OatGerm")]    public List<int> LogThen;

    void Start()
    {
        ShaleCloudy = this.GetComponent<RectTransform>().sizeDelta.y;
        ShaleAuger = this.GetComponent<RectTransform>().sizeDelta.x;
        Impulse = TwelveLore.content;
        BiteSpan();

    }
    //初始化
    public void BiteSpan()
    {
        MineralTrove = Mathf.CeilToInt(ShaleCloudy / TireCloudy) + 1;
        for (int i = 0; i < MineralTrove; i++)
        {
            this.BisNews();
        }
        AlterAngry = 0;
        BoatAngry = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        GapSpan(numberList);
    }
    //设置数据
    void GapSpan(List<int> list)
    {
        LogThen = list;
        AlterAngry = 0;
        if (SpanTrove <= MineralTrove)
        {
            BoatAngry = SpanTrove;
        }
        else
        {
            BoatAngry = MineralTrove - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = AlterAngry; i < BoatAngry; i++)
        {
            Tell obj = CudNews();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * TireCloudy, 0);
                MineralThen.Add(obj);
                SnuglyNews(i, obj);
            }

        }
        Impulse.sizeDelta = new Vector2(ShaleAuger, SpanTrove * TireCloudy - Commend);
        ToPose = true;
    }
    //更新item
    public void SnuglyNews(int index, Tell obj)
    {
        int d = LogThen[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public Tell CudNews()
    {
        Tell obj = null;
        if (EarnThen.Count > 0)
        {
            obj = EarnThen[0];
            obj.gameObject.SetActive(true);
            EarnThen.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void PoleNews(Tell obj)
    {
        EarnThen.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int SpanTrove{
        get
        {
            return LogThen.Count;
        }
    }
    //每一行的高
    public float TireCloudy{
        get
        {
            return EarnCloudy + Commend;
        }
    }
    //添加item到缓存列表中
    public void BisNews()
    {
        GameObject obj = Instantiate(EarnCite.gameObject);
        obj.transform.SetParent(Impulse);
        RectTransform Fist= obj.GetComponent<RectTransform>();
        Fist.anchorMin = new Vector2(0.5f, 1);
        Fist.anchorMax = new Vector2(0.5f, 1);
        Fist.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        Tell o = obj.GetComponent<Tell>();
        EarnThen.Add(o);
    }



    void Update()
    {
        if (ToPose)
        {
            Expose();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Expose()
    {
        float vy = Impulse.anchoredPosition.y;
        float rollUpTop = (AlterAngry + 1) * TireCloudy;
        float rollUnderTop = AlterAngry * TireCloudy;

        if (vy > rollUpTop && BoatAngry < SpanTrove)
        {
            //上边界移除
            if (MineralThen.Count > 0)
            {
                Tell obj = MineralThen[0];
                MineralThen.RemoveAt(0);
                PoleNews(obj);
            }
            AlterAngry++;
        }
        float rollUpBottom = (BoatAngry - 1) * TireCloudy - Commend;
        if (vy < rollUpBottom - ShaleCloudy && AlterAngry > 0)
        {
            //下边界减少
            BoatAngry--;
            if (MineralThen.Count > 0)
            {
                Tell obj = MineralThen[MineralThen.Count - 1];
                MineralThen.RemoveAt(MineralThen.Count - 1);
                PoleNews(obj);
            }

        }
        float rollUnderBottom = BoatAngry * TireCloudy - Commend;
        if (vy > rollUnderBottom - ShaleCloudy && BoatAngry < SpanTrove)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            Tell go = CudNews();
            MineralThen.Add(go);
            go.transform.localPosition = new Vector3(0, -BoatAngry * TireCloudy);
            SnuglyNews(BoatAngry, go);
            BoatAngry++;
        }


        if (vy < rollUnderTop && AlterAngry > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            AlterAngry--;
            Tell go = CudNews();
            MineralThen.Insert(0, go);
            SnuglyNews(AlterAngry, go);
            go.transform.localPosition = new Vector3(0, -AlterAngry * TireCloudy);
        }

    }
}
