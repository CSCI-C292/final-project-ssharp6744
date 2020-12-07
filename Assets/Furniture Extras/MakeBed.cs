using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBed : MonoBehaviour
{
    [SerializeField] GameObject _original;
    [SerializeField] GameObject _pillow1;
    [SerializeField] GameObject _pillow2;
    [SerializeField] GameObject _lockedDoor1;
    [SerializeField] GameObject _lockedDoor2;

    void Start() 
    {
        _original.SetActive(false);

        if (_pillow1 != null && _pillow2 != null)
        {
            _lockedDoor1.GetComponent<Animator>().enabled = true;
            _lockedDoor2.GetComponent<Animator>().enabled = true;
        }
           
    }
}
