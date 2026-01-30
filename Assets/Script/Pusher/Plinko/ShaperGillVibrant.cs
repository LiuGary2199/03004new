using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Lofelt.NiceVibrations;

public class ShaperGillVibrant : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("index")]    [UnityEngine.Serialization.FormerlySerializedAs("Shock")]public int Aphid;
[UnityEngine.Serialization.FormerlySerializedAs("count")]    [UnityEngine.Serialization.FormerlySerializedAs("Giant")]public int Trash;
[UnityEngine.Serialization.FormerlySerializedAs("countImage")]    [UnityEngine.Serialization.FormerlySerializedAs("GiantHoney")]public SpriteRenderer TrashSword;
    int VeinTrove;
    /// <summary>
    /// ��ײ������Ҳ�ˢ�½�ҿ�����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            //GooseUSA.GetInstance().PlayEffect(GooseCity.SceneMusic.sound_drop_ball,0.1f);
            collision.gameObject.SetActive(false);
            if (Trash >= 1)
            {
                SaltBoonGill(Trash);
                if (!BurdenImagist.Instance.GoBusyAdorn)
                {
                    RetrainTrove();
                }
            }
        }
    }

    void RetrainTrove()
    {
        Trash = SpanLayoutThinker.BisFeedback().RoeShaperGillTrove(Aphid);
        TrashSword.sprite = Resources.Load<Sprite>(CChisel.KeyTrove + Trash);
    }

    public void SaltBoonGill(int c)
    {
        VeinTrove += c;
        if (VeinTrove == c)
        {
            StartCoroutine(SaltBoonGillRollTilt());
        }
    }

    /// <summary>
    /// ��ʱ�ͷŶ�����
    /// </summary>
    /// <returns></returns>
    IEnumerator SaltBoonGillRollTilt()
    {
        while(VeinTrove > 0)
        {
            VeinTrove--;
            SaltGill();
            yield return new WaitForSeconds(0.1f);
        }
    }
    /// <summary>
    /// ��ʼ�����λ�ò��ͷ�
    /// </summary>
    void SaltGill()
    {
        if (BurdenImagist.Instance.GoVivid)
        {
            return;
        }
       
        if (!BurdenImagist.Instance.GoBusyAdorn)
        {
            GameObject coin = BurdenImagist.Instance.BigRegimeTell(PusherRewardType.CoinGold);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(Random.Range(0, 10), RoeCoyoteMoment(), Random.Range(0, 10));
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-30f,30f) * 0.8f, Random.Range(180f,270f) * 0.8f, Random.Range(-50f,-80f) * 0.8f));
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            GameObject coin = BurdenImagist.Instance.BigRegimeTell(Random.Range(0,2) == 0 ? PusherRewardType.CoinGold : PusherRewardType.CoinCash);
            coin.transform.position = transform.position + new Vector3(0, 0, -0.5f);
            coin.transform.eulerAngles = new Vector3(RoeCoyoteMoment(), RoeCoyoteMoment(), RoeCoyoteMoment());
            coin.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-10f,10f) * 0.8f, Random.Range(300f,450f) * 0.8f, Random.Range(-30f,-40f) * 0.8f));
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
        AgeInduct();
    }
    /// <summary>
    /// �Ƿ������
    /// </summary>
    bool AidInduct= true;
    /// <summary>
    /// ��ʼ��
    /// </summary>
    void AgeInduct()
    {
        if (AidInduct)
        {
            AidInduct = false;
            HapticPatterns.PlayPreset(HapticPatterns.PresetType.LightImpact);
            StartCoroutine(FrenchSunsetRollTilt());
        }
        
    }
    /// <summary>
    /// �𶯽�����ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator FrenchSunsetRollTilt()
    {
        yield return new WaitForSeconds(0.1f);
        AidInduct = true;
    }
    /// <summary>
    /// ��ȡ����Ƕ�
    /// </summary>
    /// <returns></returns>
    float RoeCoyoteMoment()
    {
        return Random.Range(0, 360f);
    }


    /// <summary>
    /// feverģʽ��ˢ�±���
    /// </summary>
    public void TenthReuseTrolley(int c)
    {
        Trash = c;
        TrashSword.sprite = Resources.Load<Sprite>(CChisel.KeyTrove + Trash);
    }
    /// <summary>
    /// fever����ˢ��
    /// </summary>
    /// <param name="count"></param>
    public void TenthFewTrolley()
    {
        RetrainTrove();
    }

    // Start is called before the first frame update
    void Start()
    {
        //��ʼ����ҿ�����
        RetrainTrove();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
