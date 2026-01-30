using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunsetSphere : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("block")]
[UnityEngine.Serialization.FormerlySerializedAs("Table")]    public System.Action Brown;
    private void OnTriggerEnter(Collider other)
    {
        Brown();
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
