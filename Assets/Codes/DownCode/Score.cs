using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Score : MonoBehaviour
{
    
    public static int score;
    public Text UI_score;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(TypeFile obj )
    {
    
        switch (obj)
        {
            case TypeFile.Bug:

                score -= 25;

                break;
            case TypeFile.Bonus:

                score += 35;

                break;
            case TypeFile.Good:
                score += 15;
                break;
        }
        UI_score.text = score.ToString();
    }
}
