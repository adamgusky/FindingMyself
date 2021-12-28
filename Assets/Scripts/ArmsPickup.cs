using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSFX;
    [SerializeField] AudioSource pickupSource;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            GameSession.lastCheckPointPos = transform.position;
            FindObjectOfType<GameSession>().SetScoreAtCheckpoint(FindObjectOfType<GameSession>().score);

            FindObjectOfType<ChangeSkin>().ArmsSkin();
            pickupSource.PlayOneShot(pickupSFX, 0.5f);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }    
    }
}