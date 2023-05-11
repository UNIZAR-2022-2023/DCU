using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    public string nextScene;
    public bool dead;
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
        if (dead){
            player.Dead();
        }
        else{
            player.SaveScore();
        }
        SceneManager.LoadScene(nextScene);
    }
}
