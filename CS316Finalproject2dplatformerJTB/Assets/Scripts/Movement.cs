using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    Rigidbody2D RD2;
    public int characterIndex;
    Playerselect Pc; //Pc stands for Player choice
    public bool Moving;

    // Start is called before the first frame update
    void Start()
    {
        RD2 = GetComponent<Rigidbody2D>();
        Pc = FindObjectOfType<Playerselect>();
        Moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Pc.characterIndex!=characterIndex) return;
         // What Moves Us
       if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) )
       {
           Moving = true;
       }

       if(Moving == true)
       {
            if(Input.GetKeyDown(KeyCode.A))
            {
            MoveLeft();
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                MoveRight();
            }
       }
    }

    public void MoveLeft()
    {
        Debug.Log("im going Left!");

        float horizontalInput = Input.GetAxisRaw("Horizontal");

        //Get the value of the Horizontal input axis.
        transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
    }

    public void MoveRight()
    {
        Debug.Log("im going Right!");

        float horizontalInput = Input.GetAxisRaw("Horizontal");

        //Get the value of the Horizontal input axis.
        transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
    }
}
