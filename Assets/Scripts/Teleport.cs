using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform Player;
    public void TeleportRight(){
        Player.position = new Vector3(-2.6f, 2.0f, 1.2f);
    }

    public void TeleportLeft(){
        Player.position = new Vector3(1.5f, 1.9f, 1.4f);
    }
}
