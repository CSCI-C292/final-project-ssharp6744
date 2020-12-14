using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class Toggle : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            GetComponent<Outline>().enabled = false;
        }

        // Update is called once per frame
        /*void Update()
        {
            if(Input.GetKeyDown(KeyCode.K))
            {
                GetComponent<Outline>().enabled = !GetComponent<Outline>().enabled;
            }
        }*/

        void OnMouseEnter() 
        {
            GetComponent<Outline>().enabled = true;
        }

        void OnMouseExit() 
        {   
            GetComponent<Outline>().enabled = false;
        }
    }
}