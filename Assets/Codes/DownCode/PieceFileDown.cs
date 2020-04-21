using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public enum TypeFile
{
    Bug,
    Good,
    Bonus
}
public class PieceFileDown : MonoBehaviour
{
    public TypeFile my_type;
    public CreaterPieceFileDown my_Creater;
    public Score my_score;
    public Image img;



    public TypeFile typeFile
    {
        get
        {
            return my_type;
        }
        set
        {
            my_type = value;
        }
    }
    // Start is called before the first frame update

    void Update()
    {
      
    }


        void Start()
    {
        my_score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();


        switch (Random.RandomRange(0, 5))
        {
            case 0:
            case 1:
                my_type = TypeFile.Bug;
                img.GetComponent<Image>().sprite = Resources.Load<Sprite>("virus");



                break;
            case 2:
            case 3:
            case 4:

                switch (Random.RandomRange(0, 1))
                {

                    case 0:
                        my_type = TypeFile.Good;
                        img.GetComponent<Image>().sprite = Resources.Load<Sprite>("file_music");
                        break;



                    case 1:
                        my_type = TypeFile.Good;
                        img.GetComponent<Image>().sprite = Resources.Load<Sprite>("file_txt");
                        break;
                }

                break;
        }

    }
    public void Delete()
    {
        my_score.AddScore(typeFile);
        Destroy(gameObject);
    }
    void OnMouseDown()
    {
        Delete();
    }
}
