using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateplane : MonoBehaviour
{
    public AudioSource planesound;
    public MonoBehaviour planemove;
    private void Start()
    {
        planemove.enabled = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            planemove.enabled = true;
            planesound.Play();
        }
    }

}

