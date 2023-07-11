using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchSelect : MonoBehaviour
{

    GameObject leftHand;
    Vector3 leftIndex;
    Vector3 leftThumb;
    float dist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftHand = GameObject.Find("Left Hand Debug Draw Joints");

        if (leftHand != null)
        {
            leftIndex = leftHand.transform.Find("IndexTip").GetComponent<Transform>().position;
            leftThumb = leftHand.transform.Find("ThumbTip").GetComponent<Transform>().position;

            dist = Vector3.Distance(leftIndex, leftThumb);

            Debug.Log(dist);
        }
    }
}
