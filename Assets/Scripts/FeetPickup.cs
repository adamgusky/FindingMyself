using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSFX;
    [SerializeField] AudioSource jumpSource;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            FindObjectOfType<ChangeSkin>().JustFeetSkin();
            jumpSource.PlayOneShot(pickupSFX, 0.5f);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }    
    }
}