using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class BisUpwardAstonish : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup")]    [UnityEngine.Serialization.FormerlySerializedAs("Ox_Shrinkage")]public GameObject We_Melodrama;
[UnityEngine.Serialization.FormerlySerializedAs("fx_Poolgroup_1")]    [UnityEngine.Serialization.FormerlySerializedAs("Ox_Shrinkage_1")]public GameObject We_Melodrama_1;
[UnityEngine.Serialization.FormerlySerializedAs("text_Poolgroup")]    [UnityEngine.Serialization.FormerlySerializedAs("Lade_Shrinkage")]public GameObject Grid_Melodrama;
    private void OnTriggerEnter(Collider other)
    {
        GameObject pusherRewardItem = other.transform.parent.gameObject;
        if (pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.GemBlue || pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.GemDiamond || pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.GemRed || pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.Golden)
        {
            Transform TargetTF = UIManager.BisFeedback().VerbUsable.transform.Find("Normal/WideSkill/Window/GemsStoreBtn").transform;
            GameObject PegHigh= Resources.Load<GameObject>(CChisel.Peg_High).gameObject;
            GameObject PegEnd= Resources.Load<GameObject>(CChisel.Peg_End).gameObject;
            GameObject PegPerplex= Resources.Load<GameObject>(CChisel.Peg_Perplex).gameObject;
            GameObject Emboss= Resources.Load<GameObject>(CChisel.Peg_Emboss).gameObject;
            GameObject fx_1 = We_Melodrama_1.GetComponent<GameThinker>().BisPiston();
            fx_1.SetActive(true);
            fx_1.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            switch (pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick) 
            {
                case PusherRewardType.GemBlue:
                    ExemplifyCongestion.RadiantFecundUrn(TargetTF.transform.position, PegHigh, other.gameObject.transform.position, TargetTF,()=> { });
                    break;
                case PusherRewardType.GemDiamond:
                    ExemplifyCongestion.RadiantFecundUrn(TargetTF.transform.position, PegPerplex, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.GemRed:
                    ExemplifyCongestion.RadiantFecundUrn(TargetTF.transform.position, PegEnd, other.gameObject.transform.position, TargetTF, () => { });
                    break;
                case PusherRewardType.Golden:
                    ExemplifyCongestion.RadiantFecundUrn(TargetTF.transform.position, Emboss, other.gameObject.transform.position, TargetTF, () => { });
                    break;

            }
        }
        if (pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.CoinCash || pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.CoinGold)
        {
            GameObject fx = We_Melodrama.GetComponent<GameThinker>().BisPiston();
            GameObject Text = Grid_Melodrama.GetComponent<GameThinker>().BisPiston();
            Text.SetActive(true);
            fx.SetActive(true);
            float V = (Screen.height * -0.587f) - 260;
            Text.transform.localScale = new Vector3(2f, 2f, 2f);
            Text.transform.localPosition = new Vector3(Text.transform.localPosition.x, Text.transform.localPosition.y - 2, V);
            Text.transform.position = new Vector3(other.gameObject.transform.position.x, -5f, Text.transform.position.z);
            Text.transform.DOMoveY(-4f + Random.Range(0, 1.5f), 0.7f).SetEase(Ease.OutQuad).OnComplete(() =>
            {
                Text.SetActive(false);
            });
            fx.transform.position = new Vector3(other.gameObject.transform.position.x, -0.5f, -5.74f);
            if (pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick == PusherRewardType.CoinCash)
            {
                Text.GetComponent<Text>().color = new Color(4 / 255f, 1, 0);
                Text.GetComponent<Text>().text = "+" + System.Math.Round(pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaPet,2);
            }
            else
            {
                Text.GetComponent<Text>().color = new Color(237 / 255f, 1, 0); 
                Text.GetComponent<Text>().text = "+" + pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaPet;
            }
            
            
        }

        Transform parent = pusherRewardItem.transform.parent;
        pusherRewardItem.SetActive(false);
        pusherRewardItem.transform.SetParent(BurdenImagist.Instance.RussiaTellBoard);
        if (parent.childCount == 0)
        {
            Destroy(parent.gameObject);
        }
        BurdenImagist.Instance.BigLoreRegime(pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaWick, pusherRewardItem.GetComponent<BurdenRegimeTell>().RussiaPet);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
