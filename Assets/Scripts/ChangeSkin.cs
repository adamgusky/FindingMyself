using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    [SerializeField] public AnimatorOverrideController feetController;
    [SerializeField] public AnimatorOverrideController armsController;

    public void JustFeetSkin() {
        GetComponent<PlayerMovement>().UpdateLevel(1);
        GetComponent<Animator>().runtimeAnimatorController = feetController as RuntimeAnimatorController;
    }

    public void ArmsSkin() {
        FindObjectOfType<GameSession>().lastLevel = 2;
        GetComponent<PlayerMovement>().UpdateLevel(2);
        GetComponent<Animator>().runtimeAnimatorController = armsController as RuntimeAnimatorController;
    }
}
