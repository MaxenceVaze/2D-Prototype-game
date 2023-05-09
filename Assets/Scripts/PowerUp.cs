using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool Mushroom = false;
    void OnTriggerEnter2D(Collider2D trig)
    {
        Object.Destroy(this.gameObject);
        Mushroom = true;
    }
}
