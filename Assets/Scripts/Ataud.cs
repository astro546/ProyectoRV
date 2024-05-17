using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ataud : MonoBehaviour
{
    public Transform ataudTop;
    public Transform BabyObject;
    public Transform AtaudObject;
    public GameObject BabyObjectAtaud;
    public Baby BabyScript;
    public TextMeshProUGUI AtaudButtonText;
    bool babyObtained;
    bool ataudReady = false;
    bool ataudOpen = false;

    public void OpenCloseAtaud(){
        babyObtained = BabyScript.babyObtained;
        if (!ataudOpen || ataudReady){
            ataudTop.localPosition = new Vector3(-0.3f, 0.8f, 1.0f);
            
            if (ataudReady){
                SetBaby();
                AtaudButtonText.text = "Cerrar Ataud";
                babyObtained = false;
            }

            if (babyObtained){
                AtaudButtonText.text = "Colocar Bebe";
                ataudReady = true;
            } else {
                AtaudButtonText.text = "Cerrar Ataud";
            }
            ataudOpen = true;

        } else if (!ataudReady) {
            ataudTop.localPosition = new Vector3(-0.3f, 0.8f, -0.03f);
            ataudReady = false;
            ataudOpen = false;
            AtaudButtonText.text = "Abrir Ataud";
        }
        
    }

    void SetBaby(){
        BabyObject.gameObject.SetActive(false);
        BabyObjectAtaud.SetActive(true);
        ataudReady = false;
    }
}
