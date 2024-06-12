using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenubutton : MonoBehaviour
{
    public GameObject LevelSelectMenu;

    public void OnClickPlay()
    {
        LevelSelectMenu.SetActive(true);
    }
 

    public void QuitGame()
    {
        Application.Quit();
    }
}
