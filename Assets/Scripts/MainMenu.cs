using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Button play;
    public Button exit;

    public void clickPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void clickExit()
    {
        Application.Quit();
    }
}
