using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExceedAcid : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("ChangeBtn")]    public Button ExceedJet;
[UnityEngine.Serialization.FormerlySerializedAs("CanNotBtn")]    public Button YouMarJet;
[UnityEngine.Serialization.FormerlySerializedAs("CloseBtn")]    public Button JointJet;
[UnityEngine.Serialization.FormerlySerializedAs("CashText")]    public Text DireGlow;
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public Text AcidGlow;
[UnityEngine.Serialization.FormerlySerializedAs("FlapRed")]    public Transform DeedCod;
    private void Start()
    {
        YouMarJet.onClick.AddListener(() =>
        {
            CheerThinker.BisFeedback().FirnCheer("Not enough gold coins");
        });
        ExceedJet.onClick.AddListener(() =>
        {
            ExceedJet.enabled = false;
            double haveCoin = WideSpanThinker.BisFeedback().BisChop();
            double coinNeed = TanGenuUSA.instance.Hardware[0];
            double cashNeed = TanGenuUSA.instance.Hardware[1];
            if (haveCoin >= coinNeed)
            {
                WideSpanThinker.BisFeedback().BisChop(- coinNeed);
               // WideSpanThinker.YewVocation().YewSuch( cashNeed);
                CheerThinker.BisFeedback().FirnCheer("Exchange successful");
                WideSkill.Instance.TrolleyCrisis();
                WideSkill.Instance.BisBill(cashNeed, DeedCod.transform);
                HappyUIMust(GetType().Name);
            }
            else
            {
                
                CheerThinker.BisFeedback().FirnCheer("Not enough gold coins");
            }
            PryUI();
        });
        JointJet.onClick.AddListener(() =>
        {
            HappyUIMust(GetType().Name);
        });

    }
    public override void Display()
    {
        base.Display();
        VerbThinker.Instance.WideRime();
        PryUI();
    }

    public void PryUI()
    {
        ExceedJet.enabled = true;
        double haveCoin = WideSpanThinker.BisFeedback().BisChop();
        double coinNeed = TanGenuUSA.instance.Hardware[0];
        double cashNeed = TanGenuUSA.instance.Hardware[1];
        DireGlow.text = cashNeed.ToString();
        AcidGlow.text = coinNeed.ToString();
        if (haveCoin >= coinNeed)
        {
            YouMarJet.gameObject.SetActive(false);
        }
        else
        {
            YouMarJet.gameObject.SetActive(true);
        }
    }

    public override void Hidding()
    {
        base.Hidding();
        VerbThinker.Instance.WidePassage();
    }
}
