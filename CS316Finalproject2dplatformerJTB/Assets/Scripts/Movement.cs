using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    Rigidbody2D blahblah;

    // Start is called before the first frame update
    void Start()
    {
        blahblah = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         // What Moves Us
        float horizontalInput = Input.GetAxis("Horizontal");

        //Get the value of the Horizontal input axis.
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
    }
}
