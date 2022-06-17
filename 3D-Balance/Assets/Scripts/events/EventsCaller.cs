using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class EventsCaller : MonoBehaviour
{
    int count = 0;
    public TextMeshProUGUI DisplayText;
    public static event Action eventcaller;
    public static event Action eventcaller2;
    private BallSize ballSize;

    private void Start()
    {
        ballSize = FindObjectOfType<BallSize>();
        EventsCaller.eventcaller2 += Counter;
    }

    private void Update()
    {   
        eventcaller?.Invoke();

        if(ballSize != null)
        {
            if (ballSize.count == 0)
            {
                Debug.Log("count0");
            }

            if (ballSize.count == 1)
            {
                Debug.Log("count1");
            }
        }

    }

    public static void Counting()
    {
        eventcaller2?.Invoke();
    }

    public void Counter()
    {
        count++;

        DisplayText.text = "Point :- " + count;
    }

    private void OnDisable()
    {
        EventsCaller.eventcaller2 -= Counter;
    }






}
