using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{   
    private int score;
    private int health;
    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        health = 3;
        Rigidbody2D = GetComponent<Rigidbody2D>();

        Debug.Log("health: " + health);
        Debug.Log("score: " + score);
    }

    private void Update()
    {
        //Comprobar score si ponemos una cantidad necesaria
    }
    public void Hit(){
        health--;
        Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 4f);
        if(health == 0) Destroy(gameObject);
        Debug.Log("health: " + health);
    }

    public void Kill(){
        score = score + 10;
        Debug.Log("score: " + score);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Moneda"){
            score++;
            Debug.Log("score: " + score);
        }
    }
}
