using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{   
    private int score;
    private Rigidbody2D Rigidbody2D;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Rigidbody2D = GetComponent<Rigidbody2D>();
        scoreText.text = "x" + score;
        Debug.Log("score: " + score);
    }

    private void Update()
    {
        //Comprobar score si ponemos una cantidad necesaria
    }
    public void Hit(){
        Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 4f);
        score--;
        scoreText.text = "x" + score;
        Debug.Log("score: " + score);
    }

    public void Kill(){
        score = score + 10;
        scoreText.text = "x" + score;
        Debug.Log("score: " + score);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Moneda"){
            score++;
            scoreText.text = "x" + score;
            Debug.Log("score: " + score);
        }
    }
}
