using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuMeneger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject aboutPanel;
    public GameObject confirmDialog;
    public GameObject playButton;
    public GameObject PausePanel;




    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        StateScreen.isMainMenu = true;
        StateScreen.isGame = false;
        StateScreen.isGameMenu = false;
        StateScreen.setings = false;
        StateScreen.about = false;
        StateScreen.isConfirmDialog = false;

        //print(StateScreen.isGame);
    }



    public void GoToPlay()
    {
        StateScreen.isGame = true;
        StateScreen.isMainMenu = false;
        SceneManager.LoadScene("Gamev2");
        
    }

    public void GoToSetings()
    {
        StateScreen.setings = true;
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void GoToAbout()
    {
        StateScreen.about = true;
        mainMenuPanel.SetActive(false);
        aboutPanel.SetActive(true);
    }

    public void GoToBack()
    {
        StateScreen.isMainMenu = true;
        StateScreen.setings = false;
        StateScreen.about = false;
        aboutPanel.SetActive(false);
        settingsPanel.SetActive(false);
        confirmDialog.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void InitiateExit()
    {
        StateScreen.isConfirmDialog = true;
        confirmDialog.SetActive(true);
        playButton.SetActive(false);
    }

    public void ConfirmExit()
    {
        Application.Quit();
    }

    public void DenyExit()
    {
        confirmDialog.SetActive(false);
        playButton.SetActive(true);
    }
}
