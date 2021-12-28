using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] AudioClip exitSFX;
    [SerializeField] AudioSource exitSource;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            exitSource.PlayOneShot(exitSFX);
            FindObjectOfType<GameSession>().Win();
        }
    }
}
