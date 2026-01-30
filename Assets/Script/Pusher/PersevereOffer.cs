using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersevereOffer : MonoBehaviour
{
    Vector3 Affinity;

    /// <summary>
    /// ��ͣ������
    /// </summary>
    public void TheftPersevere()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            Affinity = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            Affinity = GetComponent<Rigidbody2D>().velocity;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    public void QuiverPersevere()
    {
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().velocity = Affinity;
        }
        if (GetComponent<Rigidbody2D>() != null)
        {
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().velocity = Affinity;
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
