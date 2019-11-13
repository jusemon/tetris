using System;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GameObject.Find("Time").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        var time = Time.time;
        var minutes = Mathf.FloorToInt(time / 60).ToString("00");
        var seconds = Mathf.FloorToInt(time % 60).ToString("00");
        timeText.text = $"Time: {minutes}:{seconds}";
    }
}
