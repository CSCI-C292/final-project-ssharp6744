using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] Transform _destination;
    [SerializeField] Transform _objectPosition;
    [SerializeField] GameObject _copy;

    //This video helped me with this script: https://www.youtube.com/watch?v=IEV64CLZra8
    void OnMouseDown() 
    {
        if (Vector3.Distance(GameObject.Find("First Person Player").transform.position, transform.position) <= 2)
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            transform.position = _objectPosition.position;
            transform.parent = GameObject.Find("Destination").transform; 
            
        }
         
    }

    void OnMouseUp() 
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true; 
        GetComponent<Rigidbody>().freezeRotation = false;

        if (_copy != null && Vector3.Distance(transform.position, _copy.transform.position) <= 1)
        {
            _copy.SetActive(true);
        }   
    }

    void OnMouseEnter() 
    {
        var outline = gameObject.AddComponent<Outline>();

        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 5f;
    }

    void OnMouseExit() 
    {
        Destroy(GetComponent<Outline>());
    }
}
