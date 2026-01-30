using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GillSphereVibrant : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("coinPagodaPerfab")]    [UnityEngine.Serialization.FormerlySerializedAs("GulfCommonTablet")]public GameObject GulfSphereCompel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void ChiefGillSphere(int heightCount)
    {
        bool isUnlock = false;
        List<Vector3> pointList = new List<Vector3>();
        List<Vector3> eulerList = new List<Vector3>();
        for (int i = 0; i < GulfSphereCompel.transform.childCount; i++)
        {
            Transform targetTrans = GulfSphereCompel.transform.GetChild(i);
            pointList.Add(targetTrans.localPosition);
            eulerList.Add(targetTrans.eulerAngles);
        }
        GameObject pagodaGroup = new GameObject();
        pagodaGroup.AddComponent<SunsetSphere>().Brown = ()=> {
            if (!isUnlock)
            {
                isUnlock = true;
                pagodaGroup.GetComponent<SunsetSphere>().enabled = false;
                Destroy(pagodaGroup.GetComponent<Rigidbody>());
                for (int i = 0; i < pagodaGroup.transform.childCount; i++)
                {
                    GameObject cashCoin = pagodaGroup.transform.GetChild(i).gameObject;
                    cashCoin.AddComponent<Rigidbody>();
                    cashCoin.GetComponent<Rigidbody>().mass = 0.8f;
                    cashCoin.GetComponent<Rigidbody>().angularDrag = 0;
                }
            }
        };
        pagodaGroup.layer = 6;
        pagodaGroup.AddComponent<Rigidbody>().mass = 30;
        pagodaGroup.transform.position = new Vector3(0, 0.74f, -3.671f);
        pagodaGroup.transform.SetParent(BurdenImagist.Instance.RussiaTellBoard);
        for (int i = 0; i < heightCount; i++)
        {
            GameObject tempObject = new GameObject();
            for (int j = 0; j < 7; j++)
            {
                GameObject cashCoin = BurdenImagist.Instance.BigRegimeTell(PusherRewardType.CoinCash);
                cashCoin.transform.SetParent(tempObject.transform);
                cashCoin.transform.localPosition = pointList[j];
                cashCoin.transform.eulerAngles = eulerList[j];
                Destroy(cashCoin.GetComponent<Rigidbody>());
            }
            tempObject.transform.position = pagodaGroup.transform.position + new Vector3(0, 0.1074f * i, 0);
            tempObject.transform.eulerAngles = new Vector3(0, i * 3, 0);
            for (int k = tempObject.transform.childCount - 1; k >= 0; k--)
            {
                tempObject.transform.GetChild(k).SetParent(pagodaGroup.transform);
            }
            Destroy(tempObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ChiefGillSphere(30);
        }
    }
}
