using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionManaher : MonoBehaviour
{
    public LevelDebug[] levelDebugs;
   
    public static int currLevel;
    public static int UnlockedLevels;

    public void OnclickLevel(int levelNum)
    {
        currLevel = levelNum;
        SceneManager.LoadScene("Level1");
    }
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
    }
    void Start()
    {
        UnlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 0);
        for(int i = 0; i < levelDebugs.Length; i++) 
        { 
            if(UnlockedLevels >= i)
            {
                levelDebugs[i].levelButton.interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
