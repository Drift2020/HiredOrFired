using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    public bool win = false;
    public GameObject hired;
    public GameObject fired;
    public GameObject question;
    public GameObject cat;
    public GameObject message;
    public GameObject playAgain;
    public GameObject backToMenu;
    public SoundManager soundManager;

    public void Start()
    {
        win = StateGame.IsWin;
    }

    public void PlayAgain()
    {
		//123
        SceneManager.LoadScene("Gamev2");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ReadMessage()
    {
        try
        {
            PlayerPrefs.SetFloat("MusicVolume", 0.05f);
            PlayerPrefs.SetFloat("SoundsVolume", 0.25f);
            Debug.Log(PlayerPrefs.GetFloat("SoundsVolume"));
            soundManager.Play(win ? "Win" : "Loss");
        }
        catch { }
        message.SetActive(false);
        question.SetActive(false);
        hired.SetActive(win);
        fired.SetActive(!win);
        cat.SetActive(!win);
        playAgain.SetActive(true);
        backToMenu.SetActive(true);
    }
}
