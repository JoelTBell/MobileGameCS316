using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActive : MonoBehaviour
{
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;

    public bool BA1 = false;
    public bool BA2 = false;
    public bool BA3 = false;
    public bool BA4 = false;
    // Start is called before the first frame update
    void Start()
    {
        B1.SetActive(false);
        B2.SetActive(false);
        B3.SetActive(false);
        B4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.GameObject.tag == B1)
        {
            BA1 = true;
            ButtonSelection();
        }
        
         if(other.GameObject.tag == B2)
        {
            BA2 = true;
            ButtonSelection();
        }

         if(other.GameObject.tag == B3)
        {
            BA3 = true;
            ButtonSelection();
        }

         if(other.GameObject.tag == B4)
        {
            BA4 = true;
            ButtonSelection();
        }
    }

    public void ButtonSelection()
    {
        if(BA1 == true)
        {
            BA2 = false;
            BA3 = false;
            BA4 = false;

            B1.SetActive(true);
        }

         if(BA2 == true)
        {
            BA1 = false;
            BA3 = false;
            BA4 = false;

            B2.SetActive(true);
        }

         if(BA3 == true)
        {
            BA1 = false;
            BA2 = false;
            BA4 = false;

            B3.SetActive(true);
        }

         if(BA4 == true)
        {
            BA1 = false;
            BA2 = false;
            BA3 = false;

            B4.SetActive(true);
        }
    }
}
