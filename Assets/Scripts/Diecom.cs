using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Diecom : MonoBehaviour
{
    public static Diecom instance;
    public TextMeshProUGUI liczenie;
    private float odliczenie = 3.0f;
    private float sprawdzenie;
    private bool isdead = false;
    public GameObject diee;
    public bool alreadydied;
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (isdead)
        {
            if (sprawdzenie > 0)
            {
                sprawdzenie -= Time.deltaTime;
                liczenie.text = "Respawning in "+ Mathf.Ceil(sprawdzenie).ToString()+ "...";
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                isdead = false;
            }
        }
    }
    public void youdie()
    {
        if (!alreadydied)
        {
            alreadydied = true;
            diee.SetActive(true);
            isdead = true;
            sprawdzenie = odliczenie;
        }
    }
    
}
