using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planemove : MonoBehaviour
{
    public int speed;
    public GameObject planee;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(-Vector3.up * Time.deltaTime * speed);
    }
}
