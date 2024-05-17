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
        Player.position = new Vector3(-2.6f, 2.0f, 1.2f);
        MorgueScript.playerInMorgue = false;
        MorgueButtonText.text = "Ir a Morgue";
    }

    public void TeleportLeft(){
        Player.position = new Vector3(1.5f, 1.9f, 1.4f);
        MorgueScript.playerInMorgue = false;
        MorgueButtonText.text = "Ir a Morgue";
    }
}
