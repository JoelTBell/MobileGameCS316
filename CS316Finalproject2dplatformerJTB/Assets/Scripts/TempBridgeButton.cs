using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempBridgeButton : MonoBehaviour
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

    void OnCollisionEnter2D()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            BridgeButton();
        }
    }

    public void BridgeButton()
    {
        Debug.Log("i found a bridge");
            Bridge1.SetActive(!Bridge1.activeSelf);
            Bridge2.SetActive(!Bridge2.activeSelf);
    }
}
