using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koniecstar : MonoBehaviour
{
    public AudioSource finish;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            finish.Play();
            PlayerPrefs.SetInt("TotalScore", GameManager.instance.score);

        }

    }
}
