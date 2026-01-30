/***
 * 
 * 网络请求的get对象
 * 
 * **/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TanToilBisPiston 
{
    //get的url
    public string Cry;
    //get成功的回调
    public Action<UnityWebRequest> BisProduce;
    //get失败的回调
    public Action BisFile;
    public TanToilBisPiston(string url,Action<UnityWebRequest> success,Action fail)
    {
        Cry = url;
        BisProduce = success;
        BisFile = fail;
    }
   
}
