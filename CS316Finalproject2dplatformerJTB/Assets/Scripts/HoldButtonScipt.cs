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
 
     public void onPress ()
     {
          if(Move.Moving == true)
          {
               if(Player1Left || Player2Left)
               {
                    Move.MoveLeft;
               }
               else if(Player1Right || Player2Right)
               {
                    Move.MoveRight;
               }
          }
     }
 
     public void onRelease ()
     {
         
     }
}
