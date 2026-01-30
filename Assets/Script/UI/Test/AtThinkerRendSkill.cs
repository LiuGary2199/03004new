using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtThinkerRendSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("LastPlayTimeCounterText")]    [UnityEngine.Serialization.FormerlySerializedAs("PrayBillFastDynastyCent")]public Text OverLionTiltGaseousLoss;
[UnityEngine.Serialization.FormerlySerializedAs("Counter101Text")]    [UnityEngine.Serialization.FormerlySerializedAs("Dynasty101Cent")]public Text Gaseous101Loss;
[UnityEngine.Serialization.FormerlySerializedAs("Counter102Text")]    [UnityEngine.Serialization.FormerlySerializedAs("Dynasty102Cent")]public Text Gaseous102Loss;
[UnityEngine.Serialization.FormerlySerializedAs("Counter103Text")]    [UnityEngine.Serialization.FormerlySerializedAs("Dynasty103Cent")]public Text Gaseous103Loss;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumText")]    [UnityEngine.Serialization.FormerlySerializedAs("LooseBedCent")]public Text BladeElkLoss;
[UnityEngine.Serialization.FormerlySerializedAs("PlayRewardedAdButton")]    [UnityEngine.Serialization.FormerlySerializedAs("BillAppetiteMyHandle")]public Button LionInformalAtAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("PlayInterstitialAdButton")]    [UnityEngine.Serialization.FormerlySerializedAs("BillHelplessnessMyHandle")]public Button LionTavernkeeperAtAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("NoThanksButton")]    [UnityEngine.Serialization.FormerlySerializedAs("WeLaunchHandle")]public Button ToMutualAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("TrialNumButton")]    [UnityEngine.Serialization.FormerlySerializedAs("LooseBedHandle")]public Button BladeElkAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    [UnityEngine.Serialization.FormerlySerializedAs("PianoHandle")]public Button HappyAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("TimeInterstitialText")]    [UnityEngine.Serialization.FormerlySerializedAs("FastHelplessnessCent")]public Text TiltTavernkeeperLoss;
[UnityEngine.Serialization.FormerlySerializedAs("PauseTimeInterstitialButton")]    [UnityEngine.Serialization.FormerlySerializedAs("DecayFastHelplessnessHandle")]public Button OfferTiltTavernkeeperAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("ResumeTimeInterstitialButton")]    [UnityEngine.Serialization.FormerlySerializedAs("InventFastHelplessnessHandle")]public Button EncaseTiltTavernkeeperAnimal;

    private void Start()
    {
        InvokeRepeating(nameof(FirnGaseousLoss), 0, 0.5f);

        HappyAnimal.onClick.AddListener(() => {
            HappyUIMust(GetType().Name);
        });

        LionInformalAtAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.DeepFecundAward((success) => { }, "10");
        });

        LionTavernkeeperAtAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.SkinTavernkeeperAt(1);
        });

        ToMutualAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.ToMutualBisTrove();
        });

        BladeElkAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.SnuglyBladeElk(AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie) + 1);
            BladeElkLoss.text = AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie).ToString();
        });

        OfferTiltTavernkeeperAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.OfferTiltTavernkeeper();
            FirnOfferTiltTavernkeeper();
        });

        EncaseTiltTavernkeeperAnimal.onClick.AddListener(() => {
            ADThinker.Feedback.EncaseTiltTavernkeeper();
            FirnOfferTiltTavernkeeper();
        });

    }

    public override void Display()
    {
        base.Display();
        BladeElkLoss.text = AkinSpanThinker.BisFew(CChisel.Ox_To_Buggy_Tie).ToString();
        FirnOfferTiltTavernkeeper();
    }

    private void FirnGaseousLoss()
    {
        OverLionTiltGaseousLoss.text = ADThinker.Feedback.BoatLionTiltGaseous.ToString();
        Gaseous101Loss.text = ADThinker.Feedback.Liberty101.ToString();
        Gaseous102Loss.text = ADThinker.Feedback.Toehold102.ToString();
        Gaseous103Loss.text = ADThinker.Feedback.Toehold103.ToString();
    }

    private void FirnOfferTiltTavernkeeper()
    {
        TiltTavernkeeperLoss.text = ADThinker.Feedback.TheftTiltTavernkeeper ? "已暂停" : "未暂停";
    }
}
