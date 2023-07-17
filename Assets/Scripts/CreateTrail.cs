using UnityEngine;

/// <summary>
/// This script creates a trail at the location of a gameobject with a particular width and color.
/// </summary>

public class CreateTrail : MonoBehaviour
{
    public GameObject trailPrefab = null;

    private float width = 0.15f;
    private Color color = Color.white;

    private GameObject currentTrail = null;

    public GameObject sketchParent;

    public void StartTrail()
    {
        if (!currentTrail)
        {

            if (sketchParent == null)
            {
                sketchParent = GameObject.FindWithTag("Sketch");
            }

            currentTrail = Instantiate(trailPrefab, transform.position, transform.rotation, transform);
            ApplySettings(currentTrail);
        }
    }

    // private void AttachParent(GameObject trailObject) 
    // {
    //     if (sketchParent == null) 
    //     {
    //         sketchParent = new GameObject("Sketch Parent");
    //     }

    //     trailObject.transform.SetParent(sketchParent.GetComponent<Transform>());
    //     // parent = sketchParent.transform;
    // }

    private void ApplySettings(GameObject trailObject)
    {
        TrailRenderer trailRenderer = trailObject.GetComponent<TrailRenderer>();
        trailRenderer.widthMultiplier = width;
        trailRenderer.startColor = color;
        trailRenderer.endColor = color;
    }

    private void ApplyEndSettings(GameObject trailObject)
    {
        TrailRenderer trailRenderer = trailObject.GetComponent<TrailRenderer>();
        trailRenderer.emitting = false;
    }

    public void EndTrail()
    {
        if (currentTrail)
        {
            Debug.Log("Ending Trail");

            if (sketchParent) 
            {
                currentTrail.transform.parent = sketchParent.GetComponent<Transform>();
            }            
            ApplyEndSettings(currentTrail);
            currentTrail = null;
            sketchParent = null;
        }
    }

    public void SetWidth(float value)
    {
        width = value;
    }

    public void SetColor(Color value)
    {
        color = value;
    }
}

