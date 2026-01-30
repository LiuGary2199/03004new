using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class SelfSheerRibbon : GistThickness<SelfSheerRibbon>
{
    public string version = "1.2";
    public string WideTusk= TanGenuUSA.instance.WideTusk;
    //channel
#if UNITY_IOS
    private string Legally= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        SelfSheerRibbon.BisFeedback().StagWideNearness();
    }
    
    public Text Grid;

    protected override void Awake()
    {
        base.Awake();
        
        version = Application.version;
        StartCoroutine(nameof(WareShrubby));
    }
    IEnumerator WareShrubby()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            SelfSheerRibbon.BisFeedback().StagWideNearness();
        }
    }
    private void Start()
    {
        if (AkinSpanThinker.BisFew("event_day") != DateTime.Now.Day && AkinSpanThinker.BisAttest("user_servers_id").Length != 0)
        {
            AkinSpanThinker.GapFew("event_day", DateTime.Now.Day);
        }
    }
    public void CastToWhigSheer(string event_id)
    {
        CastSheer(event_id);
    }
    public void StagWideNearness(List<string> valueList = null)
    {
        if (AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateChopGill) == 0)
        {
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateChopGill, AkinSpanThinker.BisHeyday(CChisel.Ox_ChopGill));
        }
        if (AkinSpanThinker.BisHeyday(CChisel.Ox_Bill) == 0)
        {
            AkinSpanThinker.GapHeyday(CChisel.Ox_AppreciateBill, AkinSpanThinker.BisHeyday(CChisel.Ox_AppreciateBill));
        }
        if (valueList == null)
        {
            valueList = new List<string>() { 
                
                WideSpanThinker.BisFeedback().BisChop().ToString(),
                WideSpanThinker.BisFeedback().BisBill().ToString(),
                WideSpanThinker.BisFeedback().BisAppreciateChopGill().ToString(),
                WideSpanThinker.BisFeedback().BisAppreciateBill().ToString(),
                WideSpanThinker.BisFeedback().BisAppreciateChisel().ToString(),
                AkinSpanThinker.BisFew("DropBallCount").ToString(),
          
            };
        }
        
        if (AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", WideTusk);
        wwwForm.AddField("userId", AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe));

        wwwForm.AddField("gameVersion", version);

        wwwForm.AddField("channel", Legally);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(CastSelf(TanGenuUSA.instance.FirmCry + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void CastSheer(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Grid != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Grid.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe) == null)
        {
            TanGenuUSA.instance.Idiom();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", WideTusk);
        wwwForm.AddField("userId", AkinSpanThinker.BisAttest(CChisel.Ox_EmptyUnwellMe));
        //Debug.Log("userId:" + AkinSpanThinker.GetString(CChisel.sv_LocalServerId));
        wwwForm.AddField("version", version);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Legally);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(CastSelf(TanGenuUSA.instance.FirmCry + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator CastSelf(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            RibIsotope();
        }
        else
        {
            success(request.downloadHandler.text);
            RibIsotope();
        }
    }
    private void RibIsotope()
    {
        StopCoroutine(nameof(CastSelf));
    }


}