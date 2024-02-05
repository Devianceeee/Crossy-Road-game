using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plushealth : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.instance.currenthealth = 3;
            Player.instance.Hearts.maxhealth(Player.instance.maxhealth);
        }
    }
}
