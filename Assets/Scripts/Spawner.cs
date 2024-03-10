using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool canDrop;
    public float spawnerHeight;


    [SerializeField]
    float cooldownnow;
    public float cooldown;
    public float boarderL;
    public float BoarderR;

    public GameManager gm;
    public SpriteRenderer spr;

    int fruitNr;

    private void Start()
    {
        
    }

    void Update()
    {
        cooldownnow -= Time.deltaTime;

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z  = 0;
        mousePos.y = spawnerHeight;

        //neklauskit kodel
        if (mousePos.x<boarderL ||mousePos.x>BoarderR)
        {
            
        }
        else
        {
            transform.position = mousePos;
        }
        

        if (Input.GetKeyDown(KeyCode.Mouse0)&& cooldownnow<=0)
        {
            cooldownnow = cooldown;
            fruitNr = Random.Range(0, gm.fruitOrder.Count);
            ChangeFruit();
            Instantiate(gm.fruitOrder[fruitNr],transform.position,transform.rotation);

        }

    }
    public void ChangeFruit()
    {
        if (fruitNr == 0)
        {
            spr.color = Color.red;
        }
        else if (fruitNr == 1)
        {
            spr.color = Color.blue;
        }
        else if (fruitNr == 2)
        {
            spr.color = Color.yellow;
        }
        else 
        {
            spr.color = Color.green;
        }
        

    }
}
