using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPowerUp : MonoBehaviour
{
    public int armor;

    private void OnTriggerEnter(Collider other)
    {
        armor++;
        print(armor);
    }
}
