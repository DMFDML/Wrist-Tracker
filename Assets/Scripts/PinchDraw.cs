using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchDraw : MonoBehaviour
{

    public GameObject pinchManager;
    public bool isLeft = false;
    Vector3 pinchPosition;
    public bool detectFlag = false;
    public bool drawFlag = false;

    Renderer rend;
    public Material cutout;
    public Material opaque;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetPinchPosition(isLeft);

        GetFlags(isLeft);

        if (drawFlag) {
            rend.enabled = true;
            rend.material = opaque;
            transform.position = pinchPosition;
        } else if (detectFlag) {
            rend.enabled = true;
            rend.material = cutout;
            transform.position = pinchPosition;
        } else {
            rend.enabled = false;
        }

        
    }

    void GetFlags(bool isLeft) 
    {
        if (isLeft == true) {
            detectFlag = pinchManager.GetComponent<PinchSelect>().leftDetectFlag;
            drawFlag = pinchManager.GetComponent<PinchSelect>().leftDrawFlag;
        } else {
            detectFlag = pinchManager.GetComponent<PinchSelect>().rightDetectFlag;
            drawFlag = pinchManager.GetComponent<PinchSelect>().rightDrawFlag;
        }
    }
    

    void GetPinchPosition(bool isLeft)
    {
        if (isLeft == true) {
            pinchPosition = pinchManager.GetComponent<PinchSelect>().leftPinchPosition;
        } else {
            pinchPosition = pinchManager.GetComponent<PinchSelect>().rightPinchPosition;
        }
    }
}
