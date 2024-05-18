using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public GameObject BabyButton;
    public GameObject BabyCam;
    public Transform CameraPlayer;
    public Transform BabyObject;
    public bool babyObtained = false;

    public void GetBaby(){
        BabyObject.gameObject.SetActive(false);
        BabyCam.SetActive(true);
        BabyButton.SetActive(false);
        babyObtained = true;
    }


}
