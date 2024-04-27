using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishMenu : MonoBehaviour
{
    
    public void Exit2Button()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void Start2Game()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
