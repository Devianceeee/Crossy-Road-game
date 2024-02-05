using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presentappear : MonoBehaviour
{
    
    
    public GameObject touch;
    public GameObject present;
    public Rigidbody presentrb;
    public MeshRenderer presentmr;
   
    void Start()
    {
        presentrb = present.GetComponent<Rigidbody>();
        presentmr = present.GetComponent<MeshRenderer>();
        presentrb.useGravity = false;
        presentmr.enabled = false;
    }

    
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("touch"))
        {
            Debug.Log("1");
            presentrb.useGravity = true;
            presentmr.enabled = true;
        }

    }
}
