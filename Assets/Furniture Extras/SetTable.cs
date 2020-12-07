using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTable : MonoBehaviour
{
    [SerializeField] GameObject _original;
    [SerializeField] GameObject _plate;
    [SerializeField] GameObject _fork;
    [SerializeField] GameObject _spoon;
    [SerializeField] GameObject _knife;
    [SerializeField] GameObject _cup;
    [SerializeField] GameObject _lockedDoor;

    void Start() 
    {
        _original.SetActive(false);

        if (_plate != null && _fork != null && _spoon != null && _knife != null && _cup != null)
        {
            _lockedDoor.GetComponent<Animator>().enabled = true;  
        }
    }
}
