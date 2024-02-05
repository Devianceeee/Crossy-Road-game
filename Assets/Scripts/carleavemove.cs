using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carleavemove : MonoBehaviour
{
    public int speed;
    public GameObject car;
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    //private void OnTriggerEnter(Collider other)
    //{
        //if (other.CompareTag("Border"))
        //{
         //   car.transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
        //}
    //
    
}
        


    

