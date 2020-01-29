using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 10f;
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        TimerText.text = currentTime.ToString("f1");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
