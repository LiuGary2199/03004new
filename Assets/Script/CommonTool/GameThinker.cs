using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameThinker : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("pool")]    [UnityEngine.Serialization.FormerlySerializedAs("Crew")]public List<GameObject> Spin;
[UnityEngine.Serialization.FormerlySerializedAs("prefab")]    [UnityEngine.Serialization.FormerlySerializedAs("Thirty")]public GameObject Monoid;
    private Transform MonoidAutumn;
    private string SprawlBard;

    public void BiteGameThinker(GameObject obj, Transform parent, int count, string _objectName)
    {
        Monoid = obj;
        SprawlBard = _objectName;
        Spin = new List<GameObject>();
        MonoidAutumn = parent;
        int AlterAngry= 0;
        for (int k = 0; k < MonoidAutumn.childCount; k++)
        {
            if (MonoidAutumn.GetChild(k).name.Contains(SprawlBard))
            {
                Spin.Add(MonoidAutumn.GetChild(k).gameObject);
                AlterAngry++;
            }
        }
        for (int i = AlterAngry; i < count; i++)
        {
            GameObject objClone = GameObject.Instantiate(Monoid, MonoidAutumn) as GameObject;
            //objClone.transform.parent = prefabParent;//为克隆出来的子弹指定父物体
            objClone.name = SprawlBard + "(" + i.ToString() + ")";
            objClone.SetActive(false);
            Spin.Add(objClone);
        }
    }
    public void ImmuneGameBisNews(GameObject obj)
    {
        Spin.Add(obj);
    }

    public GameObject BisPiston()
    {
        //遍历缓存池 找空闲的物体
        foreach (GameObject iter in Spin)
        {
            if (iter != null && !iter.activeSelf)
            {
                iter.transform.SetParent(MonoidAutumn);
                iter.SetActive(true);
                return iter;
            }
        }
        GameObject newPrefab = GameObject.Instantiate(Monoid) as GameObject;
        newPrefab.transform.SetParent(MonoidAutumn);
        newPrefab.name = SprawlBard + "(" + Spin.Count.ToString() + ")"  ;
        newPrefab.SetActive(true);
        Spin.Add(newPrefab);
        return newPrefab;
    }

    public void HappyRid()
    {
        foreach (GameObject iter in Spin)
        {
            if (iter.activeSelf)
            {
                iter.SetActive(false);
            }
        }
    }
    public void CountryRid()
    {
        foreach (GameObject iter in Spin)
        {
            Destroy(iter);
        }
        Destroy(MonoidAutumn);
        Destroy(this.gameObject);
    }
}
