using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceFile : MonoBehaviour
{
    public List<Check> my_Check;
    bool isCheck;
    // Start is called before the first frame update
    void Start()
    {
        my_Check = new List<Check>();
        for(int i=0;i<transform.childCount;i++)
        {
            // my_Check.Add(transform.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateStatePieceFile()
    {
        foreach(var i in my_Check)
        {
            if (!i.IsCheck)
                return;
        }
        isCheck = true;
    }
}
