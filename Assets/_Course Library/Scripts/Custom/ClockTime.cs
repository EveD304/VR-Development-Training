using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand;

    string oldSeconds;

    // Update is called once per frame
    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");

        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = seconds;
    }

    void UpdateTimer()
    {
        int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
        
        print(hoursInt + ":" + minutesInt + ":" + secondsInt);
    }
}
