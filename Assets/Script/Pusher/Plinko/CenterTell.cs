using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterTell : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Light")]    public bool Auger;
[UnityEngine.Serialization.FormerlySerializedAs("Lock")]    public bool Hurl;
    // Start is called before the first frame update
    void Start()
    {
        Auger = false;
        Hurl = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D obj)
    {
        GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_column_normal,0.1f);
        if (Auger == false) 
        {
            BurdenImagist.Instance.PenBustlePet();
        }
        if (Hurl == false) 
        {
            ExemplifyCongestion.HolmSect(gameObject);
            StartCoroutine(AdornInception(gameObject.GetComponent<SpriteRenderer>()));
        }
        Auger = true;
    }
    IEnumerator AdornInception(SpriteRenderer Column)
    {
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.Selection);
        Hurl = true;
        Column.sprite = Resources.Load<Sprite>(CChisel.Ail_10);
        yield return new WaitForSeconds(0.2f);
        Column.sprite = Resources.Load<Sprite>(CChisel.End_8);
        Hurl = false;
    }
}
