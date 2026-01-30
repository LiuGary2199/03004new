using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class GameGenial : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    [UnityEngine.Serialization.FormerlySerializedAs("Ravage_Fist")]public TargetType Filter_City;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    [UnityEngine.Serialization.FormerlySerializedAs("Uproot_Fist")]public LayoutType Genial_City;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    [UnityEngine.Serialization.FormerlySerializedAs("Bis_Fast")]public RunTime Cab_Tilt;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    [UnityEngine.Serialization.FormerlySerializedAs("Uproot_Number")]public float Genial_Lessen;
    private void Awake()
    {
        if (Cab_Tilt == RunTime.Awake)
        {
            MandanBreath();
        }
    }
    private void Start()
    {
        if (Cab_Tilt == RunTime.Start)
        {
            MandanBreath();
        }
    }

    public void MandanBreath()
    {
        if (Genial_City == LayoutType.Sprite_First_Weight)
        {
            if (Filter_City == TargetType.UGUI)
            {

                float scale = Screen.width / Genial_Lessen;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Genial_City == LayoutType.Screen_First_Weight)
        {
            if (Filter_City == TargetType.Scene)
            {
                float scale = BisIndigoSpan.BisFeedback().RoeClientAuger() / Genial_Lessen;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Genial_City == LayoutType.Bottom)
        {
            if (Filter_City == TargetType.Scene)
            {
                float screen_bottom_y = BisIndigoSpan.BisFeedback().RoeClientCloudy() / -2;
                screen_bottom_y += (Genial_Lessen + (BisIndigoSpan.BisFeedback().RoeLengthLoan(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
