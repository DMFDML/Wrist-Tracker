using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillManager : MonoBehaviour
{
    [SerializeField] GameObject Large;
    [SerializeField] GameObject Medium;
    [SerializeField] GameObject Small;
    Renderer[] Largers;
    Renderer[] Mediumrs;
    Renderer[] Smallrs;

    // Start is called before the first frame update
    void Start()
    {
        Largers = Large.GetComponentsInChildren<Renderer>();
        Mediumrs = Medium.GetComponentsInChildren<Renderer>();
        Smallrs = Small.GetComponentsInChildren<Renderer>();
        MakeMedium();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    [ContextMenu("MakeBig")]
    public void MakeBig()
    {
        foreach (Renderer r in Largers)
            r.enabled = true;
        foreach (Renderer r in Mediumrs)
            r.enabled = false;
        foreach (Renderer r in Smallrs)
            r.enabled = false;

    }

    [ContextMenu("MakeMedium")]
    public void MakeMedium()
    {
        foreach (Renderer r in Largers)
            r.enabled = false;
        foreach (Renderer r in Mediumrs)
            r.enabled = true;
        foreach (Renderer r in Smallrs)
            r.enabled = false;
    }

    [ContextMenu("MakeSmall")]
    public void MakeSmall()
    {
        foreach (Renderer r in Largers)
            r.enabled = false;
        foreach (Renderer r in Mediumrs)
            r.enabled = false;
        foreach (Renderer r in Smallrs)
            r.enabled = true;
    }
}
