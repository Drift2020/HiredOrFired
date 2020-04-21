using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlerCrietor : MonoBehaviour
{

    public GameObject Left;
    public GameObject Right;
    public GameObject Up;

    public Image timeBar;


    public float time;
    float static_time;

    public float FirstState;
    public float SecondState;
    public float ThirdState;


    public float LeftTime;
    public float RightTime;
    public float UpTime;


    public float LeftSpead;
    public float RightSpead;
    public float UpSpead;

    public float FirstUpTime;
    public float FirstUpSpead;

    public float FirstLeftTime;
    public float FirstLeftSpead;

    public float FirstRightTime;
    public float FirstRightSpead;

    // Start is called before the first frame update
    void Start()
    {
        timeBar.color = Color.green;
        timeBar.fillAmount = 1f;

        Left.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = LeftSpead = FirstRightSpead;
        Left.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = LeftTime = FirstLeftTime;

        Right.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = RightSpead = FirstLeftSpead;
        Right.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = RightTime = FirstRightTime;

        Up.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = UpSpead = FirstUpSpead;
        Up.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = UpTime = FirstUpTime;

    }
    public void Play()
    {

        Left.SetActive(false);
        Right.SetActive(false);
        time = static_time;//4 min
    }

    void EndGame()
    {

        if (Score.score > 500)
        {
            StateGame.IsWin = true;
        }
        else
        {
            StateGame.IsWin = false;
        }

        SceneManager.LoadScene("FinishScene");
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
          
            time = time - Time.deltaTime;
            timeBar.fillAmount = time / 2 / 100;

          
       
             if (time < ThirdState)//1
            {
                timeBar.color = Color.red;
                Left.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = LeftSpead;
                Left.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = LeftTime;

                Right.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = RightSpead;
                Right.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = RightTime;

                Up.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().spead = UpSpead;
                Up.transform.GetChild(0).GetComponent<CreaterPieceFileDown>().time = UpTime;
            }
            else if (time < SecondState)//2
            {
                timeBar.color = Color.yellow;
                Right.SetActive(true);
            }
            else if (time < FirstState)//3
            {

                Left.SetActive(true);
            }
           
        }
        else
        {
            EndGame();
        }
    }
}
