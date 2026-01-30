/*
 * 
 * 多语言
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellularUSA 
{
    public static CellularUSA _Desirable;
    //语言翻译的缓存集合
    private Dictionary<string, string> _HueCellularYoung;

    private CellularUSA()
    {
        _HueCellularYoung = new Dictionary<string, string>();
        //初始化语言缓存集合
        BiteCellularOcher();
    }

    /// <summary>
    /// 获取实例
    /// </summary>
    /// <returns></returns>
    public static CellularUSA BisFeedback()
    {
        if (_Desirable == null)
        {
            _Desirable = new CellularUSA();
        }
        return _Desirable;
    }

    /// <summary>
    /// 得到显示文本信息
    /// </summary>
    /// <param name="lauguageId">语言id</param>
    /// <returns></returns>
    public string FirnLoss(string lauguageId)
    {
        string strQueryResult = string.Empty;
        if (string.IsNullOrEmpty(lauguageId)) return null;
        //查询处理
        if(_HueCellularYoung!=null && _HueCellularYoung.Count >= 1)
        {
            _HueCellularYoung.TryGetValue(lauguageId, out strQueryResult);
            if (!string.IsNullOrEmpty(strQueryResult))
            {
                return strQueryResult;
            }
        }
        Debug.Log(GetType() + "/ShowText()/ Query is Null!  Parameter lauguageID: " + lauguageId);
        return null;
    }

    /// <summary>
    /// 初始化语言缓存集合
    /// </summary>
    private void BiteCellularOcher()
    {
        //LauguageJSONConfig_En
        //LauguageJSONConfig
        IChiselThinker config = new ChiselThinkerAnRote("LauguageJSONConfig");
        if (config != null)
        {
            _HueCellularYoung = config.LopAttempt;
        }
    }
}
