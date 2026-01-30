using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VagaryRendSkill : FirmUICharm
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    [UnityEngine.Serialization.FormerlySerializedAs("PianoHandle")]public Button HappyAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    [UnityEngine.Serialization.FormerlySerializedAs("CosmosEdgeCent")]public Text VagaryBathLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    [UnityEngine.Serialization.FormerlySerializedAs("SourceGoCent")]public Text UnwellMeLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    [UnityEngine.Serialization.FormerlySerializedAs("ActDynastyCent")]public Text DewGaseousLoss;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    [UnityEngine.Serialization.FormerlySerializedAs("CosmosFistCent")]public Text VagaryCityLoss;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    [UnityEngine.Serialization.FormerlySerializedAs("NylonAilPupilHandle")]public Button NylonEndTroveAnimal;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    [UnityEngine.Serialization.FormerlySerializedAs("YewAilPupilHandle")]public Button BisEndTroveAnimal;

    // Start is called before the first frame update
    void Start()
    {
        HappyAnimal.onClick.AddListener(() => {
            HappyUIMust(GetType().Name);
        });

        NylonEndTroveAnimal.onClick.AddListener(() => {
            VagaryBiteThinker.Instance.LoderEndTrove();
        });

        BisEndTroveAnimal.onClick.AddListener(() => {
            VagaryBiteThinker.Instance.BisEndTrove("test");
        });
    }

    private void FirnGaseousLoss()
    {
        VagaryBathLoss.text = VagaryBiteThinker.Instance.BisVagaryBath();
        UnwellMeLoss.text = AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe);
        DewGaseousLoss.text = VagaryBiteThinker.Instance._PolluteTrove.ToString();
        VagaryCityLoss.text = AkinSpanThinker.BisAttest("sv_ADJustInitType");
    }

    public override void Display()
    {
        base.Display();
        InvokeRepeating(nameof(FirnGaseousLoss), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(FirnGaseousLoss));
    }
}
