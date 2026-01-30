/***
 * 
 * 音乐管理器
 * 
 * **/
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseUSA : GistThickness<GooseUSA>
{
    //音频组件管理队列的对象
    private KarstDetailOcher KarstOcher;
    // 用于播放背景音乐的音乐源
    private AudioSource m_bgGoose= null;
    //播放音效的音频组件管理列表
    private List<AudioSource> LionKarstDetailThen;
    //检查已经播放的音频组件列表中没有播放的组件的更新频率
    private float TasteImperial= 2f;
    //背景音乐开关
    private bool _OxGooseIndian;
    //音效开关
    private bool _RotateGooseIndian;
    //音乐音量
    private float _OxSecure= 1f;
    //音效音量
    private float _RotateSecure= 1f;
    string BGM_Bard= "";

    public Dictionary<string, AudioParis> KarstAttemptClub;
    public Dictionary<string, AudioClip> KarstDustClub;

    public List<string> BureauBardPhase;
    // 控制背景音乐音量大小
    public float OxSecure{
        get
        {
            return OxGooseIndian ? RoeSecure(BGM_Bard) : 0f;
        }
        set
        {
            _OxSecure = value;
            //背景音乐开的状态下，声音随控制调节
        }
    }

    //控制音效音量的大小
    public float RotateEndear{
        get { return _RotateSecure; }
        set
        {
            _RotateSecure = value;
            GapRidRotateSecure();
        }
    }
    //控制背景音乐开关
    public bool OxGooseIndian{
        get
        {

            _OxGooseIndian = AkinSpanThinker.BisLuck("_BgMusicSwitch");
            return _OxGooseIndian;
        }
        set
        {
            if (m_bgGoose)
            {
                _OxGooseIndian = value;
                AkinSpanThinker.GapLuck("_BgMusicSwitch", _OxGooseIndian);
                m_bgGoose.volume = OxSecure;
            }
        }
    }
    public void AgeEkeHappyDueTilt()
    {
        m_bgGoose.volume = 0;
    }
    public void AgeFeePetioleDueTilt()
    {
        m_bgGoose.volume = OxSecure;
    }
    //控制音效开关
    public bool RotateGooseIndian{
        get
        {
            _RotateGooseIndian = AkinSpanThinker.BisLuck("_EffectMusicSwitch");
            return _RotateGooseIndian;
        }
        set
        {
            _RotateGooseIndian = value;
            AkinSpanThinker.GapLuck("_EffectMusicSwitch", _RotateGooseIndian);

        }
    }
    public GooseUSA()
    {
        LionKarstDetailThen = new List<AudioSource>();
    }
    protected override void Awake()
    {
        BureauBardPhase = new List<string>();
        if (!PlayerPrefs.HasKey("first_music_setBool") || !AkinSpanThinker.BisLuck("first_music_set"))
        {
            AkinSpanThinker.GapLuck("first_music_set", true);
            AkinSpanThinker.GapLuck("_BgMusicSwitch", true);
            AkinSpanThinker.GapLuck("_EffectMusicSwitch", true);
        }
        KarstOcher = new KarstDetailOcher(this);

        TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
        KarstAttemptClub = JsonMapper.ToObject<Dictionary<string, AudioParis>>(json.text);
    }
    private void Start()
    {
        StartCoroutine(nameof(TasteNoBagKarstWorksheet));
    }
    public void BiteGooseUSA()
    {
        KarstDustClub = new Dictionary<string, AudioClip>();
        foreach (string key in KarstAttemptClub.Keys)
        {
            KarstDustClub.Add(key, Resources.Load<AudioClip>(KarstAttemptClub[key].filePath));
        }

    }
    /// <summary>
    /// 定时检查没有使用的音频组件并回收
    /// </summary>
    /// <returns></returns>
    IEnumerator TasteNoBagKarstWorksheet()
    {
        while (true)
        {
            //定时更新
            yield return new WaitForSeconds(TasteImperial);
            for (int i = 0; i < LionKarstDetailThen.Count; i++)
            {
                //防止数据越界
                if (i < LionKarstDetailThen.Count)
                {
                    //确保物体存在
                    if (LionKarstDetailThen[i])
                    {
                        //音频为空或者没有播放为返回队列条件
                        if ((LionKarstDetailThen[i].clip == null || !LionKarstDetailThen[i].isPlaying))
                        {
                            //返回队列
                            KarstOcher.UnOilKarstWorksheet(LionKarstDetailThen[i]);
                            //从播放列表中删除
                            LionKarstDetailThen.Remove(LionKarstDetailThen[i]);
                        }
                    }
                    else
                    {
                        //移除在队列中被销毁但是是在list中存在的垃圾数据
                        LionKarstDetailThen.Remove(LionKarstDetailThen[i]);
                    }
                }

            }
        }
    }
    /// <summary>
    /// 设置当前播放的所有音效的音量
    /// </summary>
    private void GapRidRotateSecure()
    {
        for (int i = 0; i < LionKarstDetailThen.Count; i++)
        {
            if (LionKarstDetailThen[i] && LionKarstDetailThen[i].isPlaying)
            {
                LionKarstDetailThen[i].volume = _RotateGooseIndian ? _RotateSecure : 0f;
            }
        }
    }
    /// <summary>
    /// 播放背景音乐，传进一个音频剪辑的name
    /// </summary>
    /// <param name="bgName"></param>
    /// <param name="restart"></param>
    private void LionOxFirm(object bgName, bool restart = false)
    {

        BGM_Bard = bgName.ToString();
        if (m_bgGoose == null)
        {
            //拿到一个音频组件  背景音乐组件在某一时间段唯一存在
            m_bgGoose = KarstOcher.BisKarstWorksheet();
            //开启循环
            m_bgGoose.loop = true;
            //开始播放
            m_bgGoose.playOnAwake = false;
            //加入播放列表
            //PlayAudioSourceList.Add(m_bgMusic);
        }

        if (!OxGooseIndian)
        {
            m_bgGoose.volume = 0;
        }

        //定义一个空的字符串
        string curBgName = string.Empty;
        //如果这个音乐源的音频剪辑不为空的话
        if (m_bgGoose.clip != null)
        {
            //得到这个音频剪辑的name
            curBgName = m_bgGoose.clip.name;
        }

        // 根据用户的音频片段名称, 找到AuioClip, 然后播放,
        //ResourcesMgr是提前定义好的查找音频剪辑对应路径的单例脚本，并动态加载出来
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[BGM_Name].filePath);
        AudioClip clip = KarstDustClub[BGM_Bard];

        //如果找到了，不为空
        if (clip != null)
        {
            //如果这个音频剪辑已经复制给类音频源，切正在播放，那么直接跳出
            if (clip.name == curBgName && !restart)
            {
                return;
            }
            //否则，把改音频剪辑赋值给音频源，然后播放
            m_bgGoose.clip = clip;
            m_bgGoose.volume = OxSecure;
            m_bgGoose.Play();
        }
        else
        {
            //没找到直接报错
            // 异常, 调用写日志的工具类.
            //UnityEngine.Debug.Log("没有找到音频片段");
            if (m_bgGoose.isPlaying)
            {
                m_bgGoose.Stop();
            }
            m_bgGoose.clip = null;
        }
    }
    /// <summary>
    /// 播放音效
    /// </summary>
    /// <param name="effectName"></param>
    /// <param name="defAudio"></param>
    /// <param name="volume"></param>
    private void LionRotateFirm(object effectName, bool defAudio = true, float volume = 1f)
    {
        if (!RotateGooseIndian)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = KarstOcher.BisKarstWorksheet();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = RoeSecure(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        Debug.Log(KarstAttemptClub[effectName.ToString()].filePath);
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = KarstDustClub[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            KarstOcher.UnOilKarstWorksheet(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        LionKarstDetailThen.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            Debug.Log("音效播放");
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    private void LionRotateFirm(object effectName, float start, float end)
    {
        bool defAudio = true;
        float volume = 1f;
        if (!RotateGooseIndian)
        {
            return;
        }
        //获取音频组件
        AudioSource m_effectMusic = KarstOcher.BisKarstWorksheet();
        if (m_effectMusic.isPlaying)
        {
            Debug.Log("-------------------------------当前音效正在播放,直接返回");
            return;
        };
        m_effectMusic.loop = false;
        m_effectMusic.playOnAwake = false;
        m_effectMusic.volume = RoeSecure(effectName.ToString());
        //Debug.Log(m_effectMusic.volume);
        //根据查找路径加载对应的音频剪辑
        //AudioClip clip = Resources.Load<AudioClip>(AudioSettingDict[effectName.ToString()].filePath);
        AudioClip clip = KarstDustClub[effectName.ToString()];
        //如果为空的话，直接报错，然后跳出
        if (clip == null)
        {
            UnityEngine.Debug.Log("没有找到音效片段");
            //没加入播放列表直接返回给队列
            KarstOcher.UnOilKarstWorksheet(m_effectMusic);
            return;
        }
        m_effectMusic.clip = clip;
        //加入播放列表
        LionKarstDetailThen.Add(m_effectMusic);
        //否则，就是clip不为空的话，如果defAudio=true，直接播放
        if (defAudio)
        {
            Debug.Log("音效播放");
            m_effectMusic.Stop();
            m_effectMusic.SetScheduledStartTime(start);
            m_effectMusic.SetScheduledEndTime(end);
            m_effectMusic.PlayOneShot(clip, volume);
        }
        else
        {
            //指定点播放
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, volume);
        }
    }
    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void LionOx(GooseCity.UIMusic bgName, bool restart = false)
    {
        LionOxFirm(bgName, restart);
    }

    public void LionOx(GooseCity.SceneMusic bgName, bool restart = false)
    {
        LionOxFirm(bgName, restart);
    }

    public void LionRotate(GooseCity.UIMusic bgName, float limit, System.Action finish = null)
    {
        LionRotateFirm(bgName, limit, finish);
    }

    public void LionRotate(GooseCity.SceneMusic bgName, float limit, System.Action finish = null)
    {
        LionRotateFirm(bgName, limit, finish);
    }


    private void LionRotateFirm(object effectName, float limit, System.Action finish = null)
    {
        if (!BureauBardPhase.Contains(effectName.ToString()))
        {
            if (finish != null)
            {
                finish();
            }
            LionRotateFirm(effectName, true, 1);
            BureauBardPhase.Add(effectName.ToString());
            StartCoroutine(ArriveRotateBard(effectName.ToString(), limit));
        }
    }
    IEnumerator ArriveRotateBard(string name, float limit)
    {
        yield return new WaitForSeconds(limit);
        if (BureauBardPhase.Contains(name))
        {
            BureauBardPhase.Remove(name);
        }
    }
    public void LionRotate(GooseCity.UIMusic effectName, float start, float end)
    {
        LionRotateFirm(effectName, start, end);
    }
    //播放各种音频剪辑的调用方法，MusicType是提前写好的存放各种音乐名称的枚举类，便于外面直接调用
    public void LionRotate(GooseCity.UIMusic effectName, bool defAudio = true, float volume = 1f)
    {
        LionRotateFirm(effectName, defAudio, volume);
    }

    public void LionRotate(GooseCity.SceneMusic effectName, bool defAudio = true, float volume = 1f)
    {
        LionRotateFirm(effectName, defAudio, volume);
    }
    float RoeSecure(string name)
    {
        if (KarstAttemptClub == null)
        {
            TextAsset json = Resources.Load<TextAsset>("Audio/AudioInfo");
            KarstAttemptClub = JsonMapper.ToObject<Dictionary<string, AudioParis>>(json.text);
        }

        if (KarstAttemptClub.ContainsKey(name))
        {
            return (float)KarstAttemptClub[name].volume;

        }
        else
        {
            return 1;
        }
    }

}