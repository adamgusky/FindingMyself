using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    [SerializeField] public AnimatorOverrideController feetController;
    [SerializeField] public AnimatorOverrideController armsController;

    public void JustFeetSkin() {
        GetComponent<PlayerMovement>().level = 1;
        FindObjectOfType<PlayerMovement>().totalJumps = 1;
        GetComponent<Animator>().runtimeAnimatorController = feetController as RuntimeAnimatorController;
    }

    public void ArmsSkin() {
        GetComponent<PlayerMovement>().level = 2;
        GetComponent<Animator>().runtimeAnimatorController = armsController as RuntimeAnimatorController;
    }
}
