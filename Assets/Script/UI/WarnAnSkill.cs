using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarnAnSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    [UnityEngine.Serialization.FormerlySerializedAs("Pitch")]public Button[] Vogue;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    [UnityEngine.Serialization.FormerlySerializedAs("Wolf1Humble")]public Sprite Skin1Length;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    [UnityEngine.Serialization.FormerlySerializedAs("Wolf2Humble")]public Sprite Skin2Length;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Button star in Vogue)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Aphid= indexStr == "" ? 0 : int.Parse(indexStr);
                DodgeReuse(Aphid);
            });
        }
        
    }

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        for (int i = 0; i < 5; i++)
        {
            Vogue[i].gameObject.GetComponent<Image>().sprite = Skin2Length;
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }


    private void DodgeReuse(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Vogue[i].gameObject.GetComponent<Image>().sprite = i <= index ? Skin1Length : Skin2Length;
        }
        if (index < 3)
        {
            StartCoroutine(SlushSkill());
        } else
        {
            // 跳转到应用商店
            WarnAnThinker.instance.FeatAPEatShrine();
            StartCoroutine(SlushSkill());
        }
        
        // 打点
        SelfSheerRibbon.BisFeedback().CastSheer("1016", (index + 1).ToString());
    }

    IEnumerator SlushSkill(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        VerbThinker.Instance.WidePassage();
        HappyUIMust(GetType().Name);
    }
}
