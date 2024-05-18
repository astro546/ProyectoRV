using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CFuerte : MonoBehaviour
{
    public TextMeshProUGUI PINCFuerteText;
    public TextMeshProUGUI CFuerteButtonText;
    public GameObject CFuerteButton;
    public GameObject cFuerteDoor;
    public GameObject GunButton;
    public GameObject GunCamera;
    public GameObject ZombieSleep;
    public GameObject Zombie;
    public GameObject GunShootButton;
    public GameObject CanvasScene;
    public Transform GunObject;
    bool ThirdPuzzleResolved = false;
    bool cFuerteDoorOpen = false;
    bool PINCorrect = false;
    bool gunObtained = false;

    public void EnterNumberCFuerte(){
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName != "SendPINButton" && PINCFuerteText.text.Length < 4){
            PINCFuerteText.text += buttonName;
        }
    }

    public void SendCFuertePIN(){
        if (PINCFuerteText.text != "6668"){
            PINCFuerteText.text = "Acceso Denegado";
            sleep();
            PINCFuerteText.text = "";
        } else {
            PINCFuerteText.text = "Acceso Concedido";
            PINCorrect = true;
            ThirdPuzzleResolved = true;
            CFuerteButtonText.text = "Cerrar caja fuerte";
            openCFuerteDoor();
        }
    }

    public void openCFuerteDoor(){
        cFuerteDoor.transform.Rotate(0,0,-90.0f, Space.Self);
        cFuerteDoorOpen = true;
        if (PINCorrect){
            GunButton.SetActive(true);
        }
        if (gunObtained){
            GunButton.SetActive(false);
        }
    }

    public void closeCFuerteDoor(){
        cFuerteDoor.transform.Rotate(0,0,90.0f, Space.Self);
        cFuerteDoorOpen = false;
        GunButton.SetActive(false);
    }

    public void closeCFuertePIN(){
        PINCFuerteText.text = "";
        this.gameObject.SetActive(false);
        CFuerteButton.SetActive(true);
        if (PINCorrect){
            GunButton.SetActive(true);
        }
    }

    public void openCFuertePIN(){
        CFuerteButton.SetActive(false);
        this.gameObject.SetActive(true);
        GunButton.SetActive(false);
    }

    public void onClickCFuerteButton(){
        if (!cFuerteDoorOpen){
            if (PINCorrect){
                openCFuerteDoor();
                CFuerteButtonText.text = "Cerrar caja fuerte";
            } else {
                openCFuertePIN();
            }
        } else {
            closeCFuerteDoor();
            CFuerteButtonText.text = "Abrir caja fuerte";
        }
    }

    void deactivateButtons(){
        CanvasScene.transform.GetChild(0).gameObject.SetActive(false);
        CanvasScene.transform.GetChild(2).gameObject.SetActive(false);
        CanvasScene.transform.GetChild(4).gameObject.SetActive(false);
    }

    public void getGun(){
        GunCamera.SetActive(true);
        GunObject.gameObject.SetActive(false);
        GunButton.SetActive(false);
        gunObtained = true;
        deactivateButtons();
        GunShootButton.transform.parent.gameObject.SetActive(true);
        GunShootButton.SetActive(true);
        ZombieSleep.SetActive(false);
        Zombie.SetActive(true);
    }

    IEnumerator sleep(){
        yield return new WaitForSeconds(2);
    }
}
// (0.686, -0.38, 1.044)