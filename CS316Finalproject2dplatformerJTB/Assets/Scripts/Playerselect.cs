using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerselect : MonoBehaviour
{
    public int characterIndex;

    public GameObject [] Players;

    public GameObject Player1LB;
    public GameObject Player1RB;
    public GameObject Player2LB;
    public GameObject Player2RB;

    public Camera Cma; //cma is cam
    // Start is called before the first frame update
    void Start()
    {
        Cma = Camera.main;
        Player2LB.SetActive(false);
        Player2RB.SetActive(false);
    }

   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
       {
           Change();
       }
    }

    public void Change()
    {
        Debug.Log("Im swapping places");
        characterIndex++;
        if(characterIndex > 1) //Or however many characters you want to switch between, I did 2 because I have 3 characters and start at 0
        { 
            characterIndex = 0;
           Player1LB.SetActive(!Player1LB.activeSelf);
           Player1RB.SetActive(!Player1RB.activeSelf);
           Player2LB.SetActive(!Player2LB.activeSelf);
           Player2RB.SetActive(!Player2RB.activeSelf); 
        }
        Cma.transform.parent = Players[characterIndex].transform;
        Cma.transform.localPosition = new Vector3(0.03f, 2.37f, -10f);
    }
}
