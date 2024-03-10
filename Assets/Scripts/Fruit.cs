using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public bool justDropped=true;
    public GameManager gm;
    public int fruitnr;
    public float lifeTime;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        justDropped = false;

        if (collision.gameObject.CompareTag(gameObject.tag))
        {
            Merge(collision.gameObject);
        }
    }
    public void Merge(GameObject fruit)
    {
        gm.score++;
        var fr =fruit.gameObject.GetComponent<Fruit>();
        float frtime = fr.lifeTime;
        if (lifeTime<=fr.lifeTime)
        {
            Merge2(fruit);
            Destroy(gameObject);
        }
       

        /*
        //var timer = Random.Range(0.00000001f, 0.000001f);
        //Destroy(fruit,timer);
        if (fruitnr == gm.fruitOrder.Count)
        {
            Destroy(gameObject);
        }
        else
        {
            Instantiate(gm.fruitOrder[fruitnr-1]);
        }
        
        Destroy(gameObject);
        */
        //palaukti random laika ir tas kuris trumpesnis sunaikins letesni ir atsispawnins 1
    }
    public void Merge2(GameObject obj)
    {
        //last fruit no merge
        
        Instantiate(gm.fruitOrder[fruitnr--],transform.position,transform.rotation);
        Destroy(obj);
    }

}
