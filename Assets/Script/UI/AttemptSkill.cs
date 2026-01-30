using Lofelt.NiceVibrations;
using UnityEngine;
using UnityEngine.UI;

public class AttemptSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("musicBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("CliffFew")]public Button TulipWhy;
[UnityEngine.Serialization.FormerlySerializedAs("soundBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("GroupFew")]public Button BoardWhy;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationBtn")]    [UnityEngine.Serialization.FormerlySerializedAs("TraditionFew")]public Button RebellionWhy;
[UnityEngine.Serialization.FormerlySerializedAs("closeBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("ChainFew")]    public Button SlushWhy;
[UnityEngine.Serialization.FormerlySerializedAs("musicOn")]
[UnityEngine.Serialization.FormerlySerializedAs("CliffHe")]    public GameObject TulipHe;
[UnityEngine.Serialization.FormerlySerializedAs("musicOff")]    [UnityEngine.Serialization.FormerlySerializedAs("CliffAny")]public GameObject TulipDot;
[UnityEngine.Serialization.FormerlySerializedAs("soundOn")]    [UnityEngine.Serialization.FormerlySerializedAs("GroupHe")]public GameObject BoardIt;
[UnityEngine.Serialization.FormerlySerializedAs("soundOff")]    [UnityEngine.Serialization.FormerlySerializedAs("GroupAny")]public GameObject BoardDot;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOn")]    [UnityEngine.Serialization.FormerlySerializedAs("TraditionHe")]public GameObject RebellionIt;
[UnityEngine.Serialization.FormerlySerializedAs("vibrationOff")]    [UnityEngine.Serialization.FormerlySerializedAs("TraditionAny")]public GameObject RebellionDot;

    private string RebellionKey;

    protected override void Awake()
    {
        base.Awake();
        RebellionKey = "sv_vibrationType";
        if (!PlayerPrefs.HasKey(RebellionKey))
        {
            AkinSpanThinker.GapFew(RebellionKey, 1);
        }
    }

    public override void Display()
    {
        base.Display();
        ADThinker.Feedback.OfferTiltTavernkeeper();
        TulipHe.gameObject.SetActive(GooseUSA.BisFeedback().OxGooseIndian);
        TulipDot.gameObject.SetActive(!GooseUSA.BisFeedback().OxGooseIndian);

        BoardIt.gameObject.SetActive(GooseUSA.BisFeedback().RotateGooseIndian);
        BoardDot.gameObject.SetActive(!GooseUSA.BisFeedback().RotateGooseIndian);

        RebellionIt.gameObject.SetActive(AkinSpanThinker.BisFew(RebellionKey) == 1);
        RebellionDot.gameObject.SetActive(AkinSpanThinker.BisFew(RebellionKey) != 1);
    }
    public override void Hidding()
    {
        base.Hidding();
        ADThinker.Feedback.EncaseTiltTavernkeeper();
    }
    // Start is called before the first frame update
    void Start()
    {
        SlushWhy.onClick.AddListener(() =>
        {
            VerbThinker.Instance.WidePassage();
            if (BurrowLift.ItChair()) 
            {
                HappyUIMust(nameof(RatHuntAttemptSkill));
            }
            else
            {
                HappyUIMust(GetType().Name);
            }
        });

        TulipWhy.onClick.AddListener(() =>
        {
            GooseUSA.BisFeedback().OxGooseIndian = !GooseUSA.BisFeedback().OxGooseIndian;
            TulipHe.gameObject.SetActive(GooseUSA.BisFeedback().OxGooseIndian);
            TulipDot.gameObject.SetActive(!GooseUSA.BisFeedback().OxGooseIndian);
        });
        BoardWhy.onClick.AddListener(() =>
        {
            GooseUSA.BisFeedback().RotateGooseIndian = !GooseUSA.BisFeedback().RotateGooseIndian;
            BoardIt.gameObject.SetActive(GooseUSA.BisFeedback().RotateGooseIndian);
            BoardDot.gameObject.SetActive(!GooseUSA.BisFeedback().RotateGooseIndian);
        });

        RebellionWhy.onClick.AddListener(() =>
        {
            int vibrationType = AkinSpanThinker.BisFew(RebellionKey) * -1;
            RebellionIt.gameObject.SetActive((vibrationType == 1));
            RebellionDot.gameObject.SetActive((vibrationType != 1));
            AkinSpanThinker.GapFew(RebellionKey, vibrationType);
            HapticController.hapticsEnabled = (vibrationType == 1);
        });
    }
}