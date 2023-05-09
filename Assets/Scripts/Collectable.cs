using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int Coins;
    public Player_Move Player;
    public Player_Health playerhealth;
    public PowerUp pu;
    Vector2 temp;
    // Update is called once per frame
    void Update()
    {
        if (Coins == 500)
        {
            Player.playerSpeed = 20;
            playerhealth.numberOfLife += 1;
            Coins = 0;
         }

        temp = transform.localScale;
        temp.x = 0.5f;
        temp.y = 0.5f;
        if (pu.Mushroom == true)
        {
            transform.localScale = temp;
        }
    }



 
   

}
