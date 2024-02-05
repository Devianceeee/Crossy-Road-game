using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class odczytscore : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI endscore;
    void Start()
    {
        score = PlayerPrefs.GetInt("TotalScore");
        endscore.text = "Your score: " + score;
    }
}
