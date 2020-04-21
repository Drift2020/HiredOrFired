
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject PausePanel;
    // Start is called before the first frame update


    public void OnPauseGame()
    {
        Time.timeScale = 0;
        PausePanel.transform.SetAsLastSibling();
        StateScreen.isGameMenu = true;
        PausePanel.SetActive(true);
    }
    public void OffPauseGame()
    {
        Time.timeScale = 1;
        StateScreen.isGameMenu = false;
        PausePanel.SetActive(false);
    }
    public void GoToMenu()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        StateScreen.isGame = false;
        StateScreen.isGameMenu = false;
        StateScreen.isMainMenu = true;
        SceneManager.LoadScene("Menu");
    }


}
