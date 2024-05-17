using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class MorguePIN : MonoBehaviour
{
    public TextMeshProUGUI PINText;
    public TextMeshProUGUI MorgueButtonText;
    public GameObject Corpse;
    public GameObject MorgueButton;
    public Transform Player;
    public bool playerInMorgue = false;

    public void EnterNumber(){
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName != "SendPINButton" && PINText.text.Length < 4){
            PINText.text += buttonName;
        }
    }
    public void SendPIN(){
        if (PINText.text != "2907"){
            PINText.text = "Acceso Denegado";
            sleep();
            PINText.text = "";
        } else {
            PINText.text = "Acceso Concedido";
            Corpse.SetActive(true);
        }
    }

    public void closePIN(){
        PINText.text = "";
        this.gameObject.SetActive(false);
        MorgueButton.SetActive(true);
    }

    public void openPIN(){
        MorgueButton.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void TeleportMorgue(){
        Player.position = new Vector3(-1.835f, 1.867f, -1.53f);
        playerInMorgue = true;
    }

    public void onClickMorgueButton(){
        if (!playerInMorgue){
            TeleportMorgue();
            MorgueButtonText.text = "Insertar PIN";
        } else {
            openPIN();
        }
    }

    IEnumerator sleep(){
        yield return new WaitForSeconds(2);
    }
}
