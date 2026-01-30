using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class RewardItemPerfabs
{
    public GameObject goldAcidOpaque_1;
    public GameObject goldAcidOpaque_5;
    public GameObject goldAcidOpaque_10;
    public GameObject goldAcidOpaque_50;
    public GameObject goldAcidOpaque_100;
    public GameObject goldAcidOpaque_200;
    public GameObject goldAcidOpaque_500;
    public GameObject cashAcidOpaque_1;
    public GameObject cashAcidOpaque_5;
    public GameObject cashAcidOpaque_10;
    public GameObject cashAcidOpaque_50;
    public GameObject cashAcidOpaque_100;
    public GameObject cashAcidOpaque_200;
    public GameObject cashAcidOpaque_500;
    public GameObject LastDireOpaque;
    public GameObject WaxElectroOpaque;
    public GameObject WaxCuteOpaque;
    public GameObject WaxCodOpaque;
    public GameObject ClimaxOpaque;
    public GameObject RealizeLateOpaque;
    public GameObject LoderLateOpaque;
    public GameObject LieAcidOpaque;
    public GameObject DauntOpaque;

}
public class BurdenRegimeTell : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("rewardType")]    public PusherRewardType RussiaWick;
[UnityEngine.Serialization.FormerlySerializedAs("rewardNum")]    public double RussiaPet;
[UnityEngine.Serialization.FormerlySerializedAs("rewardItemPerfabs")]    public RewardItemPerfabs RussiaTellRelieve;
    bool EggWishDeity= false;
    public void MealRegimeTell(PusherRewardType type, bool canPlay = true)
    {
        EggWishDeity = canPlay;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        RussiaWick = type;
        if (BurrowLift.ItChair() && type == PusherRewardType.CoinCash)
        {
            type = PusherRewardType.CoinGold;
            RussiaWick = PusherRewardType.CoinGold;
        }
        switch (type)
        {
            case PusherRewardType.CoinGold:
                MealTireAcid();
                break;
            case PusherRewardType.CoinCash:
                MealDireAcid();
                break;
            case PusherRewardType.RollCash:
                RussiaTellRelieve.LastDireOpaque.SetActive(true);
                break;
            case PusherRewardType.LuckyCard:
                RussiaTellRelieve.LoderLateOpaque.SetActive(true);
                break;
            case PusherRewardType.ScratchCard:
                RussiaTellRelieve.RealizeLateOpaque.SetActive(true);
                break;
            case PusherRewardType.GemDiamond:
                RussiaTellRelieve.WaxElectroOpaque.SetActive(true);
                break;
            case PusherRewardType.GemBlue:
                RussiaTellRelieve.WaxCuteOpaque.SetActive(true);
                break;
            case PusherRewardType.GemRed:
                RussiaTellRelieve.WaxCodOpaque.SetActive(true);
                break;
            case PusherRewardType.Golden:
                RussiaTellRelieve.ClimaxOpaque.SetActive(true);
                break;
            case PusherRewardType.BigCoin:
                RussiaTellRelieve.LieAcidOpaque.SetActive(true);
                break;
        }

    }
    public void MealTireAcid()
    {
        int num = SpanLayoutThinker.BisFeedback().RoeChopGillElk();
        if (BurrowLift.ItChair())
        {
            RussiaTellRelieve.DauntOpaque.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    RussiaTellRelieve.goldAcidOpaque_1.SetActive(true);
                    break;
                case 5:
                    RussiaTellRelieve.goldAcidOpaque_5.SetActive(true);
                    break;
                case 10:
                    RussiaTellRelieve.goldAcidOpaque_10.SetActive(true);
                    break;
                case 50:
                    RussiaTellRelieve.goldAcidOpaque_50.SetActive(true);
                    break;
                case 100:
                    RussiaTellRelieve.goldAcidOpaque_100.SetActive(true);
                    break;
                case 200:
                    RussiaTellRelieve.goldAcidOpaque_200.SetActive(true);
                    break;
                case 500:
                    RussiaTellRelieve.goldAcidOpaque_500.SetActive(true);
                    break;
            }
        }
        
        RussiaPet = num;
    }
    public void MealDireAcid()
    {
        int num = SpanLayoutThinker.BisFeedback().RoeBillGillElk();
        if (BurrowLift.ItChair())
        {
            RussiaTellRelieve.DauntOpaque.SetActive(true);
        }
        else
        {
            switch (num)
            {
                case 1:
                    RussiaTellRelieve.cashAcidOpaque_1.SetActive(true);
                    break;
                case 5:
                    RussiaTellRelieve.cashAcidOpaque_5.SetActive(true);
                    break;
                case 10:
                    RussiaTellRelieve.cashAcidOpaque_10.SetActive(true);
                    break;
                case 50:
                    RussiaTellRelieve.cashAcidOpaque_50.SetActive(true);
                    break;
                case 100:
                    RussiaTellRelieve.cashAcidOpaque_100.SetActive(true);
                    break;
                case 200:
                    RussiaTellRelieve.cashAcidOpaque_200.SetActive(true);
                    break;
                case 500:
                    RussiaTellRelieve.cashAcidOpaque_500.SetActive(true);
                    break;
            }
        }
        RussiaPet = num / 100f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (EggWishDeity)
        {
            if (GetComponent<Rigidbody>() != null)
            {
                if (RussiaWick == PusherRewardType.CoinCash || RussiaWick == PusherRewardType.CoinGold)
                {
                    if (transform.position.y < 1.269)
                    {
                        EggWishDeity = false;
                        GooseCity.SceneMusic type = (GooseCity.SceneMusic)Enum.Parse(typeof(GooseCity.SceneMusic), "sound_coin_collide_" + UnityEngine.Random.Range(1,5));
                        GooseUSA.BisFeedback().LionRotate(type, 0.1f);
                    }
                }
            }
        }
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
