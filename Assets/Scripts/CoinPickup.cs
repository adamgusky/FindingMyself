using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinSFX;
    [SerializeField] AudioSource coinSource;
    [SerializeField] int pointsForCoinPickup = 100;
    bool wasCollected = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !wasCollected) {
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
            coinSource.PlayOneShot(coinSFX);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }    
    }
}
