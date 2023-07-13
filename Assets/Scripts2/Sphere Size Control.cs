using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSizeControl : MonoBehaviour 
{
    [SerializeField]float radiusLowerBound;
    [SerializeField] float radiusUpperBound;
    float radius;
    float radiusRange;
    Vector3 scale;
    Vector3 offset;

    void Awake()
    {
        /// Initialise a bunch of stuff
        radiusLowerBound = Random.Range(0.01f, 0.08f);
        radiusUpperBound = radiusLowerBound + 0.15f;
        radiusRange = radiusUpperBound - radiusLowerBound;
        radius = (radiusLowerBound + radiusUpperBound) / 2;
        scale = new Vector3(radius, radius, radius);
    }
    

    public void OnSliderValueChanged(float value)
    {
        /// Called when the slider changes, resets the radius to the new value from the slider between the limits
        radius = radiusLowerBound + (value * radiusRange);
        scale = new Vector3(radius, radius, radius);
        offset = new Vector3(0f, radius / 2, 0f);
        transform.localScale = scale;
        transform.localPosition = offset;
        
    }

    public void OnConfirm()
    {
        /// Called when confirm buttonm is pressed, resizes the sphere to the correct size and stores data about the size and the material, and time taken maybe?
        transform.localScale = new Vector3(0.12f,0.12f,0.12f);
        
        transform.localPosition = new Vector3(0f, 0.06f, 0f);
    }

    public void OnReset()
    {
        /// Called when reste button is pressed, picks some new size limits and resets sphere size
        radiusLowerBound = Random.Range(0.01f, 0.08f);
        radiusUpperBound = radiusLowerBound + 0.15f;
        radiusRange = radiusUpperBound - radiusLowerBound;
        radius = (radiusLowerBound + radiusUpperBound) / 2;
        scale = new Vector3(radius, radius, radius);
        offset = new Vector3(0f, radius / 2, 0f);
        transform.localScale = scale;
        transform.localPosition = offset;
    }

    // Start is called before the first frame update
    void Start()
    {
        OnReset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
