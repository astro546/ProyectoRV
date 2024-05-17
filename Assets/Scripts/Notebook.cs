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
    public TextMeshProUGUI NotebookText;
    public bool fistNoteReaded = false;

    public void ReadNotebook(){
        if (AtaudScript.firstPuzzleResolved){
            NotebookText.text = "Hay que hacer autopsia al cadaver que fallecio dos dias antes de Julio";
        } 
        NotebookPanel.transform.parent.gameObject.SetActive(true);
        NotebookPanel.SetActive(true);
        fistNoteReaded = true;
    }

    public void CloseNotebook(){
        NotebookPanel.transform.parent.gameObject.SetActive(false);
        NotebookPanel.SetActive(false);
        BabyButton.SetActive(true);
    }
}
