using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    public GameObject NotebookPanel;
    public GameObject BabyButton;
    public bool fistNoteReaded = false;

    public void ReadNotebook(){
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
