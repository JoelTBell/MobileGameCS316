using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    public GameObject Bridge1;
    public GameObject Bridge2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("i found a bridge");
        Bridge1.SetActive(true);
        Bridge2.SetActive(false);  
    }
}
