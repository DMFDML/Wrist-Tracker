using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.IO;

public class Datalogging : MonoBehaviour
{
    Material material;
    float diameter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onConfirm()
    {
        material = GetComponent<MeshRenderer>().material;
        diameter = transform.localScale.x;
        Debug.Log(material);
        Debug.Log(diameter);
        string fileName = @"DataLog.txt";
        StreamWriter sw = new StreamWriter(fileName);
        string materialString = material.ToString();
        string diameterString = diameter.ToString();
        sw.WriteLine(materialString + diameterString + "m");
        sw.Close();

    }


}
