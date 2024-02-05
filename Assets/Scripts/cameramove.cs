using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject player;
    public GameObject maincamera;
    Vector3 offset;
    void Start()
    {
        offset = player.transform.position - maincamera.transform.position;
    }

 
    void Update()
    {
        maincamera.transform.position = player.transform.position - offset;
    }
    
}
