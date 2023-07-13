using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaterialControl : MonoBehaviour
{
    [SerializeField] public Material metal;
    [SerializeField] public Material wood;
    [SerializeField] public Material marble;
    [SerializeField] public Material pink;

    // Start is called before the first frame update
    void Start()
    {
        OnReset();
    }

    public void OnReset()
    {
        int i = Random.Range(1, 5);
        if (i == 1)
        { 
            GetComponent<MeshRenderer>().material = metal;
        }
        else if (i==2)
        {
            GetComponent<MeshRenderer>().material = wood;
        }
        else if (i==3)
        {
            GetComponent<MeshRenderer>().material = marble;
        }
        else
        {
            GetComponent<MeshRenderer>().material = pink;
        }
    }

    public void OnConfirm()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
