using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiendaScript : MonoBehaviour
{
    public int tipo;
    public Sprite sprite;

    private void OnTriggerEnter2D(Collider2D col){
        switch (tipo)
        {
            case 1: //Player
                SpriteRenderer player = col.GetComponent<SpriteRenderer>();
                Animator animator = col.GetComponent<Animator>();
                
                player.sprite = sprite;
                
                break;
            case 2: //Enemies
                break;
            default:
                Debug.Log("Error al elegirt el mapa");
                break;
        }
    }
}
