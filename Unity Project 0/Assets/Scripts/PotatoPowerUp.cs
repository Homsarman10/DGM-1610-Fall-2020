using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoPowerUp : MonoBehaviour
{
    public int potatoes;

    private void OnTriggerEnter(Collider other)
    {
        potatoes++;
            print(potatoes);
    }
}
