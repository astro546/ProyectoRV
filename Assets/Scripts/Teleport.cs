using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Teleport : MonoBehaviour
{
    public Transform Player;
    public MorguePIN MorgueScript;
    public TextMeshProUGUI MorgueButtonText;

    public void TeleportRight(){
        Player.position = new Vector3(-3.1f, 2.0f, -0.65f);
        MorgueScript.playerInMorgue = false;
        MorgueButtonText.text = "Ir a Morgue";
    }

    public void TeleportLeft(){
        Player.position = new Vector3(2.97f, 1.87f, -0.12f);
        MorgueScript.playerInMorgue = false;
        MorgueButtonText.text = "Ir a Morgue";
    }
}
