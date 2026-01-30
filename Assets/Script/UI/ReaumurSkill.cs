using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;
using UnityEngine.SceneManagement;

public class ReaumurSkill : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    [UnityEngine.Serialization.FormerlySerializedAs("UnwellHoney")]public Image PotatoSword;
[UnityEngine.Serialization.FormerlySerializedAs("PassSliderImage")]    [UnityEngine.Serialization.FormerlySerializedAs("PestEmployHoney")]public Image SaltSectorSword;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    [UnityEngine.Serialization.FormerlySerializedAs("DirectorCent")]public Text RegionalLoss;
[UnityEngine.Serialization.FormerlySerializedAs("titleAnim")]    [UnityEngine.Serialization.FormerlySerializedAs("SpaceFair")]public SkeletonGraphic BylawPloy;
    AsyncOperation LoyalWant;
[UnityEngine.Serialization.FormerlySerializedAs("gamebg")]
[UnityEngine.Serialization.FormerlySerializedAs("Colony")]
    public Image Elliot;
[UnityEngine.Serialization.FormerlySerializedAs("passbg")]    [UnityEngine.Serialization.FormerlySerializedAs("Choice")]public Sprite Twelve;
[UnityEngine.Serialization.FormerlySerializedAs("OldPass")]    [UnityEngine.Serialization.FormerlySerializedAs("OldPest")]public GameObject VasSalt;
[UnityEngine.Serialization.FormerlySerializedAs("NewPass")]    [UnityEngine.Serialization.FormerlySerializedAs("RubPest")]public GameObject RatSalt;
[UnityEngine.Serialization.FormerlySerializedAs("titleObj")]    [UnityEngine.Serialization.FormerlySerializedAs("SpaceGel")]public GameObject BylawWok;
[UnityEngine.Serialization.FormerlySerializedAs("EnterBtn")]
[UnityEngine.Serialization.FormerlySerializedAs("MetalFew")]    public Button CrackWhy;
[UnityEngine.Serialization.FormerlySerializedAs("progressObj")]    [UnityEngine.Serialization.FormerlySerializedAs("DirectorGel")]public GameObject RegionalWok;



    // Start is called before the first frame update
    void Start()
    {
        RegionalWok.SetActive(true);
        CrackWhy.onClick.RemoveAllListeners();
        CrackWhy.onClick.AddListener(() =>
        {
            if (BurrowLift.ItChair())
            {
                LoyalWant.allowSceneActivation = true;
            }
            else {
                Destroy(transform.gameObject);
                VerbThinker.Instance.GlenBite();
                CashOutManager.BisFeedback().ReportEvent_LoadingTime();
            }
        });
        //if (PlayerPrefs.HasKey(CChisel.sys_AppSH))
        //{
        //    gamebg.sprite = passbg;
        //    titleAnim.gameObject.SetActive(true);
        //    titleObj.SetActive(false);
        //    OldPass.gameObject.SetActive(false);
        //    NewPass.gameObject.SetActive(true);
        //}
        //else
        //{
        //    titleAnim.gameObject.SetActive(false);
        //    titleObj.SetActive(true);
        //    OldPass.gameObject.SetActive(true);
        //    NewPass.gameObject.SetActive(false);
        //}
        if (!PlayerPrefs.HasKey(CChisel.Gut_Botanist))
        {
            AkinSpanThinker.GapAttest(CChisel.Gut_Botanist, I2.Loc.LocalizationManager.CurrentLanguage);
        }


        SaltSectorSword.fillAmount = 0;
        PotatoSword.fillAmount = 0;
        RegionalLoss.text = "0%";

        BylawPloy.AnimationState.SetAnimation(0, "chuxian", false);
        BylawPloy.AnimationState.AddAnimation(0, "daiji", true, 0f);
        CashOutManager.BisFeedback().StartTime = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    // Update is called once per frame
    void Update()
    {
        if (PotatoSword.fillAmount <= 0.8f || (TanGenuUSA.instance.Harsh && CashOutManager.BisFeedback().Ready))
        {
            SaltSectorSword.fillAmount += Time.deltaTime / 3f;
            PotatoSword.fillAmount += Time.deltaTime / 3f;
            RegionalLoss.text = (int)(PotatoSword.fillAmount * 100) + "%";
            if (TanGenuUSA.instance.Harsh && BurrowLift.ItChair() && LoyalWant == null) //审核，模式 
            {
               // SleepFeel = SceneManager.LoadSceneAsync("AGame");
               // SleepFeel.allowSceneActivation = false;
            }
            if (PotatoSword.fillAmount >= 1)
            {
                
                if (BurrowLift.ItChair())
                {
                   // SleepFeel.allowSceneActivation = true;
                    VerbThinker.Instance.GlenBite();
                    CashOutManager.BisFeedback().ReportEvent_LoadingTime();
                    Destroy(transform.gameObject);
                }
                else
                {
                    // DirectorGel.SetActive(false);
                    // MetalFew.gameObject.SetActive(true);
                    VerbThinker.Instance.GlenBite();
                    CashOutManager.BisFeedback().ReportEvent_LoadingTime();
                    Destroy(transform.gameObject);
                }
            }
        }
    }
}
