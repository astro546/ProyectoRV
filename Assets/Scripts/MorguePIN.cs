using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class MorguePIN : MonoBehaviour
{
    public TextMeshProUGUI PINText;
    public GameObject Corpse;

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
    }

    IEnumerator sleep(){
        yield return new WaitForSeconds(2);
    }
}
