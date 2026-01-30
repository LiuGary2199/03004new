using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerbThinker : MonoBehaviour
{
    public static VerbThinker Instance;
[UnityEngine.Serialization.FormerlySerializedAs("pushObj")]
[UnityEngine.Serialization.FormerlySerializedAs("StemGel")]    public GameObject TourWok;
[UnityEngine.Serialization.FormerlySerializedAs("slotObj")]    [UnityEngine.Serialization.FormerlySerializedAs("PestGel")]public GameObject SaltWok;
[UnityEngine.Serialization.FormerlySerializedAs("gameLock")]
[UnityEngine.Serialization.FormerlySerializedAs("HostOnly")]    public bool GlenBore;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GooseUSA.BisFeedback().BiteGooseUSA();
        ShrubbyRejoinFleet.BisFeedback()
            .Retrieve(CChisel.Son_Slush_Aphid_Sap_Alter, (messageData) => { WidePassage(); });
    }

    public void GlenBite()
    {
        bool isNewPlayer = !PlayerPrefs.HasKey(CChisel.Ox_ItRatVictim + "Bool") || AkinSpanThinker.BisLuck(CChisel.Ox_ItRatVictim);
        VagaryBiteThinker.Instance.BiteVagarySpan(isNewPlayer);
        if (isNewPlayer)
        {
            // 新用户
            AkinSpanThinker.GapLuck(CChisel.Ox_ItRatVictim, false);
        }
        
        SelfSheerRibbon.BisFeedback().CastSheer("1001");
        GooseUSA.BisFeedback().LionOx(GooseCity.UIMusic.sound_bgm);
    
        WideSpanThinker.BisFeedback().BiteWideSpan();
        UIManager.BisFeedback().FirnUICharm(nameof(WideSkill));
        TourWok.gameObject.SetActive(true);
        SaltWok.gameObject.SetActive(true);
        TanGenuUSA.instance.ToThinker.SetActive(true);
        if (BurrowLift.ItChair())
        {
            WideSpanThinker.BisFeedback().FancyWitStingerAngryWrite();
            WideSpanThinker.BisFeedback().FancyDieStingerValveFigure();
            WideSpanThinker.BisFeedback().AshcanEssayAppreciablyFile();
        }
    }

    public void TastePlug()
    {
        UpwardPlugKeyAstonish.Instance.MyGoPlug();
    }

    public void WidePassage()
    {
        GlenBore = false;
        PatentBraceThinker.Instance.ToBore = false;
        if (BurrowLift.ItChair())
        { 
            RatCruelTiltThinker.Instance.MyReuseCruelTilt();

        }
        else 
        {
            CruelTiltThinker.Instance.MyReuseCruelTilt(); 
        }
        RawKeyCongestion.Instance.ImpulseKey();
        BurdenImagist.Instance.ChurchBurden();
        TastePlug();
    }

    public void WideRime()
    {
        GlenBore = true;
        if (BurrowLift.ItChair())
        { 
            RatCruelTiltThinker.Instance.RimeCruel(); 
        } 
        else 
        {
            CruelTiltThinker.Instance.RimeCruel();
        }
        RawKeyCongestion.Instance.RimeKey();
        BurdenImagist.Instance.IssueBurden();
    }
}