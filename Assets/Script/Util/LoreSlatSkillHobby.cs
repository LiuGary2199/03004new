// Project: HappyBingo-Real
// FileName: LoreSlatSkill.cs
// Author: AX
// CreateDate: 20230220
// CreateTime: 9:55
// Description:

using UnityEngine;
using UnityEngine.UI;

public class LoreSlatSkillHobby : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerReduceX")]public float CinemaEngineX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerReduceY")]public float CinemaEngineY;
    private Material Forecast;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
[UnityEngine.Serialization.FormerlySerializedAs("SurmiseReduceX")]    public float PolluteEngineX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    [UnityEngine.Serialization.FormerlySerializedAs("SurmiseReduceY")]public float PolluteEngineY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]
[UnityEngine.Serialization.FormerlySerializedAs("RainerEonX")]    public float CinemaYamX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerEonY")]public float CinemaYamY;
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]
[UnityEngine.Serialization.FormerlySerializedAs("RubbleFast")]    public float InsertTilt= 0.3f;
    private UnfairlySheerPrinciple RoyalPrinciple;
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerGel")]public GameObject CinemaWok;


    private float InsertLoyalistX= 0f;
    private float InsertLoyalistY= 0f;


    private void Start()
    {
        Vector4 centerMat = new Vector4(CinemaYamX, CinemaYamY, 0, 0);
        Forecast = GetComponent<Image>().material;
        Forecast.SetVector("_Center", centerMat);


        RoyalPrinciple = GetComponent<UnfairlySheerPrinciple>();
        if (RoyalPrinciple != null)
        {
            RoyalPrinciple.GapFilterSword(CinemaWok.gameObject.GetComponent<Image>());
        }
    }

    private void Update()
    {
        
        //从当前偏移量到目标偏移量差值显示收缩动画
        float valueX = Mathf.SmoothDamp(PolluteEngineX, CinemaEngineX, ref InsertLoyalistX, InsertTilt);
        float valueY = Mathf.SmoothDamp(PolluteEngineY, CinemaEngineY, ref InsertLoyalistY, InsertTilt);
        if (!Mathf.Approximately(valueX, PolluteEngineX))
        {
            PolluteEngineX = valueX;
            Forecast.SetFloat("_SliderX", PolluteEngineX);
        }

        if (!Mathf.Approximately(valueY, PolluteEngineY))
        {
            PolluteEngineY = valueY;
            Forecast.SetFloat("_SliderY", PolluteEngineY);
        }
    }
    
    
    /// <summary>
    /// 世界坐标转换为画布坐标
    /// </summary>
    /// <param name="canvas">画布</param>
    /// <param name="world">世界坐标</param>
    /// <returns></returns>
    private Vector2 SepalMyUsableYam(Canvas canvas, Vector3 world)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, world, canvas.GetComponent<Camera>(), out position);
        return position;
    }
    
}