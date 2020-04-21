using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PieceFileDownWord : MonoBehaviour
{
    public TypeFile my_type;
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
    public CreaterPieceFileDown my_Creater;
    public Score my_score;
    public Image img;

    void Update()
    {
       
    }


    // Start is called before the first frame update
    void Start()
    {
        my_score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        my_type = TypeFile.Good;
        switch (Random.RandomRange(0, 6))
        {
            case 0:
            case 3:
            case 4:
                img.GetComponent<Image>().sprite = Resources.Load<Sprite>("file_exel");
                break;
                                 
            case 1:
            case 2:
            case 5:
                img.GetComponent<Image>().sprite = Resources.Load<Sprite>("file_word");
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
