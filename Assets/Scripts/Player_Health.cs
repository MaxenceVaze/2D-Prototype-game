using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public bool hasDied;
    public int health;
    public int numberOfLife;
    public Checkpoint cp;
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
        numberOfLife = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            hasDied = true;
        }
        

        if (hasDied == true && cp.CheckpointTrigger == true) 
        {
            gameObject.transform.position = new Vector2(56, 1);
            hasDied = false;
            numberOfLife -= 1;
        }
        else if (hasDied == true && cp.CheckpointTrigger == false)
        {
            gameObject.transform.position = new Vector2(-8, 0);
            hasDied = false;
            numberOfLife -= 1;
        }


            if(numberOfLife < 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
