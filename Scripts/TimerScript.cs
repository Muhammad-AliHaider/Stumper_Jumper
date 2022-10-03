using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public static float TimeLeft;
    public static bool TimerOn = false ;
    public TMP_Text TimerTxt;
    public Win[] win;
    public LevelManager level;
    void Start()
    {
        TimerOn=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            TimeLeft = TimeLeft + Time.deltaTime;
            UpdateTimer(TimeLeft);
        }

        if (win[level.getCurrLevel() - 1].getWin() == true)
        {
            TimerOn = false;
        }
        else if (win[level.getCurrLevel() - 1].getWin() == false)
        {
            TimerOn = true;
        }

    }
    public void resetTime()
    {
        TimeLeft = 0;
    }

    public float getTime()
    {
        return TimeLeft;
    }

    void UpdateTimer(float currentTimer)
    {
        currentTimer += 1;
        string minutes = Mathf.FloorToInt(currentTimer / 60).ToString("00");
        string seconds = Mathf.FloorToInt(currentTimer % 60).ToString("00");
        //TimerTxt.text = string.Format("(00:00)", minutes, seconds);
        TimerTxt.text = (minutes + ":" + seconds).ToString();
    }
}
