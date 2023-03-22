using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void Update()
    {
        //Comprobar score si ponemos una cantidad necesaria
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
