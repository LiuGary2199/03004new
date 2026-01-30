/**
 * 
 * 左右滑动的页面视图
 * 
 * ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class RealPass : MonoBehaviour,IBeginDragHandler,IEndDragHandler
{
[UnityEngine.Serialization.FormerlySerializedAs("rect")]    //scrollview
[UnityEngine.Serialization.FormerlySerializedAs("Rome")]    public ScrollRect Fist;
    //求出每页的临界角，页索引从0开始
    List<float> FadThen= new List<float>();
[UnityEngine.Serialization.FormerlySerializedAs("isDrag")]    //是否拖拽结束
[UnityEngine.Serialization.FormerlySerializedAs("WeLust")]    public bool ToBold= false;
    bool PeepGaze= true;
    //滑动的起始坐标  
    float CinemaUnforeseen= 0;
    float AlterBoldUnforeseen;
    float startTime = 0f;
[UnityEngine.Serialization.FormerlySerializedAs("smooting")]    //滑动速度  
[UnityEngine.Serialization.FormerlySerializedAs("Arboreal")]    public float Negative= 1f;
[UnityEngine.Serialization.FormerlySerializedAs("sensitivity")]    [UnityEngine.Serialization.FormerlySerializedAs("Imaginative")]public float Impermeable= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("OnPageChange")]    //页面改变
[UnityEngine.Serialization.FormerlySerializedAs("HeRiteBaltic")]    public Action<int> ItRealSteppe;
    //当前页面下标
    int PolluteRealAngry= -1;
    void Start()
    {
        Fist = this.GetComponent<ScrollRect>();
        float horizontalLength = Fist.content.rect.width - this.GetComponent<RectTransform>().rect.width;
        FadThen.Add(0);
        for(int i = 1; i < Fist.content.childCount - 1; i++)
        {
            FadThen.Add(GetComponent<RectTransform>().rect.width * i / horizontalLength);
        }
        FadThen.Add(1);
    }

    
    void Update()
    {
        if(!ToBold && !PeepGaze)
        {
            startTime += Time.deltaTime;
            float t = startTime * Negative;
            Fist.horizontalNormalizedPosition = Mathf.Lerp(Fist.horizontalNormalizedPosition, CinemaUnforeseen, t);
            if (t >= 1)
            {
                PeepGaze = true;
            }
        }
        
    }
    /// <summary>
    /// 设置页面的index下标
    /// </summary>
    /// <param name="index"></param>
    void GapRealAngry(int index)
    {
        if (PolluteRealAngry != index)
        {
            PolluteRealAngry = index;
            if (ItRealSteppe != null)
            {
                ItRealSteppe(index);
            }
        }
    }
    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        ToBold = true;
        AlterBoldUnforeseen = Fist.horizontalNormalizedPosition;
    }
    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = Fist.horizontalNormalizedPosition;
        posX += ((posX - AlterBoldUnforeseen) * Impermeable);
        posX = posX < 1 ? posX : 1;
        posX = posX > 0 ? posX : 0;
        int Aphid= 0;
        float offset = Mathf.Abs(FadThen[Aphid] - posX);
        for(int i = 0; i < FadThen.Count; i++)
        {
            float temp = Mathf.Abs(FadThen[i] - posX);
            if (temp < offset)
            {
                Aphid = i;
                offset = temp;
            }
        }
        GapRealAngry(Aphid);
        CinemaUnforeseen = FadThen[Aphid];
        ToBold = false;
        startTime = 0f;
        PeepGaze = false;
    }
}
