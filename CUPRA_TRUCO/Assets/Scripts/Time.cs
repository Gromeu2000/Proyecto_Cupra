using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public Text currentTime;

    // Update is called once per frame
    void Update()
    {
        currentTime.text =
             System.DateTime.Now.Hour.ToString("00") + ":" +
             System.DateTime.Now.Minute.ToString("00");
    }
}
