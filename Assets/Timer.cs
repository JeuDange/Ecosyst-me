using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.timeSinceLevelLoad;
        int days = Mathf.FloorToInt(elapsedTime / 86400);
        elapsedTime -= days * 86400;
        int hours = Mathf.FloorToInt(elapsedTime / 3600);
        elapsedTime -= hours * 3600;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00} Seconds\n{1:00} Minutes\n{2:00} Hours\n{3:00} Days\n", seconds, minutes, hours, days);
    }
}

