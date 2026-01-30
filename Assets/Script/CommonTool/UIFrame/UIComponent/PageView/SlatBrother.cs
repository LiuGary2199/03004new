using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlatBrother : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    [UnityEngine.Serialization.FormerlySerializedAs("Fair")]public RectTransform Ploy;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    [UnityEngine.Serialization.FormerlySerializedAs("Electrical")]public RealPass Immobilize;
    private void Awake()
    {
        Immobilize.ItRealSteppe = Polychrome;
    }

    void Polychrome(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Ploy.GetComponent<RectTransform>().position = pos;
    }
}
