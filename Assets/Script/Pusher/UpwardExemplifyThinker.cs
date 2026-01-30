using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class UpwardExemplifyThinker : MonoBehaviour
{
    static public UpwardExemplifyThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("push")]    [UnityEngine.Serialization.FormerlySerializedAs("Stem")]public GameObject Tour;
[UnityEngine.Serialization.FormerlySerializedAs("slotBox")]    [UnityEngine.Serialization.FormerlySerializedAs("PestPeg")]public GameObject SaltKey;
[UnityEngine.Serialization.FormerlySerializedAs("skillWallGroup")]    [UnityEngine.Serialization.FormerlySerializedAs("DraftLakeCreep")]public GameObject PerryAcidPhase;
[UnityEngine.Serialization.FormerlySerializedAs("ballCreater")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceFinnish")]public RiceVibrant JulyVibrant;
    Sequence TourTax;
    Sequence SaltKeyTax;
    float UntrueEase= -2.0f;
    float HayEase= -3f;
    float TourGazeTilt= 1.5f;
    float TourImperial= 1f;
    float TenthPoleGazeTilt= 0.3f;
    float TenthPoleImperial= 0f;
    float TourRid= -4.7f;

    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        Tour.transform.position = new Vector3(Tour.transform.position.x, Tour.transform.position.y, 0.5f);
        Yean_z = Tour.transform.position.z;
        SaltKey.transform.localPosition = new Vector3(-1, SaltKey.transform.localPosition.y, SaltKey.transform.localPosition.z);
    }

    /// <summary>
    /// �ư��ʼλ��
    /// </summary>
    float Yean_z;
    /// <summary>
    /// ��ʼ�Ʊ�
    /// </summary>
    public void TourReuseGaze(bool needRefresh = false)
    {
        TourTax.Kill();
        
        float moveZ = UntrueEase;
        float time = TourGazeTilt;
        float interval = TourImperial;
        if (ToOnBisEase)
        {
            moveZ = HayEase;
        }
        bool needBlock = false;
        
        if (BurdenImagist.Instance.GoBusyAdorn)
        {
            time = TenthPoleGazeTilt;
            interval = TenthPoleImperial; 
        }
        if (ToPoleRid)
        {
            time = TourGazeTilt;
            ToPoleRid = false;
            moveZ = TourRid;
            needBlock = true;
        }
        TourTax = DOTween.Sequence();
        if (needRefresh)
        {
            TourTax.Append(Tour.GetComponent<Rigidbody>().DOMoveZ(Yean_z + moveZ, time * ((Yean_z + moveZ - Tour.transform.position.z) / moveZ)).SetEase(Ease.Linear));
        }
        else
        {
            TourTax.AppendInterval(interval);
            TourTax.Append(Tour.GetComponent<Rigidbody>().DOMoveZ(Yean_z + moveZ, time).SetEase(Ease.Linear));
        }
        TourTax.AppendInterval(interval);
        TourTax.Append(Tour.GetComponent<Rigidbody>().DOMoveZ(Yean_z, time).SetEase(Ease.Linear));
        TourTax.AppendCallback(() =>
        {
            if (needBlock)
            {
                TourRidFunnel();
            }
            TourReuseGaze();
        });
        TourTax.Play();

    }
    /// <summary>
    /// ��ͣ�Ʊ�
    /// </summary>
    public void TourOfferGaze()
    {
        TourTax.Pause();
        SaltKeyTax.Pause();
    }
    /// <summary>
    /// �ָ��Ʊ�
    /// </summary>
    public void TourEncaseGaze()
    {
        TourTax.Play();
        SaltKeyTax.Play();
    }


    /// <summary>
    /// �Ƿ����ӳ�״̬
    /// </summary>
    bool ToOnBisEase= false;
    /// <summary>
    /// ����ӳ��ĳ���ʱ��
    /// </summary>
    float WokEaseTilt= 0;
    /// <summary>
    /// �ӳ��ư忪ʼ(��ʼ��������ʱ/ˢ�¶���״̬)
    /// </summary>
    /// <param name="time"></param>
    public void TourBisEase(float time)
    {
        WokEaseTilt += time;
        SpanLayoutThinker.BisFeedback().YaleButteEaseTilt(!ToOnBisEase, (int)time);
        if (!ToOnBisEase)
        {
            ToOnBisEase = true;
            float alreadyPlay = TourTax.ElapsedPercentage();
            if (alreadyPlay < 0.5f)
            {
                TourReuseGaze(true);
            }
            StartCoroutine(nameof(WokEaseFewRollTilt));
        }
    }
    /// <summary>
    /// ��ʱ�رռӳ�
    /// </summary>
    /// <returns></returns>
    IEnumerator WokEaseFewRollTilt()
    {
        float t = 0;
        while (t < WokEaseTilt)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        WokEaseTilt = 0;
        ToOnBisEase = false;
    }


    /// <summary>
    /// �Ƿ��Ѿ�����ǽ
    /// </summary>
    bool ToAnAcidOn= false;
    /// <summary>
    /// ǽ����ʣ��ʱ��
    /// </summary>
    float HoleOnTilt= 0;
    /// <summary>
    /// ����ǽ����
    /// </summary>
    /// <param name="time"></param>
    public void AgeAcidOn(float time)
    {
        HoleOnTilt += time;
        SpanLayoutThinker.BisFeedback().YaleButteAcidTilt(!ToAnAcidOn, (int)time);
        if (!ToAnAcidOn)
        {
            PerryAcidPhase.transform.DOMoveY(0, 0.3f);
            StartCoroutine(nameof(HoleOnFewRollTilt));
        }
    }
    /// <summary>
    /// ����ǽ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator HoleOnFewRollTilt()
    {
        int t = 0;
        while (t < HoleOnTilt)
        {
            yield return new WaitForSeconds(1);
            t++;
        }
        HoleOnTilt = 0;
        ToAnAcidOn = false;
        AgeAcidAnew();
    }
    /// <summary>
    /// ����ǽ����
    /// </summary>
    public void AgeAcidAnew()
    {
        PerryAcidPhase.transform.DOMoveY(-0.8f, 0.3f);
    }


    /// <summary>
    /// �Ƿ���Ҫȫ������
    /// </summary>
    bool ToPoleRid= false;
    /// <summary>
    /// ȫ�����»ص�
    /// </summary>
    System.Action TourRidFunnel;
    /// <summary>
    /// ȫ������
    /// </summary>
    public void TourRidGaze(System.Action block)
    {
        TourRidFunnel = block;
        ToPoleRid = true;
        float alreadyPlay = TourTax.ElapsedPercentage();
        if (alreadyPlay < 0.5f)
        {
            TourReuseGaze(true);
        }
    }


    

    /// <summary>
    /// slot�п�ʼ�ƶ�
    /// </summary>
    public void RagReuseGaze()
    {
        float moveX = 2f;
        float x= SaltKey.transform.position.x;
        SaltKeyTax = DOTween.Sequence();
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DOMoveX(x + moveX, 2));
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 90), 0.5f));
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        SaltKeyTax.AppendInterval(0.5f);
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DOMoveX(x, 2));
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, -90), 0.5f));
        SaltKeyTax.Append(SaltKey.GetComponent<Rigidbody>().DORotate(new Vector3(0, 0, 0), 0.5f));
        SaltKeyTax.AppendInterval(0.5f);
        SaltKeyTax.SetLoops(-1);
        SaltKeyTax.Play();
    }
    /// <summary>
    /// ��ͣslot��
    /// </summary>
    public void SaltKeyOfferGaze()
    {
        SaltKeyTax.Pause();
    }
    /// <summary>
    /// �ָ�slot��
    /// </summary>
    public void SaltKeyEncaseGaze()
    {
        SaltKeyTax.Restart();
    }

    /// <summary>
    /// slot�йر�
    /// </summary>
    public void HappyPlugKey()
    {
        SaltKey.SetActive(false);
    }


    void Start()
    {
        //�趨�ư��ʼλ��
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
