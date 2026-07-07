using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;


public class TimeController : MonoBehaviour
{
    public TMP_Text timeText;
    public enum DayTime
    {
        Morning,
        Afternoon,
        Evening
    }

    public DayTime currentTime = DayTime.Morning;

    void Start()
    {
        ApplyTime();
    }

    public void NextTime()
    {
        switch (currentTime)
        {
            case DayTime.Morning:
                currentTime = DayTime.Afternoon;
                break;

            case DayTime.Afternoon:
                currentTime = DayTime.Evening;
                break;

            case DayTime.Evening:
                currentTime = DayTime.Morning;
                break;
        }

        ApplyTime();

       
    }

    public void ApplyTime() //event each time
    {
        timeText.text = currentTime.ToString();
        Debug.Log("This time is: " + currentTime);

        
    }


}