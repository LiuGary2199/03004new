using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardPlugKeyAstonish : MonoBehaviour
{
    public static UpwardPlugKeyAstonish Instance;
[UnityEngine.Serialization.FormerlySerializedAs("slotCount")]
[UnityEngine.Serialization.FormerlySerializedAs("PestPupil")]    public int SaltTrove;
[UnityEngine.Serialization.FormerlySerializedAs("isSlotFlag")]    [UnityEngine.Serialization.FormerlySerializedAs("WeCrabMust")]public bool ToPlugSpew;

    private void Awake()
    {
        Instance = this;
        SaltTrove = 0;
        ToPlugSpew = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        GooseUSA.BisFeedback().LionRotate(GooseCity.SceneMusic.sound_enter_box);
        BurdenImagist.Instance.BigLoreRegime(other.transform.parent.GetComponent<BurdenRegimeTell>().RussiaWick,
            other.transform.parent.GetComponent<BurdenRegimeTell>().RussiaPet);

        LionDuePlug();
        other.transform.parent.gameObject.SetActive(false);
    }

    public void LionDuePlug()
    {
        BisPlugTrove();
        DoPlug();
    }

    public void BisPlugTrove()
    {
        SaltTrove++;
        ButteThinker.Instance.FirnPlugElk(true, SaltTrove);
    }


    private void DoPlug()
    {
        if (ToPlugSpew) return;
        ButteThinker.Instance.FirnPlugElk(true, SaltTrove);
        ToPlugSpew = true;
        SaltTrove--;
        BurdenImagist.Instance.KrillFrog();
    }

    public void MyGoPlug()
    {
        if (SaltTrove < 1)
        {
            ButteThinker.Instance.FirnPlugElk(false, SaltTrove);
            return;
        }

        DoPlug();
        // Invoke("DoSlot", 1f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            LionDuePlug();
        }
    }
}