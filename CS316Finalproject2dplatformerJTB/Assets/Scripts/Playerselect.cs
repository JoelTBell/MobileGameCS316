using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerselect : MonoBehaviour
{
    public int characterIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
            characterIndex++;
            if(characterIndex > 1) //Or however many characters you want to switch between, I did 2 because I have 3 characters and start at 0
            { 
                characterIndex = 0;
            }
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            characterIndex--;
            if(characterIndex < 0)
            {
                characterIndex = 1;
            }
        }
    }
}
