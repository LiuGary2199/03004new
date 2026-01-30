using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheer : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    [UnityEngine.Serialization.FormerlySerializedAs("CedarCent")]public Text CheerLoss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        CheerLoss.text = CheerThinker.BisFeedback().Genu;
        StartCoroutine(nameof(BiteHappyCheer));
    }

    private IEnumerator BiteHappyCheer()
    {
        yield return new WaitForSeconds(2);
        HappyUIMust(GetType().Name);
    }

}
