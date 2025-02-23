using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public int targetScore = 4;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    } 

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score);

        if (score >= targetScore)
        {
            LoadNewScene();
        }
    }
    void LoadNewScene()
    {
        SceneManager.LoadScene("VictoryScene");
    }
}
