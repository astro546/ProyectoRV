using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    public GameObject cajonDoor;
    public GameObject cFuerteDoor;
    public GameObject NotebookButton;
    public TextMeshProUGUI cajonButtonText;
    public TextMeshProUGUI cFuerteButtonText;

    bool cajonDoorOpen = false;
    bool cFuerteDoorOpen = false;

    public void OpenCloseCajonDoor(){
        if (!cajonDoorOpen){
            cajonDoor.transform.Rotate(0,90.0f,0, Space.Self);
            cajonButtonText.text = "Cerrar puerta";
            cajonDoorOpen = true;
            NotebookButton.SetActive(true);
        } else {
            cajonDoor.transform.Rotate(0,-90.0f,0, Space.Self);
            cajonButtonText.text = "Abrir puerta";
            cajonDoorOpen = false;
            NotebookButton.SetActive(false);
        }
    }

    public void OpenCloseCFuerteDoor(){
        if (!cFuerteDoorOpen){
            cFuerteDoor.transform.Rotate(0,0,-90.0f, Space.Self);
            cFuerteDoorOpen = true;
        } else {
            cFuerteDoor.transform.Rotate(0,0,90.0f, Space.Self);
            cFuerteDoorOpen = false;
        }
    }
}
