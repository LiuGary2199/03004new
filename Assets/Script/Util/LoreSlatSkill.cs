using UnityEngine;
using UnityEngine.UI;

public class LoreSlatSkill : FirmUICharm
{
    [Header("目标设置")]
[UnityEngine.Serialization.FormerlySerializedAs("targetObj")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerGel")]public GameObject CinemaWok;
[UnityEngine.Serialization.FormerlySerializedAs("padding")]    [UnityEngine.Serialization.FormerlySerializedAs("Conduct")]public float Russian= 10f; // 目标周围的边距

    [Header("动画设置")]
[UnityEngine.Serialization.FormerlySerializedAs("shrinkTime")]    [UnityEngine.Serialization.FormerlySerializedAs("RubbleFast")]public float InsertTilt= 0.3f;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetX")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerReduceX")]public float CinemaEngineX;
[UnityEngine.Serialization.FormerlySerializedAs("targetOffsetY")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerReduceY")]public float CinemaEngineY;

    private Material Forecast;
    private RectTransform CinemaLore;
    private Canvas CinemaUsable;
    private RectTransform SingLore;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetX")]
[UnityEngine.Serialization.FormerlySerializedAs("SurmiseReduceX")]    public float PolluteEngineX;
[UnityEngine.Serialization.FormerlySerializedAs("currentOffsetY")]    [UnityEngine.Serialization.FormerlySerializedAs("SurmiseReduceY")]public float PolluteEngineY;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosX")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerEonX")]public float CinemaYamX;
[UnityEngine.Serialization.FormerlySerializedAs("targetPosY")]    [UnityEngine.Serialization.FormerlySerializedAs("RainerEonY")]public float CinemaYamY;

    private float InsertLoyalistX= 0f;
    private float InsertLoyalistY= 0f;
    private UnfairlySheerPrinciple RoyalPrinciple;
    private bool FeeFilterWok= false;

    private void Start()
    {
        SingLore = GetComponent<RectTransform>();
        Forecast = GetComponent<Image>().material;
        RoyalPrinciple = GetComponent<UnfairlySheerPrinciple>();

        // 检查是否有目标对象
        if (CinemaWok != null)
        {
            CinemaLore = CinemaWok.GetComponent<RectTransform>();
            if (CinemaLore != null)
            {
                CinemaUsable = CinemaWok.GetComponentInParent<Canvas>();
                if (CinemaUsable != null)
                {
                    FeeFilterWok = true;
                    SnuglyFilterGeneralize();
                }
            }
        }

        if (!FeeFilterWok)
        {
            // 原逻辑：使用Inspector中设置的参数
            Vector4 centerMat = new Vector4(CinemaYamX, CinemaYamY, 0, 0);
            Forecast.SetVector("_Center", centerMat);
        }

        if (RoyalPrinciple != null && FeeFilterWok)
        {
            RoyalPrinciple.GapFilterLore(CinemaLore);
        }
    }

    private void Update()
    {
        if (FeeFilterWok)
        {
            SnuglyFilterGeneralize();
        }

        // 原逻辑：平滑动画
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

    private void SnuglyFilterGeneralize()
    {
        // 获取目标在屏幕空间的位置
        Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(CinemaUsable.worldCamera, CinemaLore.position);

        // 转换为遮罩面板的本地坐标
        Vector2 localPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(SingLore, screenPos, CinemaUsable.worldCamera, out localPos);

        // 设置遮罩中心为目标中心
        CinemaYamX = localPos.x;
        CinemaYamY = localPos.y;
        Forecast.SetVector("_Center", new Vector4(CinemaYamX, CinemaYamY, 0, 0));

        // 设置遮罩大小为目标大小加上边距
        CinemaEngineX = (CinemaLore.rect.width / 2) + Russian;
        CinemaEngineY = (CinemaLore.rect.height / 2) + Russian;
    }

    // 外部调用：设置新的目标对象
    public void GapFilter(GameObject newTarget)
    {
        CinemaWok = newTarget;

        if (CinemaWok != null)
        {
            CinemaLore = CinemaWok.GetComponent<RectTransform>();
            if (CinemaLore != null)
            {
                CinemaUsable = CinemaWok.GetComponentInParent<Canvas>();
                if (CinemaUsable != null)
                {
                    FeeFilterWok = true;
                    SnuglyFilterGeneralize();

                    if (RoyalPrinciple != null)
                    {
                        RoyalPrinciple.GapFilterLore(CinemaLore);
                    }
                }
            }
        }
        else
        {
            FeeFilterWok = false;
        }
    }
}