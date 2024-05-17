using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public GameObject BabyButton;
    public Transform CameraPlayer;
    public Transform BabyObject;
    public bool babyObtained = false;

    public void GetBaby(){
        BabyObject.SetParent(CameraPlayer);
        BabyObject.localPosition = new Vector3(1.6f, -0.7f, 2.7f);
        BabyObject.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        BabyButton.SetActive(false);
        babyObtained = true;
    }


}
