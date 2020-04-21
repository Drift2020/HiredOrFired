using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void UpdateState();
public class File : MonoBehaviour
{
    public List<PieceFile> myPiece;
   
    // Start is called before the first frame update
    void Start()
    {
        myPiece = new List<PieceFile>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


  
}
