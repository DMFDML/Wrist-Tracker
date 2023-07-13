using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchSelect : MonoBehaviour
{

    GameObject leftHand;
    GameObject rightHand;
    Transform leftIndex;
    Transform leftThumb;
    Vector3 leftPinchPosition;
    Transform rightIndex;
    Transform rightThumb;
    Vector3 rightPinchPosition;
    float leftDist;
    float rightDist;
    // bool isTrackedLeft = false;

    float drawThresh = 0.1f;
    float detectThresh = 0.2f;

    public bool leftDrawFlag = false;
    public bool leftDetectFlag = false;
    public bool rightDrawFlag = false;
    public bool rightDetectFlag = false;

    void Start() 
    {
        leftHand = GameObject.Find("Left Hand Debug Draw Joints");
        rightHand = GameObject.Find("Right Hand Debug Draw Joints");

        rightIndex = rightHand.transform.Find("IndexTip").GetComponent<Transform>();
        rightThumb = rightHand.transform.Find("ThumbTip").GetComponent<Transform>();

        leftIndex = leftHand.transform.Find("IndexTip").GetComponent<Transform>();
        leftThumb = leftHand.transform.Find("ThumbTip").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        leftDist = Vector3.Distance(leftIndex.position, leftThumb.position);
        rightDist = Vector3.Distance(rightIndex.position, rightThumb.position);

        leftPinchPosition = Vector3.Lerp(leftIndex.position, leftThumb.position, 0.5f);
        rightPinchPosition = Vector3.Lerp(rightIndex.position, rightThumb.position, 0.5f);

        setFlags(leftDist, rightDist);

        Debug.Log("Left Detect" + leftDetectFlag);
        Debug.Log("Left Draw" + leftDrawFlag);
        Debug.Log("Right Detect" + rightDetectFlag);
        Debug.Log("Right Draw" + rightDetectFlag);
    }

    void setFlags(float leftDist, float rightDist) 
    {
        if (leftDist == 0 | leftDist > detectThresh)
        {
            leftDrawFlag = false;
            leftDetectFlag = false;
        } else if (leftDist <= drawThresh) {
            leftDrawFlag = true;
        } else {
            leftDetectFlag = true;
        }

        if (rightDist == 0 | rightDist > detectThresh)
        {
            rightDrawFlag = false;
            rightDetectFlag = false;
        } else if (rightDist <= drawThresh) {
            rightDrawFlag = true;
        } else {
            rightDetectFlag = true;
        }
    }
}
