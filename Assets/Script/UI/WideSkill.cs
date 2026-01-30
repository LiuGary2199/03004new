using System.Collections;
using System.Collections.Generic;
using com.adjust.sdk;
using UnityEngine;
using UnityEngine.UI;

public class WideSkill : FirmUICharm
{
    public static WideSkill Instance;
[UnityEngine.Serialization.FormerlySerializedAs("goldBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("SlowFew")]    public Button BearWhy;
[UnityEngine.Serialization.FormerlySerializedAs("cashBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapFew")]public Button DeedWhy;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBtn")]    public Button HardwareJet;
    [UnityEngine.Serialization.FormerlySerializedAs("amazonBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetFew")]public Button LegumeWhy;
[UnityEngine.Serialization.FormerlySerializedAs("coinImg")]
[UnityEngine.Serialization.FormerlySerializedAs("GulfRed")]    public Image SlatCod;
[UnityEngine.Serialization.FormerlySerializedAs("cashImg")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]public Image DeedCod;
[UnityEngine.Serialization.FormerlySerializedAs("amazonImg")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRed")]public Image LegumeCod;
[UnityEngine.Serialization.FormerlySerializedAs("ballImg")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceRed")]public Image JulyCod;
[UnityEngine.Serialization.FormerlySerializedAs("cashBar")]
[UnityEngine.Serialization.FormerlySerializedAs("FlapRod")]    public GameObject DeedHis;
[UnityEngine.Serialization.FormerlySerializedAs("coinBar")]    [UnityEngine.Serialization.FormerlySerializedAs("GulfRod")]public GameObject SlatHis;
[UnityEngine.Serialization.FormerlySerializedAs("amazonBar")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetRod")]public GameObject LegumeHis;
[UnityEngine.Serialization.FormerlySerializedAs("ballBar")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceRod")]public GameObject JulyHis;
[UnityEngine.Serialization.FormerlySerializedAs("NormalWindow")]
[UnityEngine.Serialization.FormerlySerializedAs("DemiseHugely")]    public GameObject PatentIndoor;
[UnityEngine.Serialization.FormerlySerializedAs("PassWindow")]    [UnityEngine.Serialization.FormerlySerializedAs("PestHugely")]public GameObject SaltIndoor;
[UnityEngine.Serialization.FormerlySerializedAs("newgoldBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("CreviceFew")]public Button ExampleWhy;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeBar")]    [UnityEngine.Serialization.FormerlySerializedAs("CuspidorRod")]public GameObject AmenableHis;
[UnityEngine.Serialization.FormerlySerializedAs("ExchangeNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("CuspidorBedCent")]public Text AmenableElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("NewSettingBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("RubUnclearFew")]public Button RatAttemptWhy;
[UnityEngine.Serialization.FormerlySerializedAs("NewGoldNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("RubNeonBedCent")]public Text RatChopElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("goldNumText")]
[UnityEngine.Serialization.FormerlySerializedAs("SlowBedCent")]    public Text BearElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("cashNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("FlapBedCent")]public Text DeedElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("amazonNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("MagnetBedCent")]public Text LegumeElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ballNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("LuceBedCent")]public Text JulyElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("settingBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("GazetteFew")]    public Button VisitorWhy;
[UnityEngine.Serialization.FormerlySerializedAs("gemsStoreBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("TwigCaputFew")]public Button LawnRiderWhy;
[UnityEngine.Serialization.FormerlySerializedAs("testBtn")]   // public Button sohoShopBtn;
[UnityEngine.Serialization.FormerlySerializedAs("StunFew")]
    public Button WearWhy;
[UnityEngine.Serialization.FormerlySerializedAs("flyBoxController")]
[UnityEngine.Serialization.FormerlySerializedAs("AllPegDelectable")]    public RawKeyCongestion GemKeyCongestion;
[UnityEngine.Serialization.FormerlySerializedAs("TimeRewardBtn")]    public Button GridRegimeJet;
[UnityEngine.Serialization.FormerlySerializedAs("taskRewardBtn")]    public Button SaveRegimeJet;

    // Start is called before the first frame update
    void Start()
    {
        VisitorWhy.onClick.AddListener(() => { PatentBraceThinker.Instance.FirnAttemptSkill(); });
        RatAttemptWhy.onClick.AddListener(() => { PatentBraceThinker.Instance.FirnRatAttemptSkill(); });
        GridRegimeJet.onClick.AddListener(() => { UIManager.BisFeedback().FirnUICharm(nameof(ATimerPanel_A)); });
        SaveRegimeJet.onClick.AddListener(() => { UIManager.BisFeedback().FirnUICharm(nameof(ATaskPanel_B)); });
        LawnRiderWhy.onClick.AddListener(() => { PatentBraceThinker.Instance.FirnGrandmaRiderSkill(); });
        //sohoShopBtn.onClick.AddListener(() =>
        //{
        //    RatBoonVoiceCongestion.Instance.ShowCashMask();
        //    if (AkinSpanThinker.GetString(CChisel.msg_show_rate_us) == "new")
        //    {
        //        SelfSheerRibbon.GetInstance().SendEvent("1002");
        //        AkinSpanThinker.SetString(CChisel.msg_show_rate_us, "show");
        //    }

        //    VerbThinker.Instance.GameStop();
        ////  SOHOShopManager.instance.ShowRedeemPanel();
        //});
        HardwareJet.onClick.AddListener(() =>
        {
            UIManager.BisFeedback().FirnUICharm(nameof(ExceedAcid));

        });

        BearWhy.onClick.AddListener(() =>
        {
            if (BurrowLift.ItChair()) return;
            VerbThinker.Instance.WideRime();
            //SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });
        DeedWhy.onClick.AddListener(() =>
        {
            VerbThinker.Instance.WideRime();
          //  SOHOShopManager.instance.ShowRedeemPanel();
        });
        LegumeWhy.onClick.AddListener(() =>
        {
            VerbThinker.Instance.WideRime();
       //     SOHOShopManager.instance.ShowGoldAmazonRedeemPanel();
        });

        WearWhy.onClick.AddListener(() =>
        {
            // AddGold(5000, transform);
            // AddCash(5000,transform);
            // AddAmazon(5000,transform);
            // WideSpanThinker.GetInstance().AddGem(GemsType.Silver);
            // ButteThinker.Instance.StartSkillLong(true, 5);
            // ButteThinker.Instance.StartSkillWall(true, 8);
            // ButteThinker.Instance.ShowSlotNum();
            // ButteThinker.Instance.ShowCashCoinNum(2);
            PatentBraceThinker.Instance.FirnWarnUsSkill();
            // FecundSkillThinker.Instance.ShowCashRollReward();
        });

        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.On_WideRedwing,
            (messageData) =>
            {
                VerbThinker.Instance.WidePassage();
                TrolleyCrisis();
            });

        ShrubbyRejoinFleet.BisFeedback().Retrieve(CChisel.Son_Yale_Line_us,
            (messageData) =>
            {
                    Invoke(nameof(FirnWarnUsSkill),0.8f);
            });

        GemKeyCongestion.LoderAndReuseKey();
        if (BurrowLift.ItChair()) 
        {
            PatentIndoor.SetActive(false);
            SaltIndoor.SetActive(true);
        }
        else
        {
            PatentIndoor.SetActive(true);
            SaltIndoor.SetActive(false);
        }
}

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    public override void Display()
    {
        base.Display();

        ///sohoShopBtn.gameObject.SetActive(!BurrowLift.IsApple());
        //cashBar.gameObject.SetActive(!BurrowLift.IsApple());
       // amazonBar.gameObject.SetActive(!BurrowLift.IsApple());
        JulyHis.gameObject.SetActive(!BurrowLift.ItChair());
        AmenableHis.gameObject.SetActive(BurrowLift.ItChair());
        // gemsStoreBtn.gameObject.SetActive(!BurrowLift.IsApple());
        print("adid: " + Adjust.getAdid());
        TrolleyCrisis();
      

    }

    private void FirnWarnUsSkill()
    {
        PatentBraceThinker.Instance.FirnWarnUsSkill();
    }

    public void TrolleyCrisis()
    {
        BearElkLoss.text = WideSpanThinker.BisFeedback().BisChop() + "";
        RatChopElkLoss.text = WideSpanThinker.BisFeedback().BisChop() + "";
        DeedElkLoss.text = CartonLift.HeydayMyEke(WideSpanThinker.BisFeedback().BisBill());
        LegumeElkLoss.text = WideSpanThinker.BisFeedback().BisChisel() + "";
        JulyElkLoss.text = WideSpanThinker.BisFeedback().BisRice() + "";
        AmenableElkLoss.text = WideSpanThinker.BisFeedback().BisRice() + "";
    }

    public void BisChop(double gold, Transform objTrans = null)
    {
        WideSpanThinker.BisFeedback().BisChop(gold);
        ChopBisExemplify(objTrans, 5);
    }

    public void BisBill(double cash, Transform objTrans = null)
    {
        WideSpanThinker.BisFeedback().BisBill(cash);
        BillBisExemplify(objTrans, 5);
    }

    public void BisChisel(double amazon, Transform objTrans = null)
    {
        WideSpanThinker.BisFeedback().BisChisel(amazon);
        ChiselBisExemplify(objTrans, 5);
    }

    private void ChopBisExemplify(Transform startTransform, double num)
    {
       
        if (BurrowLift.ItChair()) 
        {
            BisExemplify(startTransform, SlatCod.transform, SlatCod.gameObject, RatChopElkLoss,WideSpanThinker.BisFeedback().BisChop(), num);
        } else
        {
            BisExemplify(startTransform, SlatCod.transform, SlatCod.gameObject, BearElkLoss,WideSpanThinker.BisFeedback().BisChop(), num);
        }

    }

    //  加现金动画
    private void BillBisExemplify(Transform startTransform, double num)
    {
        BisExemplify(startTransform, DeedCod.transform, DeedCod.gameObject, DeedElkLoss,
            WideSpanThinker.BisFeedback().BisBill(), num);
    }

    // 加亚马逊币动画
    private void ChiselBisExemplify(Transform startTransform, double num)
    {
        BisExemplify(startTransform, LegumeCod.transform, LegumeCod.gameObject, LegumeElkLoss,
            WideSpanThinker.BisFeedback().BisChisel(), num);
    }

    private void BisExemplify(Transform startTransform, Transform endTransform, GameObject icon, Text text,
        double textValue, double num)
    {
        if (startTransform != null)
        {
            ExemplifyCongestion.ChopGazeDart(icon, Mathf.Max((int) num, 1), startTransform, endTransform,
                () =>
                {
                    GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_getcoin);
                    ExemplifyCongestion.SteppeCarton(double.Parse(text.text), textValue, 0.1f, text,
                        () => { text.text = CartonLift.HeydayMyEke(textValue); });
                });
        }
        else
        {
            ExemplifyCongestion.SteppeCarton(double.Parse(text.text), textValue, 0.1f, text,
                () => { text.text = CartonLift.HeydayMyEke(textValue); });
        }
    }
}