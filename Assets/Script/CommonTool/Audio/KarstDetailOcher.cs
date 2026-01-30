/***
 * 
 * AudioSource组件管理(音效，背景音乐除外)
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KarstDetailOcher 
{
    //音乐的管理者
    private GameObject KarstUSA;
    //音乐组件管理队列
    private List<AudioSource> KarstWorksheetOcher;
    //音乐组件默认容器最大值  
    private int BayTrove= 25;
    public KarstDetailOcher(GooseUSA audioMgr)
    {
        KarstUSA = audioMgr.gameObject;
        BiteKarstDetailOcher();
    }
  
    /// <summary>
    /// 初始化队列
    /// </summary>
    private void BiteKarstDetailOcher()
    {
        KarstWorksheetOcher = new List<AudioSource>();
        for(int i = 0; i < BayTrove; i++)
        {
            BisKarstDetailDonDashUSA();
        }
    }
    /// <summary>
    /// 给音乐的管理者添加音频组件，同时组件加入队列
    /// </summary>
    private AudioSource BisKarstDetailDonDashUSA()
    {
        AudioSource audio = KarstUSA.AddComponent<AudioSource>();
        KarstWorksheetOcher.Add(audio);
        return audio;
    }
    /// <summary>
    /// 获取一个音频组件
    /// </summary>
    /// <param name="audioMgr"></param>
    /// <returns></returns>
    public AudioSource BisKarstWorksheet()
    {
        if (KarstWorksheetOcher.Count > 0)
        {
            AudioSource audio = KarstWorksheetOcher.Find(t => !t.isPlaying);
            if (audio)
            {
                KarstWorksheetOcher.Remove(audio);
                return audio;
            }
            //队列中没有了，需额外添加
            return BisKarstDetailDonDashUSA();
            //直接返回队列中存在的组件
            //return AudioComponentQueue.Dequeue();
        }
        else
        {
            //队列中没有了，需额外添加
            return  BisKarstDetailDonDashUSA();
        }
    }
    /// <summary>
    /// 没有被使用的音频组件返回给队列
    /// </summary>
    /// <param name="audio"></param>
    public void UnOilKarstWorksheet(AudioSource audio)
    {
        if (KarstWorksheetOcher.Contains(audio)) return;
        if (KarstWorksheetOcher.Count >= BayTrove)
        {
            GameObject.Destroy(audio);
            //Debug.Log("删除组件");
        }
        else
        {
            audio.clip = null;
            KarstWorksheetOcher.Add(audio);
        }

        //Debug.Log("队列长度是" + AudioComponentQueue.Count);
    }
    
}
