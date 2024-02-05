using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager instance;
    GameObject[] gameObjects;
    public int maxscore;
    public TextMeshProUGUI textcik;
    void Start()
    {
        liczyc();
        foreach (var item in gameObjects)
        {
            item.GetComponent<colectcoin>().pickupEVENT += zlicz;
        }
    }

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        
    }
    public void liczyc()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("coin");
        maxscore = gameObjects.Length;
    }
    public void cointext()
    {
        textcik.text = "Score: " + score;
    }
    public void zlicz()
    {
        score++;
        print(score);
        cointext();
    }
    
}
