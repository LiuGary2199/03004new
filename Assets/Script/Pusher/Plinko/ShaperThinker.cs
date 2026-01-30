using Lofelt.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaperThinker : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("shootPoint")]    [UnityEngine.Serialization.FormerlySerializedAs("FetusHairy")]public GameObject LoverBlaze;
[UnityEngine.Serialization.FormerlySerializedAs("ballPerfab")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceTablet")]public GameObject JulyCompel;
[UnityEngine.Serialization.FormerlySerializedAs("ballPanel")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceScore")]public GameObject JulySkill;
[UnityEngine.Serialization.FormerlySerializedAs("plateWidth")]    [UnityEngine.Serialization.FormerlySerializedAs("TowerLight")]public float TroutAuger;
[UnityEngine.Serialization.FormerlySerializedAs("allWidth")]    [UnityEngine.Serialization.FormerlySerializedAs("OatLight")]public float OatAuger;
[UnityEngine.Serialization.FormerlySerializedAs("allBoxList")]    [UnityEngine.Serialization.FormerlySerializedAs("OatPegGerm")]public List<ShaperGillVibrant> LogKeyThen;
[UnityEngine.Serialization.FormerlySerializedAs("ballPool")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceTomb")]public GameThinker JulyGame;
    bool AllayBore;
    static public ShaperThinker Instance;
    private void Awake()
    {
        Instance = this;
    }
    /// <summary>
    /// ����
    /// </summary>
    /// <param name="drop_x"></param>
    public void SaltRice(float drop_x)
    {
        if (BurdenImagist.Instance.GoVivid)
        {
            return;
        }
        HapticPatterns.PlayPreset(HapticPatterns.PresetType.MediumImpact);
        float scale = 0.45f;
        GameObject ball = JulyGame.BisPiston();
        ball.transform.position = new Vector3(drop_x, LoverBlaze.transform.position.y, LoverBlaze.transform.position.z);
        ball.transform.localScale = new Vector3(scale, scale, scale);
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20));
    }

    public void DireGill(float drop_x)
    {
        if (BurdenImagist.Instance.GoVivid)
        {
            return;
        }
        GameObject coin = BurdenImagist.Instance.BigRegimeTell(PusherRewardType.CoinGold);
        coin.transform.position = new Vector3(drop_x, 8f, -1f);
        coin.transform.eulerAngles = new Vector3(RoeCoyoteMoment(), RoeCoyoteMoment(), RoeCoyoteMoment());
        coin.GetComponent<Rigidbody>().AddForce(0f, -5f, 0f);
        if (!BurdenImagist.Instance.GoBusyAdorn)
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_creat_coin, 0.1f);
        }
        else
        {
            GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_creat_coin_fever, 0.1f);
        }
    }
    /// <summary>
    /// ���������
    /// </summary>
    /// <returns></returns>
    IEnumerator AllaySunsetRollTilt()
    {
        yield return new WaitForSeconds(CartonLift.AgeHappenOught(TanGenuUSA.instance.WideSpan.base_config.touch_cd));
        AllayBore = false;
    }

    /// <summary>
    /// ��ͣȫ��С��
    /// </summary>
    public void TheftRidRice()
    {
        for (int i = 0; i < JulyGame.Spin.Count; i++)
        {
            JulyGame.Spin[i].GetComponent<PersevereOffer>().TheftPersevere();
        }
    }
    /// <summary>
    /// �ָ�ȫ��С��
    /// </summary>
    public void QuiverRidRice()
    {
        for (int i = 0; i < JulyGame.Spin.Count; i++)
        {
            JulyGame.Spin[i].GetComponent<PersevereOffer>().QuiverPersevere();
        }
    }


    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void TenthReuseKeyTrolley(int c)
    {
        foreach (ShaperGillVibrant creater in LogKeyThen)
        {
            creater.TenthReuseTrolley(c);
        }
    }
    /// <summary>
    /// plinko�� ����fever
    /// </summary>
    public void TenthFewKeyTrolley()
    {
        foreach (ShaperGillVibrant creater in LogKeyThen)
        {
            creater.TenthFewTrolley();
        }
    }
    /// <summary>
    /// fever ��ʼ�Զ�����
    /// </summary>
    public void TenthReuseGameDireRice()
    {
        StartCoroutine(nameof(BiteDireRiceRollTilt));
    }
    /// <summary>
    /// fever �����Զ�����
    /// </summary>
    public void TenthFewGameDireRice()
    {
        StopCoroutine(nameof(BiteDireRiceRollTilt));
    }
    /// <summary>
    /// fever �Զ������ʱ
    /// </summary>
    /// <returns></returns>
    IEnumerator BiteDireRiceRollTilt()
    {
        while (BurdenImagist.Instance.GoBusyAdorn)
        {
            if (BurrowLift.ItChair())
            {
                DireGill(Random.Range(-TroutAuger / 2, TroutAuger / 2));
                DireGill(Random.Range(-TroutAuger / 2, TroutAuger / 2));
                DireGill(Random.Range(-TroutAuger / 2, TroutAuger / 2));
            }
            else
            {
                SaltRice(Random.Range(-TroutAuger / 2, TroutAuger / 2));
            }
            yield return new WaitForSeconds(0.3f);
        }

    }

    /// <summary>
    /// һ��������������
    /// </summary>
    /// <param name="count"></param>
    public void ChiefJeanGill(int count)
    {
        foreach (ShaperGillVibrant creater in LogKeyThen)
        {
            creater.SaltBoonGill(count);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        JulyGame.BiteGameThinker(JulyCompel, JulyGame.transform, 50, "Ball");
        if (BurrowLift.ItChair())
        {
            JulySkill.gameObject.SetActive(false);

        }
        else
        {
            JulySkill.gameObject.SetActive(true);
        }
    }
    float RoeCoyoteMoment()
    {
        return Random.Range(0, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Application.platform == RuntimePlatform.Android ||
                        Application.platform == RuntimePlatform.IPhonePlayer)
            {
                int fingerId = Input.GetTouch(0).fingerId;
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(fingerId))
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            ////����ƽ̨
            else
            {
                if (UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("�����UI");
                    return;
                }
            }
            if (!AllayBore)
            {
                if (BurrowLift.ItChair())
                {
                    if (!CubanRiceThinker.Instance.DireGillMawChair()) return;
                    float coin_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (TroutAuger / 2);
                    DireGill(coin_x);
                }
                else
                {
                    // �Ƿ���С��
                    if (!CubanRiceThinker.Instance.DireRice()) return;
                    AllayBore = true;
                    StartCoroutine(nameof(AllaySunsetRollTilt));
                    float drop_x = 0;
                    drop_x = (Input.mousePosition.x - Screen.width / 2) / (Screen.width / 2) * (TroutAuger / 2);
                    AkinSpanThinker.GapFew("DropBallCount", AkinSpanThinker.BisFew("DropBallCount") + 1);
                    SaltRice(drop_x);
                }
            }

        }
    }
}
