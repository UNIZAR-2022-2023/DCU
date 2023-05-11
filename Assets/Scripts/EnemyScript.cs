using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null) return;
        Vector3 direction = Player.transform.position - transform.position;
        bool move = Mathf.Abs(Player.transform.position.x - transform.position.x) < 1.0f;
        if (direction.x >= 0.0f){
            transform.localScale = new Vector3(1.0f, 1.0f,1.0f);
            if(move) transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        } 
        else{
            transform.localScale = new Vector3(-1.0f, 1.0f,1.0f);
            if(move) transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        } 
    }

    private void OnTriggerEnter2D(Collider2D col){
        PlayerScore player = col.GetComponent<PlayerScore>();
         
        if (player != null && gameObject.tag == "Enemy"){
            if (transform.position.y < col.transform.position.y){
                Destroy(this.gameObject);
                player.Kill();
            }
            else{
                player.Hit();
            }
        }
        Debug.Log(col.gameObject.tag);
    }
}
