using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class colectcoin : MonoBehaviour
{
    public event Action pickupEVENT;
    public AudioSource coinscol;

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        pickupEVENT();
        coinscol.Play();
        gameObject.SetActive(false);
    }
}
