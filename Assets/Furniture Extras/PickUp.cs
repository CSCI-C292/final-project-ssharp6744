using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour
{
    [SerializeField] Transform _objectPosition;
    [SerializeField] GameObject _copy;
    [SerializeField] GameObject _fade;
    bool pickedUp = false;

    void Update() 
    {
        if (pickedUp)
        {
            //GetComponent<Rigidbody>().MovePosition(_objectPosition.position);
            transform.position = _objectPosition.position;
        }
    }

    //This video helped me with this script: https://www.youtube.com/watch?v=IEV64CLZra8
    void OnMouseDown() 
    {
        if (Vector3.Distance(GameObject.Find("First Person Player").transform.position, transform.position) <= 3)
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().freezeRotation = true;
            pickedUp = true; 
        }
         
        if (name == "gingerBread")
        {
            StartCoroutine(WaitTime());
        }
    }

    void OnMouseUp() 
    {
        GetComponent<Rigidbody>().useGravity = true; 
        GetComponent<Rigidbody>().freezeRotation = false;
        pickedUp = false;

        if (_copy != null && Vector3.Distance(transform.position, _copy.transform.position) <= 1.5f)
        {
            _copy.SetActive(true);
        }   
    }
    
    IEnumerator WaitTime()
    {
        _fade.SetActive(true); 
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Ending");
        yield return new WaitForEndOfFrame();
        _fade.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
}
