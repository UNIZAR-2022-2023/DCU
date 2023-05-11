using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScore : MonoBehaviour
{   
    private int score = 0;
    private int actualScore = 0;
    private int health = 3;
    private Rigidbody2D Rigidbody2D;
    public TextMeshProUGUI scoreText;
    public GameObject[] vidas;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        Rigidbody2D = GetComponent<Rigidbody2D>();
        scoreText.text = score.ToString();
        actualScore = 0;
    }

    private void Update()
    {
        //Comprobar score si ponemos una cantidad necesaria
    }

    
    public void Dead(){
        score = score - actualScore;
        SaveScore();
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    public void Hit(){
        Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 4f);
        health--;
        if( health == 0){
            Dead();
        }
        vidas[health].SetActive(false);
    }

    public void Kill(){
        actualScore = actualScore + 10;
        score = score + 10;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Moneda"){
            actualScore++;
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void SaveScore(){
        PlayerPrefs.SetInt("Score", score);
    }
}