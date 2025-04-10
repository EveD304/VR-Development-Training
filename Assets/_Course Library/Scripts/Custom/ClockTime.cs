using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    public Transform hourHand, minuteHand, secondHand;

    const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;

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
        DateTime time = DateTime.Now;

        //hourHand.transform.localEulerAngles = new Vector3(time.Hour * 30, 0, 0);
        secondHand.transform.localEulerAngles = new Vector3(time.Second * 6f, secondHand.transform.localEulerAngles.y, secondHand.transform.localEulerAngles.z);
        //minuteHand.transform.localEulerAngles = new Vector3(time.Minute * 6, 0, 0);
        //hourHand.rotation = Quaternion.Euler(time.Hour * degreesPerHour, 0f, 180f);
        //minuteHand.rotation = Quaternion.Euler(time.Minute * degreesPerMinute, 0f, 180f);
        //secondHand.rotation = Quaternion.Euler(time.Second * degreesPerSecond, 0f, 180f);

        //float hoursF = float.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        //float minutesF = float.Parse(System.DateTime.UtcNow.ToString("mm"));
        //float secondsF = float.Parse(System.DateTime.UtcNow.ToString("ss"));

        //print(hoursInt + ":" + minutesInt + ":" + secondsInt);

        //iTween.RotateTo(secondHand, iTween.Hash("y", secondsInt * 6 * -1, "time", 1, "easetype", "easeOutQuint"));
    }
}
