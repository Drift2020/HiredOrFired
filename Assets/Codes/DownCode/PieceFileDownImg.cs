using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PieceFileDownImg : MonoBehaviour
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
        img.GetComponent<Image>().sprite = Resources.Load<Sprite>("file_image");
   
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
