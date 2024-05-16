using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject cajonDoor;
    public GameObject cFuerteDoor;

    bool cajonDoorOpen = false;
    bool cFuerteDoorOpen = false;

    public void OpenCloseCajonDoor(){
        if (!cajonDoorOpen){
            cajonDoor.transform.Rotate(0,0,-90.0f, Space.Self);
            cajonDoorOpen = true;
        } else {
            cajonDoor.transform.Rotate(0,0,90.0f, Space.Self);
            cajonDoorOpen = false;
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
