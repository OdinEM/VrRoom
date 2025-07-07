using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime time = DateTime.Now;

        float seconds = time.Second + time.Millisecond / 1000f;
        float minutes = time.Minute + seconds / 60f;
        float hours = time.Hour % 12 + minutes / 60f;

        // 360 degrees in a full circle; 60 seconds/minutes; 12 hours
        secondHand.localRotation = Quaternion.Euler(0f, 0f, -seconds * 6f);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minutes * 6f);
        hourHand.localRotation = Quaternion.Euler(0f, 0f, -hours * 30f);
    }
}
