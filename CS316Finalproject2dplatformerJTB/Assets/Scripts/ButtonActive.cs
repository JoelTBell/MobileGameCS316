using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActive : MonoBehaviour
{
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;

    public GameObject EB1;
    public GameObject EB2;
    public GameObject EB3;
    public GameObject EB4;

    public GameObject B1Activator;
    public GameObject B2Activator;
    public GameObject B3Activator;
    public GameObject B4Activator;

    public bool BA1 = false;
    public bool BA2 = false;
    public bool BA3 = false;
    public bool BA4 = false;
    // Start is called before the first frame update
    void Start()
    {
        EB1.SetActive(false);
        EB2.SetActive(false);
        EB3.SetActive(false);
        EB4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Player1")
        {
            Debug.Log("I've found a button");
            BA1 = true;
        }
        
         if(other.tag == "Player1")
        {
            Debug.Log("I've found the second button");
            BA2 = true;
        }

         if(other.tag == "Player2")
        {
            Debug.Log("I've found a button");
            BA3 = true;
        }

         if(other.tag == "Player2")
        {
            Debug.Log("I've found the first button");
            BA4 = true;
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if(BA1 == true)
        {
            Debug.Log("I've found a button");
            ButtonSelection();
        }
        
         if(BA2 == true)
        {
            Debug.Log("I've found the second button");
            ButtonSelection();
        }

         if(BA3 == true)
        {
            Debug.Log("I've found a button");
            ButtonSelection();
        }

         if(BA4 == true)
        {
            Debug.Log("I've found the second button");
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

            EB1.SetActive(true);
            EB2.SetActive(false);
            EB3.SetActive(false);
            EB4.SetActive(false);
        }

         if(BA2 == true)
        {
            BA1 = false;
            BA3 = false;
            BA4 = false;

            EB1.SetActive(false);
            EB2.SetActive(true);
            EB3.SetActive(false);
            EB4.SetActive(false);
        }

         if(BA3 == true)
        {
            BA1 = false;
            BA2 = false;
            BA4 = false;

            EB1.SetActive(false);
            EB2.SetActive(false);
            EB3.SetActive(true);
            EB4.SetActive(false);
        }

         if(BA4 == true)
        {
            BA1 = false;
            BA2 = false;
            BA3 = false;

            EB1.SetActive(false);
            EB2.SetActive(false);
            EB3.SetActive(false);
            EB4.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        EB1.SetActive(false);
        EB2.SetActive(false);
        EB3.SetActive(false);
        EB4.SetActive(false);

        BA1 = false;
        BA2 = false;
        BA3 = false;
        BA4 = false;
    }
}