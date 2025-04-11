using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondsHand;

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

        float hourRotation = time.Hour * 30f;
        float minutesRotation = time.Minute * 6f;
        float secondsRotation = time.Second * 6f;

        hourHand.transform.localEulerAngles = new Vector3(0f, hourRotation, 0f);
        minuteHand.transform.localEulerAngles = new Vector3(0f, minutesRotation, 0f);
        secondsHand.transform.localEulerAngles = new Vector3(0f, secondsRotation, 0f);

        Debug.Log(DateTime.Now.Hour);
        Debug.Log(DateTime.Now.Minute);
        Debug.Log(DateTime.Now.Second);
    }
}
