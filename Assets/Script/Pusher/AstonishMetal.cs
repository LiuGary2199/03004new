using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstonishMetal : MonoBehaviour
{
    System.Action BrownBreath;
    bool ToHobby= true;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��ײ");
        if (ToHobby)
        {
            ToHobby = false;
            BrownBreath();
            Destroy(this);
        }
    }

    public void AgeMetalBreath(System.Action block)
    {
        BrownBreath = block;
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
