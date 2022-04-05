using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldButtonScipt : MonoBehaviour
{
     public GameObject Player1Left;
     public GameObject Player1Right;
     public GameObject Player2Left;
     public GameObject Player2Right;
     Movement Move;
     public bool P1Left = false;
     public bool P1Right = false;
     public bool P2Left = false;
     public bool P2Right = false;

     public void onPress ()
     {
          if(Player1Left.activeSelf == true)
          {

          }

          if(Player1Right.activeSelf == true)
          {
               
          }
     }
 
     public void onRelease ()
     {
         
     }
}
