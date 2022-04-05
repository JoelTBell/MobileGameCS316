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
             if(P1Left == true)
             {
                  Move.MoveLeft();
             }
          }

          if(Player1Right.activeSelf == true)
          {
               P1Right = true;

               if(P1Right == true)
               {
                    Move.MoveRight();
               }
          }

          if(Player2Left.activeSelf == true)
          {
               P2Left = true;

               if(P2Left == true)
               {
                    Move.MoveLeft();
               }
          }

          if(Player2Right.activeSelf == true)
          {
               P2Right = true;

               if(P2Right == true)
               {
                    Move.MoveRight();
               }
          }
     }
 
     public void onRelease ()
     {
          if(Player1Left.activeSelf == true)
          {
             P1Left = false;   
          }

          if(Player1Right.activeSelf == true)
          {
               P1Right = false;
          }

          if(Player2Left.activeSelf == true)
          {
               P2Left = false;
          }

          if(Player2Right.activeSelf == true)
          {
               P2Left = false;
          }
     }
}
