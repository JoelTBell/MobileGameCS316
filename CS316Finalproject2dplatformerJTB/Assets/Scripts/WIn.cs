using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WIn : MonoBehaviour
{
    public bool P1warp = false;
    public bool P2warp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(P1warp == true && P2warp == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player1" || other.tag == "Player2")
        {
            Debug.Log("i found a player");
        }

        if(other.tag == "Player1")
        {
            Debug.Log("why isnt the warp working");
            P1warp = true;
        }

        if(other.tag == "Player2")
        {
            Debug.Log("why am i here");
            P2warp = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
         if(other.tag == "Player1")
        {
            P1warp = false;
        }

        if(other.tag == "Player2")
        {
            P2warp = false;
        }
    }

}
