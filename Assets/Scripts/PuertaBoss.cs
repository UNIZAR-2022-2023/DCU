using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaBoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        PlayerScore player = col.GetComponent<PlayerScore>();
        player.SaveScore();
        SceneManager.LoadScene("Puntuaciones");
    }
}
