using UnityEngine;

/// <summary>
/// This script creates a trail at the location of a gameobject with a particular width and color.
/// </summary>

public class CreateLine : MonoBehaviour
{
    public GameObject linePrefab = null;
    private LineRenderer line;

    private float width = 0.04f;
    private Color color = Color.red;
    public float minVertexDist = 0.1f;

    private GameObject currentLine = null;
    // private bool isLineStarted = false;

    public GameObject sketchParent;

    private void Update() {
        if (currentLine) 
        {
            Vector3 currentPos = transform.position;
            float distance = Vector2.Distance(currentPos, line.GetPosition(line.positionCount - 1));
            if (distance > minVertexDist)
            {
                UpdateLine();
            }
        }
    }

    private void UpdateLine()
    {
        line.positionCount++;
        line.SetPosition(line.positionCount - 1, transform.position);
    }

    public void StartTrail()
    {
        if (!currentLine)
        {

            if (sketchParent == null)
            {
                sketchParent = GameObject.FindWithTag("Sketch");
            }

            currentLine = Instantiate(linePrefab, transform.position, transform.rotation, transform);           
            ApplySettings(currentLine);

            // line.positionCount = 0;

            Vector3 position = transform.position;
            
            line.SetPosition(0, position);
            line.SetPosition(1, position);
            // isLineStarted = true;
        }
    }

    private void ApplySettings(GameObject lineObject)
    {
        line = currentLine.GetComponent<LineRenderer>();

        line.startWidth = width;
        line.endWidth = width;

        line.startColor = color;
        line.endColor = color;

        line.positionCount = 2;
    }

    private void ApplyEndSettings(GameObject trailObject)
    {
        TrailRenderer trailRenderer = trailObject.GetComponent<TrailRenderer>();
        trailRenderer.emitting = false;
    }

    public void EndTrail()
    {
        if (currentLine)
        {
            Debug.Log("Ending Trail");

            if (sketchParent) 
            {
                currentLine.transform.parent = sketchParent.GetComponent<Transform>();
            }

            currentLine.GetComponent<BoxCollider>().center = transform.position;

            // ApplyEndSettings(currentTrail);
            currentLine = null;
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