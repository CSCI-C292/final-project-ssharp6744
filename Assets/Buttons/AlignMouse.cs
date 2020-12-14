using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignMouse : MonoBehaviour
{
    [SerializeField] GameObject _align;
    [SerializeField] Dialogue _intro;
    
    /*public void OnCLick()
    {
        _align.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }*/

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _align.SetActive(false);
            GameEvents.InvokeDialogInitiated(_intro);
        }
    }
}
