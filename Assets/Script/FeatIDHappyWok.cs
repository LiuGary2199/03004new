using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatIDHappyWok : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Newrove")]    [UnityEngine.Serialization.FormerlySerializedAs("Utility")]public GameObject Foghorn;
[UnityEngine.Serialization.FormerlySerializedAs("Oldtop")] [UnityEngine.Serialization.FormerlySerializedAs("Fringe")]public GameObject Advice;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction")]    [UnityEngine.Serialization.FormerlySerializedAs("Crab_Absenteeism")]public GameObject Plug_Aldosterone;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_1")]    [UnityEngine.Serialization.FormerlySerializedAs("Crab_Absenteeism_1")]public GameObject Plug_Aldosterone_1;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Obstruction_2")]    [UnityEngine.Serialization.FormerlySerializedAs("Crab_Absenteeism_2")]public GameObject Plug_Aldosterone_2;
[UnityEngine.Serialization.FormerlySerializedAs("Slot_Bottom_1")]    [UnityEngine.Serialization.FormerlySerializedAs("Crab_Disuse_1")]public GameObject Plug_Carton_1;
[UnityEngine.Serialization.FormerlySerializedAs("SlotTop")]    [UnityEngine.Serialization.FormerlySerializedAs("CrabMob")]public GameObject PlugFog;
[UnityEngine.Serialization.FormerlySerializedAs("Plane")]    [UnityEngine.Serialization.FormerlySerializedAs("Apart")]public GameObject Later;
[UnityEngine.Serialization.FormerlySerializedAs("Image")]    [UnityEngine.Serialization.FormerlySerializedAs("Honey")]public GameObject Sword;
[UnityEngine.Serialization.FormerlySerializedAs("Arrow")]    [UnityEngine.Serialization.FormerlySerializedAs("Harem")]public GameObject Arena;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher")]    [UnityEngine.Serialization.FormerlySerializedAs("Reveal")]public MeshRenderer Upward;
[UnityEngine.Serialization.FormerlySerializedAs("Pusher_mat")]    [UnityEngine.Serialization.FormerlySerializedAs("Reveal_Pit")]public Material Upward_Two;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom")]    [UnityEngine.Serialization.FormerlySerializedAs("Disuse")]public MeshRenderer Carton;
[UnityEngine.Serialization.FormerlySerializedAs("Bottom_mat")]    [UnityEngine.Serialization.FormerlySerializedAs("Disuse_Pit")]public Material Carton_Two;
[UnityEngine.Serialization.FormerlySerializedAs("Hold")]    [UnityEngine.Serialization.FormerlySerializedAs("Tail")]public MeshRenderer Huge;
[UnityEngine.Serialization.FormerlySerializedAs("Hold_mat")]   // public MeshRenderer Hold_1;
[UnityEngine.Serialization.FormerlySerializedAs("Tail_Pit")]    public Material Huge_Two;
[UnityEngine.Serialization.FormerlySerializedAs("Hold_1")]    // public Material Hold_1_mat;

    public MeshRenderer Urge_1;
[UnityEngine.Serialization.FormerlySerializedAs("Hold_1_mat")]    public Material Urge_1_How;
    public void TasteWokBound() 
    {
        if (BurrowLift.ItChair())
        {
            Foghorn.SetActive(true);
            Advice.SetActive(false);
          //  Crab_Absenteeism.SetActive(false);
           // Crab_Absenteeism_1.SetActive(false);
            //Crab_Absenteeism_2.SetActive(false);
         //   CrabMob.SetActive(false);
            Later.SetActive(false);
            Sword.SetActive(false);
          //  Crab_Disuse_1.SetActive(false);
            //  Harem.SetActive(false);
            //    Reveal.material = Reveal_Pit;
            //   Disuse.material = Disuse_Pit;
            //  Tail.material = Tail_Pit;
            Urge_1.material = Urge_1_How;
        }
        else
        {
            Foghorn.SetActive(false);
            Advice.SetActive(true);
            Plug_Aldosterone.SetActive(true);
            Plug_Aldosterone_1.SetActive(true);
            Plug_Aldosterone_2.SetActive(true);
            PlugFog.SetActive(true);
            Later.SetActive(true);
            Sword.SetActive(true);
            Plug_Carton_1.SetActive(true);
            Arena.SetActive(true);
        }
    }
}
