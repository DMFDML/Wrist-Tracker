using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSketchable : MonoBehaviour
{

    public GameObject objectSketchParent;

    private void OnTriggerEnter(Collider col) 
    {
        
        // Change tag to sketch
        col.gameObject.tag = "Sketch";
        
        // If there isn't a matching parent, make one
        if (GameObject.Find(col.gameObject.name + "Parent") == null )
        {
            objectSketchParent = new GameObject(col.gameObject.name + "Parent");
        }

        //Add the object as a child


    }
}
