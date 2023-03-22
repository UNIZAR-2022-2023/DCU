using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void Buena()
    {
        SceneManager.LoadScene("Win");
    }

    public void Mala(Button newButton)
    {
      newButton.interactable = false;  
    }
}
