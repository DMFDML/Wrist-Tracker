using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resetSlider : MonoBehaviour
{

    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReset()
    {
///     resets the slider to the middle
        GetComponent<Slider>().value = 0.5f;
    }

}
