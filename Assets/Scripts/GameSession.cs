using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.InputSystem;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] TextMeshProUGUI missingCoinsText;
    [SerializeField] TextMeshProUGUI restartText;
    [SerializeField] TextMeshProUGUI scoreText;
    public static Vector2 lastCheckPointPos;
    public static int lastCheckPointScore;
    public int score = 0;
    public int lastLevel;
    void Awake() {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        FindObjectOfType<PlayerMovement>().UpdateLevel(lastLevel);
        score = lastCheckPointScore;
        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        score = lastCheckPointScore;
        scoreText.text = "Score: " + score.ToString();
        
        winText.enabled = false;
        missingCoinsText.enabled = false;
        restartText.enabled = false;
        scoreText.enabled = true;
    }

    public void Win() {
        if (score >= 1000) {
            winText.enabled = true;
        } else {
            missingCoinsText.enabled = true;
        }
    }

    public void ProcessPlayerDeath() {
        restartText.enabled = true;
    }

    public void AddToScore(int pointsToAdd) {
        score += pointsToAdd;
        scoreText.text = "Score: " + score.ToString();
    }

    public void ResetGameSession() {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    public void SetScoreAtCheckpoint(int checkpointScore) {
        lastCheckPointScore = checkpointScore;
    }
}
