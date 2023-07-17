using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSketchManager : MonoBehaviour
{

    public void CollisionDetected(Component childscript) {
        Debug.Log("child collided");
    }
}
