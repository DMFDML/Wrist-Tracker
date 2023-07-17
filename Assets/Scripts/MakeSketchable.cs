using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSketchable : MonoBehaviour
{

    public GameObject objectSketchParent;

    private void OnTriggerEnter(Collider col) 
    {

        if (col.gameObject.transform.parent.tag == "Sketchable")
        {
            col.gameObject.transform.parent.tag = "Sketch";
        }
        
    }

    private void OnTriggerExit(Collider col) 
    {
        col.gameObject.transform.parent.tag = "Sketchable";
    }
}
