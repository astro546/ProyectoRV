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
    public Baby BabyScript;
    public TextMeshProUGUI AtaudButtonText;
    bool babyObtained;
    bool ataudReady = false;

    public void OpenAtaud(){
        babyObtained = BabyScript.babyObtained;
        ataudTop.localPosition = new Vector3(-0.3f, 0.8f, 1.0f);

        if (ataudReady){
            SetBaby();
            AtaudButtonText.text = "Cerrar Ataud";
        }

        if (babyObtained){
            AtaudButtonText.text = "Colocar Bebe";
            ataudReady = true;
        } else {
            AtaudButtonText.text = "Cerrar Ataud";
        }
    }

    public void CloseAtaud(){
        ataudTop.localPosition = new Vector3(-0.3f, 0.8f, -0.03f);
        ataudReady = false;
        AtaudButtonText.text = "Abrir Ataud";
    }

    void SetBaby(){
        BabyObject.SetParent(AtaudObject);
        BabyObject.localPosition = new Vector3(1.2f, 0.2f, -1.0f);
        ataudReady = false;
    }
}
