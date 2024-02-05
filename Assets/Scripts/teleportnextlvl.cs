using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportnextlvl : MonoBehaviour
{
    public AudioSource nextsound;
    public Transform teleport_coordinate;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            other.transform.position = teleport_coordinate.transform.position;
        nextsound.Play();
    }
}
