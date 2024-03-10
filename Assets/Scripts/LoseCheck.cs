using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCheck : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hello");
        var fruit = collision.GetComponent<Fruit>();
        if (!fruit.justDropped)
        {
            gm.Lose();
        }
        
    }
}
