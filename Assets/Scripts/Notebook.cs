using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Notebook : MonoBehaviour
{
    public GameObject NotebookPanel;
    public GameObject BabyButton;
    public Ataud AtaudScript;
    public MorguePIN morgueScript;
    public TextMeshProUGUI NotebookText;
    public bool fistNoteReaded = false;

    public void ReadNotebook(){

        if (AtaudScript.firstPuzzleResolved){
            NotebookText.text = "Hay que hacer autopsia al cadaver que fallecio dos dias antes de Agosto";
        } 

        if (morgueScript.secondPuzzleResolved){
            NotebookText.text = "Si algo raro llega a pasar, hay un regalito en la caja fuerte. El diablo estara de tu lado y con el 8 seran de la suerte.";
        }
        
        NotebookPanel.transform.parent.gameObject.SetActive(true);
        NotebookPanel.SetActive(true);
        fistNoteReaded = true;
    }

    public void CloseNotebook(){
        NotebookPanel.transform.parent.gameObject.SetActive(false);
        NotebookPanel.SetActive(false);
        if (!AtaudScript.firstPuzzleResolved){
            BabyButton.SetActive(true);
        }
    }
}
