using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public UnityEvent powerUpEvent;
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        print(score);
        powerUpEvent.Invoke();
    }
}

