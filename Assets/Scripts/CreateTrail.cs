using UnityEngine;

/// <summary>
/// This script creates a trail at the location of a gameobject with a particular width and color.
/// </summary>

public class CreateTrail : MonoBehaviour
{
    public GameObject trailPrefab = null;

    private float width = 0.05f;
    private Color color = Color.white;

    private GameObject currentTrail = null;

    public GameObject sketchParent;

    public void StartTrail()
    {
        if (!currentTrail)
        {

            if (sketchParent == null) 
            {
                sketchParent = new GameObject("Sketch Parent");
            }

            currentTrail = Instantiate(trailPrefab, transform.position, transform.rotation, transform);
            ApplySettings(currentTrail);
            // AttachParent(currentTrail);
        }
    }

    private void AttachParent(GameObject trailObject) 
    {
        if (sketchParent == null) 
        {
            sketchParent = new GameObject("Sketch Parent");
        }

        trailObject.transform.SetParent(sketchParent.GetComponent<Transform>());
        // parent = sketchParent.transform;
    }

    private void ApplySettings(GameObject trailObject)
    {
        TrailRenderer trailRenderer = trailObject.GetComponent<TrailRenderer>();
        trailRenderer.widthMultiplier = width;
        trailRenderer.startColor = color;
        trailRenderer.endColor = color;
    }

    public void EndTrail()
    {
        if (currentTrail)
        {
            currentTrail.transform.parent = sketchParent.GetComponent<Transform>();
            currentTrail = null;
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

