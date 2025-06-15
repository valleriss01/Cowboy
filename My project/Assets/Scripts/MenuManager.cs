using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadGameScene()
    {
        //SceneManager.LoadScene("Game");
        SceneManager.LoadSceneAsync("Game");
        Time.timeScale = 1;
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

    public void LoadCowBoyHubScene()
    {
        SceneManager.LoadSceneAsync("CowBoyHub");
        Time.timeScale = 1;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
