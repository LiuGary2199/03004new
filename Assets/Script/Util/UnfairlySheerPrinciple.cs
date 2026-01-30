using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class UnfairlySheerPrinciple : MonoBehaviour, ICanvasRaycastFilter
{
    private Image CinemaSword;
    private RectTransform CinemaLore;
    public void GapFilterSword(Image target)
    {
        CinemaSword = target;
    }
    public void GapFilterLore(RectTransform rect)
    {
        CinemaLore = rect;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (CinemaSword == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(CinemaSword.rectTransform, sp, eventCamera);
    }
}