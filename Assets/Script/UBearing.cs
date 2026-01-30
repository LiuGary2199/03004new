using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UBearing : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("materialId")]    // Scroll main texture based on time
[UnityEngine.Serialization.FormerlySerializedAs("RegisterGo")]    public int ForecastMe= 0;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedX")]    [UnityEngine.Serialization.FormerlySerializedAs("ManureCrimeX")]public float TwelveRainyX= 0.5f;
[UnityEngine.Serialization.FormerlySerializedAs("scrollSpeedY")]    [UnityEngine.Serialization.FormerlySerializedAs("ManureCrimeY")]public float TwelveRainyY= 0f;
    Renderer Bill;

    void Start()
    {
        Bill = GetComponent<Renderer>();
    }

    void Update()
    {
        //GetComponent<LineRenderer>().materials[0].
        

        float offsetX = Time.time/2 * -TwelveRainyX;
        float offsetY = Time.time * TwelveRainyY;

        Bill.materials[ForecastMe].SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));

        //rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, offsetY));
    }

}
