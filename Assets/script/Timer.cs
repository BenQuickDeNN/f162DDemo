using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float time_All = 300;//计时的总时间（单位秒）  
    public float time_Left;//剩余时间  
    public bool isPauseTime = false;
    public Text time;
    // Use this for initialization  
    void Start()
    {
        time_Left = time_All;
    }

    // Update is called once per frame  
    void Update()
    {
        if (!isPauseTime)
        {
            if (time_Left > 0)
                StartTimer();
        }

    }
    /// <summary>  
    /// 开始计时   
    /// </summary>  
    void StartTimer()
    {
        time_Left -= Time.deltaTime;
        time.text = GetTime(time_Left);

    }
    /// <summary>  
    ///继续游戏，这个暂时加在这里，后期代码重构时加在UIControl中   
    /// </summary>  
    public void ContinueGame()
    {

        isPauseTime = false;
        Time.timeScale = 1;
    }

    /// <summary>  
    /// 暂停计时  
    /// </summary>  
    public void PauseTimer()
    {
        isPauseTime = true;
        Time.timeScale = 0;
    }
    /// <summary>  
    /// 获取总的时间字符串  
    /// </summary>  
    string GetTime(float time)
    {
        return GetMinute(time) + GetSecond(time);

    }

    /// <summary>  
    /// 获取小时  
    /// </summary>  
    string GetHour(float time)
    {
        int timer = (int)(time / 3600);
        string timerStr;
        if (timer < 10)
            timerStr = "0" + timer.ToString() + ":";
        else
            timerStr = timer.ToString() + ":";
        return timerStr;
    }
    /// <summary>  
    ///获取分钟   
    /// </summary>  
    string GetMinute(float time)
    {
        int timer = (int)((time % 3600) / 60);
        string timerStr;
        if (timer < 10)
            timerStr = "0" + timer.ToString() + ":";
        else
            timerStr = timer.ToString() + ":";
        return timerStr;
    }
    /// <summary>  
    /// 获取秒  
    /// </summary>  
    string GetSecond(float time)
    {
        int timer = (int)((time % 3600) % 60);
        string timerStr;
        if (timer < 10)
            timerStr = "0" + timer.ToString();
        else
            timerStr = timer.ToString();

        return timerStr;
    }
}
