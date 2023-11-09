using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SCR_Timer : MonoBehaviour
{
    [SerializeField]
    Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(flowchart.FindBlock("1 min"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
