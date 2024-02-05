using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class Player : MonoBehaviour
{
    public static Player instance;
    public AudioSource hitsound;
    public Transform chicken;
    public TextMeshProUGUI dietext;
    public int maxhealth = 3;
    public int currenthealth = 3;
    public hearts Hearts;
    public float niematime = 2f;
    public bool niema = false;
    public float niematimer;
    public MeshRenderer sfera;
    private void Start()
    {
        currenthealth = maxhealth;
        Hearts.maxhealth(maxhealth);
    }
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        movechicken();
        if (niema)
        {
            if (Time.time > niematimer)
            {
                niema = false;
                sfera.enabled = false;
            }
        }
        checkhealth();
    }
    private void movechicken()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            chicken.transform.rotation = Quaternion.Euler(0, -180, 0);
            transform.Translate(Vector3.back, Space.World);
            
            //chicken.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            chicken.transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.forward, Space.World);
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            chicken.transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.Translate(-Vector3.right, Space.World);
            

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            chicken.transform.rotation = Quaternion.Euler(0, -270, 0);
            transform.Translate(Vector3.right, Space.World);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            damagetake(1);
            hitsound.Play();
        }
        if (other.CompareTag("wodadie"))
        {
            Diecom.instance.youdie();
            hitsound.Play();
        }

    }

    public void checkhealth()
    {
        if(currenthealth <= 0 && !Diecom.instance.alreadydied)
        {
            Diecom.instance.youdie();
        }
    }

    public void damagetake(int damage)
    {
        if (niema) return;
        currenthealth-=damage;
        Hearts.sethealth(currenthealth);
        niema=true;
        niematimer = Time.time + niematime;
        sfera.enabled = true;
    }
}