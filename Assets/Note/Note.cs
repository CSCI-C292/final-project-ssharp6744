using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] GameObject _note;
    [SerializeField] Dialogue _dialog;
    
    void OnMouseUpAsButton() 
    {
        if (Vector3.Distance(GameObject.Find("First Person Player").transform.position, transform.position) <= 2)
        {
            _note.SetActive(true);
            GameEvents.InvokeDialogInitiated(_dialog);
        }
    }
}
