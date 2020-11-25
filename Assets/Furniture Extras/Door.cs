using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animator _animator;

    void OnMouseOver() 
    {
        if (Vector3.Distance(GameObject.Find("First Person Player").transform.position, transform.parent.position) <= 2 && Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("OpenDoor");
        }
    }
}
