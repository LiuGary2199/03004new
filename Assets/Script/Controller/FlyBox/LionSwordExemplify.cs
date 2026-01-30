using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LionSwordExemplify : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("imageList")]    [UnityEngine.Serialization.FormerlySerializedAs("FancyGerm")]public List<Sprite> TrainThen;
    private Image Train;
[UnityEngine.Serialization.FormerlySerializedAs("speen")]    [UnityEngine.Serialization.FormerlySerializedAs("Pylon")]public float Thumb;
    IEnumerator SkinBreath()
    {
        foreach(Sprite sprite in TrainThen)
        {
            Train.sprite = sprite;
            yield return new WaitForSeconds(Thumb);
        }
    }
    private void OnEnable()
    {
        Train = GetComponent<Image>();
        StartCoroutine(nameof(SkinBreath));
    }
    // private void OnDisable()
    // {
    //     StopCoroutine("playAction");
    // }
}
