using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drugipresent : MonoBehaviour
{
    public AudioSource presentsound;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            presentsound.Play();
            Destroy(gameObject);
        }
    }
}
