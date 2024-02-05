using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hearts : MonoBehaviour
{
    private int maxhearts;
    public Image[] heart;

    private void Start()
    {
        maxhearts = heart.Length;
    }
    public void maxhealth(int health)
    {
        for (int i = 0; i < heart.Length; i++){
            heart[i].enabled = (i < health);
        }
    }
    public void zrobzdrowie(int maxhealth)
    {
        maxhearts = Mathf.Clamp(maxhealth,0,heart.Length);
        for (int i = 0; i < heart.Length; i++){
            heart[i].enabled = (i < maxhealth);
        }
    }
    public void sethealth(int health)
    {
        for (int i = 0; i < heart.Length; i++)
        {
            heart[i].enabled = (i < health);
        }
    }
}
