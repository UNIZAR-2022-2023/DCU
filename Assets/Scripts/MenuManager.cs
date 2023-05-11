using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
	public string next_scene;

    public void Buena()
    {
    	
        SceneManager.LoadScene(next_scene);
    }

    public void Mala(Button newButton)
    {
      newButton.interactable = false;  
    }
}

