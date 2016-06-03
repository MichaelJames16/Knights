using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Canvas pauseMenu;
    public Button mainMenu;
    public Button exit;

	// Use this for initialization
	void Start ()
    {
        pauseMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        // Pause and unpause the game
        if (Input.GetKeyDown("escape"))
        {
            pause();
        }
	}

    public void pause ()
    {
        if (!pauseMenu.enabled)
        {
            pauseMenu.enabled = true;
            Time.timeScale = 0;
        }
        else
        {
            pauseMenu.enabled = false;
        }
    }


    public void clickMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void clickExit()
    {
        Application.Quit();
    }
}
