using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    Renderer rend;

    public void ChangeMatDraw()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = gameObject.GetComponent<PinchDraw>().opaque;
    }

    public void ChangeMatDetect()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = gameObject.GetComponent<PinchDraw>().cutout;
    }
}
