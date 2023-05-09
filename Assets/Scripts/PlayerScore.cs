using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScore : MonoBehaviour
{   
    private int score = 0;
    private int health = 3;
    private Rigidbody2D Rigidbody2D;
    public TextMeshProUGUI scoreText;
    public GameObject[] vidas;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        //Comprobar score si ponemos una cantidad necesaria
    }
    public void Hit(){
        Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 4f);
        health--;
        if( health == 0){
        	string currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
        vidas[health].SetActive(false);
    }

    public void Kill(){
        score = score + 10;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Moneda"){
            score++;
            scoreText.text = score.ToString();
        }
    }
}
