using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    public void OnLevelComplete()
    {
        if(LevelSelectionManaher.currLevel == LevelSelectionManaher.UnlockedLevels)
        {
            LevelSelectionManaher.UnlockedLevels++;
            PlayerPrefs.SetInt("UnlockedLevels", LevelSelectionManaher.UnlockedLevels);
        }
        SceneManager.LoadScene("Main Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
