using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy : MonoBehaviour
{
    [SerializeField] GameObject _original;
    [SerializeField] GameObject _lockedDoor;

    void Start() 
    {
        _original.SetActive(false);
        _lockedDoor.GetComponent<Animator>().enabled = true;  
    }
}
