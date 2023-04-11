using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public int Mapa;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (Mapa)
        {
            case 1:
                Mapa1();
                break;
            case 2:
                Mapa2();
                break;
            case 3:
                Mapa3();
                break;
            case 4:
                Mapa4();
                break;
            default:
                Debug.Log("Error al elegirt el mapa");
                break;
        }
    }

    public void Mapa1()
    {
        SceneManager.LoadScene("Mapa_Vidrio");
    }

    public void Mapa2()
    {
        SceneManager.LoadScene("Win");
    }

    public void Mapa3()
    {
        SceneManager.LoadScene("Mapa1");
    }

    public void Mapa4()
    {
        SceneManager.LoadScene("Mapa1");
    }
}
