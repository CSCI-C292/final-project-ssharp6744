using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _locked;

    void OnMouseOver() 
    {
        if (Vector3.Distance(GameObject.Find("First Person Player").transform.position, transform.parent.position) <= 3)
        {
            if (!_animator.enabled)
            {
                _locked.SetActive(true);
            }

            if (_animator.enabled && Input.GetButtonDown("Fire1"))
            {
                _animator.SetTrigger("OpenDoor");
            }
        }
    }

    void OnMouseExit() 
    {
        if (_locked != null)
            _locked.SetActive(false);
    }
}
